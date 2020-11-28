# NanUI 0.8 Examples

[[中文](README.md)] | [English]

NanUI is an open source .NET/.NET Core component for Windows Form Applications. It's suitable for .NET/.NET Core developers who wants to use front-end technologies suc as HTMM5/CSS3/JavaScript to design the user interface of Windows Form Applications.

If you want to know about this project, please move to the project repository [NanUI for WinForms](https://github.com/NetDimension/NanUI).

This repository places examples of NanUI 0.8, which mainly covers the basic usage and demonstration of some special functions.

Later, it will be gradually expanded and updated according to the following catalog. Interested friends are also welcome to contribute!

## Compile

The sample project uses `TargetFrameworks` to specify the multi-target framework to compile, and currently includes two platforms: .NET Framework 4.7.2 and .NET Core 3.1.

If you need to compile to other platforms, please manually modify the target framework specified by `TargetFrameworks` in the project file `.csproj`.

As shown below, adding the `net5.0-windows` attribute can increase the compilation result of the .NET 5.0 platform.

For example, if the above example is to be compiled successfully, you need Visual Studio 2019 at least version 16.8, and install .NET Core 3.1 SDK, .NET Framework 4.7.2 SDK and .NET 5.0 SDK.

```XML
<TargetFrameworks>netcoreapp3.1;net472;net5.0-windows;</TargetFrameworks>
```

Please make sure that the version of Visual Studio 2019 you are using meets the minimum requirements of various SDKs, and that the SDKs of the corresponding framework platforms have been installed.

## Basic Usage

- [Welcome App](src/FormiumClient/README.md)

### Window Styles

- [Native Window](src/NativeStyleClient/README.md)
- [Borderless Window](src/BorderlessStyleClient/README.md)
- [Layerd Window](src/LayeredStyleClient/README.md)
- [Acrylic Window](src/AcrylicStyleClient/README.md) 

  **Tips**: This example works only on Windows 10 Creator Update or later. In other system, it can be run, but no acrylic effect.

## Plugins

## JavaScript Extensions

## Others