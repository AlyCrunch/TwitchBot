const { join } = require('path');

module.exports = {
    devtool: "inline-source-map",
    entry: './src/index.ts',
    output: {
        filename: 'app.js',
        path: join(__dirname, '/dist/'),
        publicPath: '/dist/'
    },
    module: {
        rules: [
            {
                test: /\.tsx?$/,
                loader: "ts-loader",
                exclude: /node_modules/
            }
        ]
    },
    resolve: {
        extensions: [".tsx", ".ts", ".js"]
    },
    devServer: {
        contentBase: __dirname
    }
}