var mongoose = require('mongoose'),
    User = require('../models/User'),
    Message = require('../models/Message');

module.exports = function (connectionString) {
    mongoose.connect(connectionString);

    var db = mongoose.connection;

    db.once('open', function (error) {
        if (error) {
            console.log('Database could not be opened: ' + error);
            return;
        }

        console.log('MongoDB is now running...');
    });

    db.on('error', function (error) {
        console.log('Database error: ' + error);
    });
};
