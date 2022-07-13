const EventEmitter = require('events');  //this line is a class

var url = 'http://mylogger.io/log';

    class Logger extends EventEmitter {  //class will have function define in emitter 
        log(message) {               //ability to log a message. 
            //Send an HTTP request 
            console.log(message);
            
            //Raise an event 
            this.emit('messageLogged', {id: 1, url: 'http://'}); //use "this" as it it exents alert for the class "Logger"
                                                                    //and EventEmitter class 
        }
}

module.exports = Logger;


    

 
