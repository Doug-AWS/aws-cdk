import * as mockery from 'mockery';
import { ICallbackFunction, Test, testCase } from 'nodeunit';

let exitCalled: boolean = false;
let exitStatus: undefined | number;
function fakeExit(status?: number) {
    exitCalled = true;
    exitStatus = status;
}

const argv = { browser: 'echo %u' };

module.exports = testCase({
    '`cdk docs`': {
        'setUp'(cb: ICallbackFunction) {
            exitCalled = false;
            exitStatus = undefined;
            mockery.registerMock('../../lib/logging', {
                debug() { return; },
                error() { return; },
                warning() { return; }
            });
            mockery.enable({ useCleanCache: true, warnOnReplace: true, warnOnUnregistered: false });
            cb();
        },
        'tearDown'(cb: ICallbackFunction) {
            mockery.disable();
            mockery.deregisterAll();

            cb();
        },
        async 'exits with 0 when everything is OK'(test: Test) {
            mockery.registerMock('process', { ...process, exit: fakeExit });
            mockery.registerMock('aws-cdk-docs', { documentationIndexPath: 'index.html' });

            try {
                await require('../bin/commands/docs').handler(argv);
                test.ok(exitCalled, 'process.exit() was called');
                test.equal(exitStatus, 0, 'exit status was 0');
            } catch (e) {
                test.ifError(e);
            } finally {
                test.done();
            }
        },
        async 'exits with non-0 when documentation is missing'(test: Test) {
            mockery.registerMock('process', { ...process, exit: fakeExit });

            try {
                await require('../bin/commands/docs').handler(argv);
                test.ok(exitCalled, 'process.exit() was called');
                test.notEqual(exitStatus, 0, 'exit status was non-0');
            } catch (e) {
                test.ifError(e);
            } finally {
                test.done();
            }
        }
    }
});
