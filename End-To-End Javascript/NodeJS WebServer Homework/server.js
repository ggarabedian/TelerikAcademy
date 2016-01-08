var http = require('http'),
    fs = require('fs'),
    url = require('url'),
    formidable = require('formidable'),
    jade = require('jade'),
    port = 3000;

http.createServer(function (req, res) {
    if (req.url == '/upload' && req.method.toLowerCase() == 'post') {

        var form = new formidable.IncomingForm();
        form.encoding = 'utf-8';
        form.uploadDir = "files";
        form.keepExtensions = true;

        form.parse(req, function(err, fields, files) {
          res.writeHead(302, {'Location': '/'});
          res.write('received upload:\n\n');
          res.end();
        });

        return;
    }

    if(req.url === '/'){
        fs.readFile("./views/index.jade", function (err, jadeTemplate) {
            if(err) {
                res.end(err);
                return;
            }

            fs.readdir('./files/', function (error, files) {
                if(error) {
                    res.end(error);
                    return;
                }

                var output = jade.compile(jadeTemplate)({
                    files: files
                });

                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.write(output);
                res.end();
            });
        });
    }
}).listen(port);

console.log('Server is running on port ' + port)
