
const os = require('os');

var totalMemory = os.totalmem();
var freeMemory = os.freemem();

//console.log('Total memory: ' + totalMemory);

//Template string 

console.log(`Total Memory: ${totalMemory}`);
console.log(`Free Memory: ${freeMemory}`);