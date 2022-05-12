function AddTask() {
    var newTask = ""; //want test values
    newTask = document.getElementById("newTask").value; //value going into alert
    //var tableRef = document.getElementById("myTableList");
    document.getElementById("myTableList").innerHTML = newTask + ': ';
    //    var tableRef: HTMLTableElement = <HTMLTableElement> document.getElementById("myTable");
    // alert (newTask);
    //    var table: HTMLTableElement = document.getElementById("myTableList");
}
//clears the table of all rows
function clearTask() {
    var tableRef = document.getElementById("myTableList");
    tableRef.innerHTML = " ";
}
