import { codebuild } from '@aws-cdk/resources';
import { BucketRef } from '@aws-cdk/s3';
import { BuildProject } from './project';

export abstract class BuildArtifacts {
    public abstract toArtifactsJSON(): codebuild.ProjectResource.ArtifactsProperty;
    public bind(_project: BuildProject) {
        return;
    }
}

export class NoBuildArtifacts  extends BuildArtifacts {
    public toArtifactsJSON(): codebuild.ProjectResource.ArtifactsProperty {
        return { type: 'NO_ARTIFACTS' };
    }
}

export class CodePipelineBuildArtifacts extends BuildArtifacts {
    public toArtifactsJSON(): codebuild.ProjectResource.ArtifactsProperty {
        return { type: 'CODEPIPELINE' };
    }
}

export interface S3BucketBuildArtifactsProps {
    /**
     * The name of the output bucket.
     */
    bucket: BucketRef;

    /**
     * The path inside of the bucket for the build output .zip file or folder.
     * If a value is not specified, then build output will be stored at the root of the
     * bucket (or under the <build-id> directory if `includeBuildId` is set to true).
     */
    path?: string;

    /**
     * The name of the build output ZIP file or folder inside the bucket.
     *
     * The full S3 object key will be "<path>/build-ID/<name>" or
     * "<path>/<artifactsName>" depending on whether `includeBuildId` is set to true.
     */
    name: string;

    /**
     * Indicates if the build ID should be included in the path. If this is set to true,
     * then the build artifact will be stored in "<path>/<build-id>/<name>".
     *
     * @default true
     */
    includeBuildID?: boolean;

    /**
     * If this is true, all build output will be packaged into a single .zip file.
     * Otherwise, all files will be uploaded to <path>/<name>
     *
     * @default true - files will be archived
     */
    packageZip?: boolean;
}

export class S3BucketBuildArtifacts extends BuildArtifacts {
    constructor(private readonly props: S3BucketBuildArtifactsProps) {
        super();
    }

    public bind(project: BuildProject) {
        this.props.bucket.grantReadWrite(project.role);
    }

    public toArtifactsJSON(): codebuild.ProjectResource.ArtifactsProperty {
        return {
            type: 'S3',
            location: this.props.bucket.bucketName,
            path: this.props.bucket.path,
            namespaceType: this.parseNamespaceType(this.props.includeBuildID),
            name: this.props.name,
            packaging: this.parsePackaging(this.props.packageZip),
        };
    }

    private parseNamespaceType(includeBuildID?: boolean) {
        if (includeBuildID != null) {
            return includeBuildID ? 'BUILD_ID' : 'NONE';
        } else {
            return 'BUILD_ID';
        }
    }

    private parsePackaging(packageZip?: boolean) {
        if (packageZip != null) {
            return packageZip ? 'ZIP' : 'NONE';
        } else {
            return 'ZIP';
        }
    }
}
