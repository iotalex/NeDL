function AddTask() {
    let newTask : string = ""; //want test values

    newTask = (<HTMLInputElement>document.getElementById("newTask")).value; //value going into alert
    var tableRef = document.getElementById("myTaskList");
           (document.getElementById("myTaskList")).innerHTML = newTask + ': ' 
    //alert (newTask);


  
}