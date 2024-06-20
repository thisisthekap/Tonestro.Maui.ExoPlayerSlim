#!/bin/bash
sudo dotnet workload restore
dotnet build -t:InstallAndroidDependencies -f net8.0-android -p:AcceptAndroidSDKLicenses=True -p:JavaSdkDirectory="/Users/ckapplmueller/Downloads/kappijava" -p:AndroidSdkDirectory="/Users/ckapplmueller/Downloads/kappiandroid"
dotnet build -c Release -p:JavaSdkDirectory="/Users/ckapplmueller/Downloads/kappijava" -p:AndroidSdkDirectory="/Users/ckapplmueller/Downloads/kappiandroid"
dotnet pack -c Release -p:JavaSdkDirectory="/Users/ckapplmueller/Downloads/kappijava" -p:AndroidSdkDirectory="/Users/ckapplmueller/Downloads/kappiandroid"
