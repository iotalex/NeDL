
const { Socket } = require('dgram');
const http = require('http');

const server = http.createServer((req, res) => {
    if (req.url === '/') {
        res.write('Hello World');
        res.end();
    }

    if (req.url === '/api/courses'){
        res.write(JSON.stringify([1, 2, 3])) //this is how you are going to respond to the client
        res.end();
    }
});


server.listen(3000);

console.log('Listening on port 3000...');

