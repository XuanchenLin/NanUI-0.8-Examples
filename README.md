# NanUI 0.8 示例

[中文] | [[English](README.en-US.md)]

NanUI 界面组件是一个开放源代码的 .NET / .NET Core 窗体应用程序（WinForms）界面组件。她适用于希望使用 HTML5/CSS3 等前端技术来构建 Windows 窗体应用程序用户界面的 .NET/.NET Core 开发人员。

如果想了解本项目，请移步到项目仓库[NanUI for WinForms](https://github.com/NetDimension/NanUI)。

这个仓库放置 NanUI 0.8 版本的示例，主要涵盖了使用基础以及一些特色功能的演示。

后期会根据下面目录逐步扩展和更新。也欢迎有兴趣的朋友投稿！

## 编译

示例项目使用`TargetFrameworks`指定多目标框架编译，目前包括了 .NET Framework 4.7.2 和 .NET Core 3.1 两个平台。

如果需要编译到其他平台，请手动修改项目文件`.csproj`中的`TargetFrameworks`所指定的目标框架。

如下所示，加入`net5.0-windows`属性，即可增加 .NET 5.0 平台的编译结果。

```XML
<TargetFrameworks>netcoreapp3.1;net472;net5.0-windows;</TargetFrameworks>
```

此外，请确保您使用的 Viusal Studio 2019 版本满足各种 SDK 的最低要求，并确保相对应的各个框架平台的 SDK 均已安装。

比如要按照上述例子编译成功，需要 Visual Studio 2019 至少 16.8 版，并且安装了 .NET Core 3.1 SDK， .NET Framework 4.7.2 SDK 以及 .NET 5.0 SDK。

## 基础

- [欢迎项目](src/FormiumClient/README.md)

### 窗体样式

- [原生窗体](src/NativeStyleClient/README.md)
- [无边框窗体](src/BorderlessStyleClient/README.md)
- [异形窗体](src/LayeredStyleClient/README.md)
- [亚克力窗体](src/AcrylicStyleClient/README.md)

以上示例如未安装 NanUI Runtime 依赖，那么请自行安装。

```
PM> Install-Package NetDimension.NanUI.Runtime -Version 80.1.15
```

如果您在国内 NuGet 访问较慢无法下载`NetDimension.NanUI.Runtime`包时，请您加QQ群`521854872`在群文件中下载NuGet 离线包 。

## 插件

  暂无内容，欢迎投稿。

## JavaScript 相关

  暂无内容，欢迎投稿。

## 其他

  暂无内容，欢迎投稿。





