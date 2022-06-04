//https://nodejs.org/api/events.html  **useful, core info for node .js functions

const EventEmitter = require('events');  //this line is a class
const emitter = new EventEmitter;     //emitter is an obejct 

//Register a listener 
emitter.on('messageLogged', (arg) => { //event, e, or eventarg
    console.log('Listener called', arg);
});
//Raise an event 
emitter.emit('messageLogged', {id: 1, url: 'http://'});

//Raise: logging (data: message)