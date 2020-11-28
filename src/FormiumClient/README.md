# Formium Client

This example uses React and Bootstrap to make user interface. 

Build the front-ends from directory below.

```console
cd ..\formium-client-react-src
npm run build
```

The Webpack will publish files of `formium-client-react-src` to `wwwroot` direcroy in root of this project.

Select the necessary files in `wwwroot` and set `Build Action` options to `Embedded resource`. If you don't know how, please see [documentation](https://github.com/NetDimension/NanUI/blob/master/docs/documentation.md) of NanUI.

Or you can modify the csproj file and add configurations below to embedded all files in this directory:
```xml
<ItemGroup>
    <None Remove="wwwroot\**" />
    <EmbeddedResource Include="wwwroot\**" />
</ItemGroup>
```






