function AddTask() {
    var newTask = ""; //want test values
    newTask = document.getElementById("newTask").value; //value going into alert
    var tableRef = document.getElementById("myTaskList");
    (document.getElementById("myTaskList")).innerHTML = newTask + ': ';
    //alert (newTask);
}
function clearTask() {
    var newTask = ""; //want test values
    newTask = document.getElementById("newTask").value; //value going into alert
    var tableRef = document.getElementById("myTaskList");
    (document.getElementById("myTaskList")).innerHTML = "";
}
