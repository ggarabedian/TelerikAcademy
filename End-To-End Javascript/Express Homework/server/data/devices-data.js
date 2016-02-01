'use strict';

var request = require('request'),
    fs = require('fs');
var Recipe = require('mongoose').model('Device');

module.exports = {
  create: function(device) {
    if (device.imageUrl) {
      request(device.imageUrl).pipe(fs.createWriteStream('public/images/'+ device.name +'.jpg')).on('close', function() {
      });

      device.imageUrl = '/images/'+ device.name +'.jpg';
    }
    else {
      device.imageUrl = '/images/Phone.jpg';
    }

    var promise = new Promise(function(resolve, reject) {
      Recipe.create(device, function(err, dbDevice) {

        if (err) {
          console.log('Failed to create recipe: ' + err);
          return;
        }

        if (!dbDevice) {
          console.log('Recipe could not be saved in database!');
          return;
        }

        resolve(dbDevice);
      });
    });

    return promise;
  },
  getAll: function(page, category, sortBy) {
    var promise = new Promise(function(resolve, reject) {
      var query = {};
      var sort = {};

      if (category) {
        query = { category: category };
      }

      if (sortBy) {
        if (sortBy === 'name') {
          sort[sortBy] = 'asc';
        }
        else {
          sort[sortBy] = 'desc';
        }
      }
      else {
        sort = { createdOn: 'desc' }
      }

      Recipe.paginate(query, { page: page || 1, limit: 8, sort: sort }, function(err, devices) {
        if (err) {
          reject('Failed to get all recipes: ' + err);
          return;
        }

        if (!devices) {
          reject('No recipes found int DB: ' + err);
          return;
        }

        devices.category = category || "";
        devices.sortBy = sortBy || "";

        resolve(devices);
      });
    });

    return promise;
  },
  getById: function(id) {
    var promise = new Promise(function(resolve, reject) {
      Recipe.findOne({_id: id}).lean(true).exec(function(err, device) {

        if (err) {
          reject('Failed to get recipe details: ' + err);
          return;
        }

        if(!device){
          reject('Recipe not found: ' + err);
        }

        resolve(device);
      });
    });

    return promise;
  }
};
