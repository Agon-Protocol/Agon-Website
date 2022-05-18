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
        filename: "agon.min.js",
        library: {
            type: "umd",
            name: "agon",
        },
    },
    resolve: {
        modules: ['node_modules'],
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