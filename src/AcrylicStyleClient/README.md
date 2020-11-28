# Acrylic Style Client

This example uses React and Bootstrap to make user interface. 

Build the front-ends from directory below.

```console
cd ..\acrylic-client-react-src
npm run build
```

The Webpack will publish files of `acrylic-client-react-src` to `build` direcroy.

Select the necessary files in `build` and set `Build Action` options to `Embedded resource`. If you don't know how, please see [documentation](https://github.com/NetDimension/NanUI/blob/master/docs/documentation.md) of NanUI.

Or you can modify the csproj file and add below:
```xml
<ItemGroup>
    <None Remove="build\**" />
    <EmbeddedResource Include="build\**" />
</ItemGroup>
```






