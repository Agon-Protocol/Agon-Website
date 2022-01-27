// global dependencies
const path = require('path');
const TerserPlugin = require("terser-webpack-plugin");

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
    target: 'web',
    entry: {
        filename: './src/index.ts'
    },
    output: {
        path: path.resolve(__dirname, '../wwwroot/js'),
        filename: "ludus.min.js",
        library: {
            type: "umd",
            name: "ludus",
        },
    },
    resolve: {
        modules: ['node_modules'],
        fallback: {
            "path": require.resolve("path-browserify"),
            "stream": require.resolve("stream-browserify"),
            "crypto": require.resolve("crypto-browserify")
        },
    },
    optimization: {
        minimize: true,
        minimizer: [new TerserPlugin({
            extractComments: false,
            terserOptions: {
                compress: true,
                format: {
                    comments: false,
                },
            },
        })],
    },
};