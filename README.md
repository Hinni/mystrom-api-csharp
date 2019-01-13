# mystrom-api-csharp

[![Build Status](https://dev.azure.com/hinnipipe/Github%20Pipeline/_apis/build/status/Hinni.mystrom-api-csharp?branchName=master)](https://dev.azure.com/hinnipipe/Github%20Pipeline/_build/latest?definitionId=1?branchName=master)
[![GitHub release](https://img.shields.io/github/release/Hinni/mystrom-api-csharp.svg)](https://github.com/Hinni/mystrom-api-csharp/releases)
[![NuGet](https://img.shields.io/nuget/v/MyStrom.Api.svg)](https://www.nuget.org/packages/MyStrom.Api/)

Inofficial myStrom API C# implementation.

## Download via NuGet

Install `MyStrom.Api` via NuGet package manager ([What is NuGet?](https://docs.microsoft.com/en-us/nuget/what-is-nuget))

    Install-Package MyStrom.Api

## Usage

```csharp
var uri = new System.Url("http://192.168.254.1"); # Use here your device IP
var client = new MyStrom.Api.Client(uri);

# use RefreshAll to load all available data
client.RefreshAll();

# or for example LoadReport if you only want to load temperature, relay state and power consumption
client.LoadReport();
```

## Documentation

I tested my implementation with `myStrom WiFi Switch` firmware `3.82.4`, which is available directly by [myStrom](https://mystrom.ch/en/firmware).
