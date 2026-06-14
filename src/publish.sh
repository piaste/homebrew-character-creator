#!/usr/bin/env bash
dotnet publish
pushd ./bin/Release/net8.0/publish/wwwroot
7z a -tzip ../../../../build.zip .
popd
