'use strict';

var users = require('../data/users-data'),
  encryption = require('../utilities/encryption');

var CONTROLLER_NAME = 'users';

module.exports = {
  getRegister: function (req, res, next) {
    res.render(CONTROLLER_NAME + '/register');
  },
  postRegister: function (req, res, next) {
    var user = req.body;
    console.log(user);
    if (!user) {
      req.session.error = 'Not all required fields are filled!';
      res.redirect('/register');
    }

    if (user.password !== user.confirmPassword) {
      req.session.error = 'Passwords do not match!';
      res.redirect('/register');
    } else {
      user.salt = encryption.generateSalt();
      user.passHash = encryption.generateHashedPassword(user.salt, user.password);

      users
        .create(user)
        .then(function (dbUser) {
          // TODO: login user?
          res.redirect('/login');
        });
    }
  },
  getLogin: function (req, res, next) {
    res.render(CONTROLLER_NAME + '/login');
  }
};
