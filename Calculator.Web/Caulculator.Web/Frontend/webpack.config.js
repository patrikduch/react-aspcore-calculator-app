const webpack = require('webpack');
const path = require('path');

// Plugins
const ExtractTextPlugin = require('extract-text-webpack-plugin');

module.exports = {

    entry:"./src/index.js",
    output: {
        path: path.resolve(__dirname, '../wwwroot/'),
        filename: 'bundle.js'
    },


    module: {
        
        rules: [
            {
                use: 'babel-loader',
                test: /\.js$/,
                exclude: /node_modules/,

            }, // Babel-loader

            { 
                test: /\.css$/,
                use: ExtractTextPlugin.extract({
                    use: 'css-loader'
                })

            }, // CSS Loader


            {
                //use: ['style-loader', 'css-loader', 'sass-loader'],
                test: /\.scss$/,

                use: ExtractTextPlugin.extract({
                    use: ['css-loader','sass-loader']
                })
            } // SASS Loader


        ]

    },

    plugins:[
        new ExtractTextPlugin('style.css')
    ]

}