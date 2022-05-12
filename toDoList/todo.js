function AddTask() {
    var newTask = ""; //want test values
    newTask = document.getElementById("newTask").value; //value going into alert
    var tableRef = document.getElementById("myTableList");
    (document.getElementById("myTableList")).innerHTML = newTask + ': ';
    //alert (newTask);
}
//clears the table of all rows
function clearTask() {
    var tableRef = document.getElementById("myTableList");
    tableRef.innerHTML = " ";
}
