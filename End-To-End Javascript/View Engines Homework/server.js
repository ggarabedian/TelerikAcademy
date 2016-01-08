(function() {
    'use strict';

    let express = require('express'),
        devices = require('./server/data'),
        app = express(),
        port = 3000;

    app.set('view engine', 'jade');
    app.set('views', './server/views');

    app.use(express.static('./public'));

    app.get('/', function(req, res) {
        res.render('home', { devices });
    });

    app.get('/*', function(req, res) {
        let data = devices[req.url.replace('/', '')];
        res.render('devices', { devices, data });
    });

    app.listen(port, () => console.log(`Server running http://localhost:${port}`));
}());
