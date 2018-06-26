
#!/bin/bash
AWS_CDK=../@aws-cdk
for i in $( ls $AWS_CDK ); do
    AWS_CDK_PACKAGE=$AWS_CDK/$i/dist
    AWS_CDK_ASSEMBLY=$AWS_CDK_PACKAGE/assembly.jsii
    if [ -e $AWS_CDK_ASSEMBLY ]; then
        echo "Generating code for $i"
        jsii-pacmak -t dotnet -o ./src $AWS_CDK_PACKAGE
    fi
done


