'use strict';

var devices = require('../data/devices-data');

module.exports = {
  getAllDevices: function(req, res, next) {
    devices.getAll(req.query.page, req.query.category, req.query.sortBy)
           .then(function (devices) {
             res.render('devices/all', { devices });
           })
  },
  getDeviceDetails: function(req, res, next) {
    devices.getById(req.params.id)
           .then(function (device) {

             res.render('devices/details', { device });
           });
  },
  getAddNewDevice: function(req, res, next) {
    res.render('devices/add');
  },
  postAddNewDevice: function(req, res, next) {
    var device = req.body;
    devices.create(device)
           .then(function(dbDevice) {
              res.redirect('/devices');
            });
  }
};
