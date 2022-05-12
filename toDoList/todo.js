function AddTask() {
    var newTask = ""; //want test values
    newTask = document.getElementById("newTask").value; //value going into alert
    var tableRef = document.getElementById("myTaskList");
    (document.getElementById("myTaskList")).innerHTML = newTask + ': ';
    //newTask = (<HTMLInputElement>tableRef.document.forms("myTaskList")).value;
    //alert (newTask);
    //myTaskList is the access to the right table 
    // document.getElementById("myForm")!.innerHTML = "myForm " + newTask + " !";
}
