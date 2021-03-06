import { spawn } from 'child_process';
import * as colors from 'colors/safe';
import * as fs from 'fs-extra';
import * as os from 'os';
import * as path from 'path';
import { error, print, warning } from './logging';

// tslint:disable:no-var-requires those libraries don't have up-to-date @types modules
const camelCase = require('camelcase');
const decamelize = require('decamelize');
// tslint:enable:no-var-requires

const TEMPLATES_DIR = path.join(__dirname, 'init-templates');

/**
 * Initialize a CDK package in the current directory
 */
export async function cliInit(type: string, language: string | undefined) {
    const template = (await availableInitTemplates).find(t => t.hasName(type));
    if (!template) {
        await printAvailableTemplates(language);
        throw new Error(`Unknown init template: ${type}`);
    }
    if (!language && template.languages.length === 1) {
        language = template.languages[0];
        warning(`No --language was provided, but '${type}' supports only '${language}', so defaulting to --language=${language}`);
    }
    if (!language) {
        print(`Available languages for ${colors.green(type)}: ${template.languages.map(l => colors.blue(l)).join(', ')}`);
        throw new Error('No language was selected');
    }
    await initializeProject(template, language);
}

const INFO_DOT_JSON = 'info.json';

export class InitTemplate {
    public static async fromName(name: string) {
        const basePath = path.join(TEMPLATES_DIR, name);
        const languages = (await listDirectory(basePath)).filter(f => f !== INFO_DOT_JSON);
        const info = await fs.readJson(path.join(basePath, INFO_DOT_JSON));
        return new InitTemplate(basePath, name, languages, info);
    }

    public readonly description: string;
    public readonly aliases = new Set<string>();

    constructor(private readonly basePath: string,
                public readonly name: string,
                public readonly languages: string[],
                info: any) {
        this.description = info.description;
        for (const alias of info.aliases || []) {
            this.aliases.add(alias);
        }
    }

    /**
     * @param name the name that is being checked
     * @returns ``true`` if ``name`` is the name of this template or an alias of it.
     */
    public hasName(name: string): boolean {
        return name === this.name || this.aliases.has(name);
    }

    /**
     * Creates a new instance of this ``InitTemplate`` for a given language to a specified folder.
     *
     * @param language        the language to instantiate this template with
     * @param targetDirectory the directory where the template is to be instantiated into
     */
    public async install(language: string, targetDirectory: string) {
        if (this.languages.indexOf(language) === -1) {
            error(`The ${colors.blue(language)} language is not supported for ${colors.green(this.name)} `
                  + `(it supports: ${this.languages.map(l => colors.blue(l)).join(', ')})`);
            throw new Error(`Unsupported language: ${language}`);
        }
        await this.installFiles(path.join(this.basePath, language), targetDirectory, {
            name: decamelize(path.basename(path.resolve(targetDirectory)))
        });
    }

    private async installFiles(srcDir: string, tgtDir: string, project: ProjectInfo) {
        for (const file of await fs.readdir(srcDir)) {
            const fromFile = path.join(srcDir, file);
            const toFile = path.join(tgtDir, this.expand(file, project));
            if ((await fs.stat(fromFile)).isDirectory()) {
                await fs.mkdir(toFile);
                await this.installFiles(fromFile, toFile, project);
                continue;
            } else if (file.match(/^.*\.template\.[^.]+$/)) {
                await this.installProcessed(fromFile, toFile.replace(/\.template(\.[^.]+)$/, '$1'), project);
            } else {
                await fs.copy(fromFile, toFile);
            }
        }
    }

    private async installProcessed(templatePath: string, toFile: string, project: ProjectInfo) {
        const template = await fs.readFile(templatePath, { encoding: 'utf-8' });
        await fs.writeFile(toFile, this.expand(template, project));
    }

    private expand(template: string, project: ProjectInfo) {
        const cdkVersion = require('@aws-cdk/core/package.json').version.replace(/\+[a-f0-9]+$/, '');
        return template.replace(/%name%/g, project.name)
                       .replace(/%name\.camelCased%/g, camelCase(project.name))
                       .replace(/%name\.PascalCased%/g, camelCase(project.name, { pascalCase: true }))
                       .replace(/%cdk-version%/g, cdkVersion);
    }
}

interface ProjectInfo {
    /** The value used for %name% */
    readonly name: string;
}

export const availableInitTemplates: Promise<InitTemplate[]> =
    new Promise(async resolve => {
        const templateNames = await listDirectory(TEMPLATES_DIR);
        const templates = new Array<InitTemplate>();
        for (const templateName of templateNames) {
            templates.push(await InitTemplate.fromName(templateName));
        }
        resolve(templates);
    });
export const availableInitLanguages: Promise<string[]> =
    new Promise(async resolve => {
        const templates = await availableInitTemplates;
        const result = new Set<string>();
        for (const template of templates) {
            for (const language of template.languages) {
                result.add(language);
            }
        }
        resolve([...result]);
    });
/**
 * @param dirPath is the directory to be listed.
 * @returns the list of file or directory names contained in ``dirPath``, excluding any dot-file, and sorted.
 */
async function listDirectory(dirPath: string) {
    return (await fs.readdir(dirPath))
                    .filter(p => !p.startsWith('.'))
                    .sort();
}

export async function printAvailableTemplates(language?: string) {
    print('Available templates:');
    for (const template of await availableInitTemplates) {
        if (language && template.languages.indexOf(language) === -1) { continue; }
        print(`* ${colors.green(template.name)}: ${template.description}`);
        const languageArg = language ? colors.bold(language)
                                     : template.languages.length > 1 ? `[${template.languages.map(t => colors.bold(t)).join('|')}]`
                                                                     : colors.bold(template.languages[0]);
        print(`   └─ ${colors.blue(`cdk init ${colors.bold(template.name)} --language=${languageArg}`)}`);
    }
}

async function initializeProject(template: InitTemplate, language: string) {
    await assertIsEmptyDirectory();
    const useGit = await initializeGitRepository();
    print(`Applying project template ${colors.green(template.name)} for ${colors.blue(language)}`);
    await template.install(language, process.cwd());
    await postInstall(language);
    if (useGit) {
        await execute('git', 'add', '.');
        await execute('git', 'commit', '--message="Initial commit"', '--no-gpg-sign');
    }
    if (await fs.pathExists('README.md')) {
        print(colors.green(await fs.readFile('README.md', { encoding: 'utf-8' })));
    } else {
        print(`✅ All done!`);
    }
}

async function assertIsEmptyDirectory() {
    const files = await fs.readdir(process.cwd());
    if (files.length !== 0) {
        throw new Error('`cdk init` cannot be run in a non-empty directory!');
    }
}

async function initializeGitRepository() {
    if (await isInGitRepository(process.cwd())) { return false; }
    print('Initializing a new git repository...');
    await execute('git', 'init');
    return true;
}

async function postInstall(language: string) {
    switch (language) {
    case 'typescript':
        return await postInstallTypescript();
    }
}

async function postInstallTypescript() {
    const cdkHome = process.env.CDK_HOME ? path.resolve(process.env.CDK_HOME) : path.join(os.homedir(), '.cdk');
    const yNpm = path.join(cdkHome, 'bin', 'y-npm');
    const command = await fs.pathExists(yNpm) ? yNpm : 'npm';
    print(`Executing ${colors.green(`${command} install`)}...`);
    if (await execute(command, 'install') !== 0) {
        throw new Error(`${colors.green(`${command} install`)} failed!`);
    }
}

/**
 * @param dir a directory to be checked
 * @returns true if ``dir`` is within a git repository.
 */
async function isInGitRepository(dir: string) {
    while (true) {
        if (await fs.pathExists(path.join(dir, '.git'))) { return true; }
        if (isRoot(dir)) { return false; }
        dir = path.dirname(dir);
    }
}

/**
 * @param dir a directory to be checked.
 * @returns true if ``dir`` is the root of a filesystem.
 */
function isRoot(dir: string) {
    return path.dirname(dir) === dir;
}

function execute(cmd: string, ...args: string[]): Promise<number> {
    return new Promise<number>((resolve, reject) => {
        try {
            const child = spawn(cmd, args, { stdio: 'inherit' });
            child.on('exit', (code, _signal) => {
                if (code != null) {
                    resolve(code);
                } else {
                    resolve(128);
                }
            });
        } catch (e) {
            reject(e);
        }
    });
}
