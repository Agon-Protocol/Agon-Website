// global dependencies
const path = require('path');
var nodeExternals = require('webpack-node-externals');

module.exports = {
    module: {
        rules: [
            {
                test: /\.ts$/,
                exclude: /(node_modules|bower_components)/,
                use: {
                    loader: "swc-loader",
                    options: {
                        jsc: {
                            parser: {
                                syntax: "typescript",
                            }
                        }
                    }
                }
            }
        ]
    },
    entry: './src/index.ts',
    output: {
        path: path.resolve(__dirname, '../wwwroot/js'),
        filename: "bundle.js",
    },
    resolve: {
        fallback: {
            "path": require.resolve("path-browserify"),
            "stream": require.resolve("stream-browserify"),
            "crypto": require.resolve("crypto-browserify")
        },
    }
};