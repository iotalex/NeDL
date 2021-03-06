const express = require('express');
const app = express();

app.get('/', (req, res) => {
    res.send('Hello Word');
});

app.get('/api/courses', (req, res) => {
    res.send([1, 2, 3]);
});

// /api/course/1
app.get('/api/posts/:year/:month', (req, res) => {
    res.send(res.params.id);
});

const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Listening on port ${port}...`));

//https://youtu.be/pKd0Rpw7O48?t=1314 left off here
