import { expect, matchTemplate } from '@aws-cdk/assert';
import { Stack } from '@aws-cdk/core';
import { LambdaInlineCode, LambdaRuntime } from '@aws-cdk/lambda';
import { Test } from 'nodeunit';
import { SingletonLambda } from '../lib';

export = {
  'can add same singleton Lambda multiple times, only instantiated once in template'(test: Test) {
    // GIVEN
    const stack = new Stack();

    // WHEN
    for (let i = 0; i < 5; i++) {
      new SingletonLambda(stack, `Singleton${i}`, {
        uuid: '84c0de93-353f-4217-9b0b-45b6c993251a',
        code: new LambdaInlineCode('def hello(): pass'),
        runtime: LambdaRuntime.Python27,
        handler: 'index.hello',
        timeout: 300,
      });
    }

    // THEN
    expect(stack).to(matchTemplate({
      Resources: {
        SingletonLambda84c0de93353f42179b0b45b6c993251aServiceRole26D59235: {
          Type: "AWS::IAM::Role",
          Properties: {
            AssumeRolePolicyDocument: {
              Statement: [
                {
                  Action: "sts:AssumeRole",
                  Effect: "Allow",
                  Principal: { Service: "lambda.amazonaws.com" }
                }
              ],
              Version: "2012-10-17"
            },
            ManagedPolicyArns: [
              {
                "Fn::Join": [ "", [ "arn", ":", { Ref: "AWS::Partition" }, ":", "iam", ":", "",
                    ":", "aws", ":", "policy", "/", "service-role/AWSLambdaBasicExecutionRole" ] ]
              }
            ]
          }
        },
        SingletonLambda84c0de93353f42179b0b45b6c993251a840BCC38: {
          Type: "AWS::Lambda::Function",
          Properties: {
            Code: {
              ZipFile: "def hello(): pass"
            },
            Handler: "index.hello",
            Role: { "Fn::GetAtt": [ "SingletonLambda84c0de93353f42179b0b45b6c993251aServiceRole26D59235", "Arn" ] },
            Runtime: "python2.7",
            Timeout: 300
          },
          DependsOn: [ "SingletonLambda84c0de93353f42179b0b45b6c993251aServiceRole26D59235" ]
        }
      }
    }));

    test.done();
  }
};
