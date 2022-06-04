//https://nodejs.org/api/http.html  - for HTML module// Class:net.Server class
//type in "http://localhost:3000/api/courses" to view the array build, it's a tiny backend server using node
const { Socket } = require('dgram');
const http = require('http');

const server = http.createServer((req, res) => {
    if (req.url === '/') {
        res.write('Hello World');
        res.end();
    }

    if (req.url === '/api/courses'){
        res.write(JSON.stringify([1, 2, 3]))
        res.end();
    }
});


server.listen(3000);

console.log('Listening on port 3000...');

