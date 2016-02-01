'use strict';

var auth = require('./auth'),
  controllers = require('../controllers');

module.exports = function(app) {
  app.get('/register', controllers.users.getRegister);
  app.post('/register', controllers.users.postRegister);

  app.get('/login', controllers.users.getLogin);
  app.post('/login', auth.login);
  app.get('/logout', auth.isAuthenticated, auth.logout);
  app.get('/devices', controllers.devices.getAllDevices);
  app.get('/devices/add', controllers.devices.getAddNewDevice);
  app.post('/devices/add', controllers.devices.postAddNewDevice);
  app.get('/devices/:id', controllers.devices.getDeviceDetails);

  app.get('/', function(req, res) {
    res.render('index');
  });

  app.get('*', function(req, res) {
    res.render('index');
  });
};
