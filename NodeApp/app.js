//https://nodejs.org/api/events.html  **useful, core info for node .js functions
const EventEmitter = require('events');

const Logger = require('./logger');
const logger = new Logger();
//Register a listener 
logger.on('messageLogged', (arg) => { //event, e, or eventarg
    console.log('Listener called', arg);
});

logger.log('message');
