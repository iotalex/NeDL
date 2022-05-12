function AddTask() {
    var table = document.getElementById("myTaskTable");


    let newTask : string = ""; //want test values
    newTask = (<HTMLInputElement>document.getElementById("myTaskTable")).value; //value going into alert
    var tableRef = document.getElementById("myTaskTable");
    (document.getElementById("myTaskTable")).innerHTML = newTask + ': '
    
    //alert (newTask);
    
}


//clears the table of all rows
function clearTask(){
    
    var tableRef = document.getElementById("myTaskTable");
    tableRef.innerHTML = " ";
}