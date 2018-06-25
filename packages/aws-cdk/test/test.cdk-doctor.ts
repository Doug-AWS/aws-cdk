import * as mockery from 'mockery';
import { ICallbackFunction, Test, testCase } from 'nodeunit';

let exitCalled: boolean = false;
let exitStatus: undefined | number;
function fakeExit(status?: number) {
    exitCalled = true;
    exitStatus = status;
}

module.exports = testCase({
    '`cdk doctor`': {
        'setUp'(cb: ICallbackFunction) {
            exitCalled = false;
            exitStatus = undefined;
            mockery.registerMock('../../lib/logging', {
                print: () => undefined
            });
            mockery.enable({ useCleanCache: true, warnOnReplace: true, warnOnUnregistered: false });
            cb();
        },
        'tearDown'(cb: ICallbackFunction) {
            mockery.disable();
            mockery.deregisterAll();

            cb();
        },
        'exits with 0 when everything is OK'(test: Test) {
            mockery.registerMock('process', { ...process, exit: fakeExit });
            mockery.registerMock('aws-cdk-docs/package.json', { version: 'x.y.z' });

            test.doesNotThrow(() => require('../bin/commands/doctor').handler());
            test.ok(exitCalled, 'process.exit() was called');
            test.equal(exitStatus, 0, 'exit status was 0');
            test.done();
        },
        'exits with non-0 when documentation is missing'(test: Test) {
            mockery.registerMock('process', { ...process, exit: fakeExit });

            test.doesNotThrow(() => require('../bin/commands/doctor').handler());
            test.ok(exitCalled, 'process.exit() was called');
            test.notEqual(exitStatus, 0, 'exit status was non-0');
            test.done();
        }
    }
});
