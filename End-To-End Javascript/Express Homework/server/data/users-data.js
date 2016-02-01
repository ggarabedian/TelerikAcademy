'use strict';

var User = require('mongoose').model('User');

module.exports = {
  create: function (user) {
    var promise = new Promise(function (resolve, reject) {
      User.create(user, function (err, dbUser) {
        if (err) {
          if (err.code === 11000) {
            reject('Username has already been taken!');
          } else {
            reject(err);
          }
        }

        if (!dbUser) {
          reject('User could not be saved in database!');
        }

        resolve(dbUser);
      });
    });

    return promise;
  }
};
