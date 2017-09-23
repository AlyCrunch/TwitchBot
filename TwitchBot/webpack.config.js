const { join } = require('path');

module.exports = {
    devtool: "inline-source-map",
    entry: {
        app: './ClientApp/index.ts'
    },
    output: {
        filename: '[name].js',
        path: join(__dirname, 'wwwroot/dist/'),
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
    }
};
