#!/bin/bash

rm -rf ./src
mkdir ./src
dotnet new sln -n AWS.Cdk -o ./src

AWS_CDK=../@aws-cdk
for i in $( ls $AWS_CDK ); do
    AWS_CDK_PACKAGE=$AWS_CDK/$i/dist
    AWS_CDK_ASSEMBLY=$AWS_CDK_PACKAGE/assembly.jsii
    if [ -e $AWS_CDK_ASSEMBLY ]; then
        echo "Generating code for $i"
        jsii-pacmak -t dotnet -o ./src $AWS_CDK_PACKAGE
    fi
done


# Ensure that all generated projects are added to the solution.
SRC=./src
for i in $( ls $SRC ); do
    CSPROJ=./src/$i/$i.csproj
    if [ -e $CSPROJ ]; then
        dotnet sln ./src/AWS.Cdk.sln add $CSPROJ
    fi
done


