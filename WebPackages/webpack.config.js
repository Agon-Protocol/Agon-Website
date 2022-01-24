// global dependencies
const path = require('path');

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
                            },
                            keepClassNames: false,
                        }
                    }
                }
            }
        ]
    },
    target: 'node',
    entry: './src/index.ts',
    output: {
        path: path.resolve(__dirname, '../wwwroot/js'),
        filename: "bundle.js",
    },
    externalsPresets: {
        node: true // in order to ignore built-in modules like path, fs, etc.
    },
};