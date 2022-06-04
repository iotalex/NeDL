//https://nodejs.org/api/events.html  **useful, core info for node .js functions

const EventEmitter = require('events');  //this line is a class
const emitter = new EventEmitter;     //emitter is an obejct 

//Register a listener 
emitter.on('messageLogged', function(){
    console.log('Listener called');
});
//Raise an event 
emitter.emit('messageLogged');

//emit = making a noise, produce- signalling an event