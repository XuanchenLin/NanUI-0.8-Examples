const { override, fixBabelImports, addWebpackAlias } = require("customize-cra");

const path = require("path");

process.env.GENERATE_SOURCEMAP = false;

module.exports = override(
  fixBabelImports("import", {
    libraryName: "antd",
    libraryDirectory: "es",
    style: "css",
  }),
  addWebpackAlias({
    "@": path.resolve(__dirname, "src"),
  }),
  (config) => {
    Object.assign(config.output, {
      filename: "static/js/[name].bundle.js",
      chunkFilename: "static/js/[name].chunk.js",
    });

    const paths = require("react-scripts/config/paths");

    const buildPath = path.resolve(__dirname, "../AcrylicStyleClient/build");

    paths.appBuild = buildPath;
    config.output.path = buildPath;

    return config;
  }
);
