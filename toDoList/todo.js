function AddTask() {
    var newTask = ""; //want test values
    newTask = document.getElementById("newTask").value; //value going into alert
    var tableRef = document.getElementById("myTaskList");
    (document.getElementById("myTaskList")).innerHTML = newTask + ': ';
    //alert (newTask);
}
//clears the first item, not done
function clearTask() {
    var tableRef = document.getElementById("myTaskList");
    tableRef.innerHTML = " ";
}
