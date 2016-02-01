'use strict';

var mongoose = require('mongoose');
var mongoosePaginate = require('mongoose-paginate');

module.exports = (function() {
  var deviceSchema = mongoose.Schema({
    name: { type: String, required: true },
    createdOn: { type: Date, default: Date.now },
    imageUrl: { type: String },
    description: { type: String },
    category: { type: String, required: true },
    ram: { type: String },
    processor: { type: String },
    price: { type: String },
    display: { type: String }
  });

  deviceSchema.plugin(mongoosePaginate);

  mongoose.model('Device', deviceSchema);
}());
