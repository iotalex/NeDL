var myTasks = [];
function AddTask() {
    var newTask = ""; //want test values
    newTask = document.getElementById("newTask").value; //value attached to HTML
    myTasks.push(newTask);
    var myTableListHtml = ""; //assigning this to an empty string
    for (var i = 0; i < 3; i++) //iteration loop builds up the list 
     {
        if ((myTableListHtml)) {
        }
    }
    document.getElementById("myTableList").innerHTML = myTableListHtml + ': '; //this value is printed into table
    //print in a list
    //add a row to the list 
    //use bootstrap for the rest (maybe find a common UI to put in here)????
    //var tableRef = document.getElementById("myTableList");
    //    var tableRef: HTMLTableElement = <HTMLTableElement> document.getElementById("myTable");
    // alert (newTask);
    //    var table: HTMLTableElement = document.getElementById("myTableList");
}
//clears the table of all rows
function clearTask() {
    var tableRef = document.getElementById("myTableList");
    tableRef.innerHTML = " ";
}
