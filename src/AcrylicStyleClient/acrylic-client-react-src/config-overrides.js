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
      filename: "static/js/[name].bundle.[hash:8].js",
      chunkFilename: "static/js/[name].chunk.[chunkhash:8].js",
    });

    console.log(config);

    return config;
  }
);
