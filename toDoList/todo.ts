function AddTask() {
    let newTask : string = ""; //want test values
    newTask = (<HTMLInputElement>document.getElementById("newTask")).value; //value going into alert
    var tableRef = document.getElementById("myTaskList");
           (document.getElementById("myTaskList")).innerHTML = newTask + ': ' 
    //alert (newTask);
  
}


//clears the first item, not done
function clearTask(){
    let newTask : string = ""; //want test values
    newTask = (<HTMLInputElement>document.getElementById("newTask")).value; //value going into alert
    var tableRef = document.getElementById("myTaskList");
           (document.getElementById("myTaskList")).innerHTML = "";
}