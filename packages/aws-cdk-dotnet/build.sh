#!/bin/bash
SRC=./src
for i in $( ls $SRC ); do
    CSPROJ=./src/$i/$i.csproj
    if [ -e $CSPROJ ]; then
        dotnet build -c Release ./src/$i
    fi
done


