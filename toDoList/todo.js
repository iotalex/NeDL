var myTasks = [];
function AddTask() {
    // First we need to get the user input from the text box, and add it to the task list
    var newTask = ""; //want test values
    // Get the value of the new task that the user entered
    newTask = document.getElementById("newTask").value; //value attached to HTML
    // Add the new task to the existing array
    myTasks.push(newTask);
    // Next, we need to update the page with the list of all tasks the user has already entered
    // Starting off with empty string, but this represents the HTML contained in the list element
    var myTableListHtml = ""; //assigning this to an empty string
    for (var index = 0; index < myTasks.length; index++) { //iteration loop builds up the list
        // Iterating through each item, we need to build the text that will be displayed on the
        // page for that item
        var itemText = "<tr>" + myTasks[index] + "</tr><br/>";
        // Add that text to the table list HTML string
        myTableListHtml = myTableListHtml + itemText;
        //console.log(myTasks[index]);//iterates items to the array index 
    }
    // Some comment
    // Set the inner HTML, which will display the list of tasks on the page
    document.getElementById("myTableList").innerHTML = myTableListHtml;
    //console.log(newTask);
    //*this works* document.getElementById("myTableList").innerHTML = myTableListHtml + ': '//this value is printed into table
    //chunky monkey
    // for (var _i = 0, myTasks_1 = myTasks; _i < myTasks_1.length; _i++) {
    //     var task = myTasks_1[_i];
    //     console.log(task);
    // for (let i = 0; i < myTasks.length; i++)  
    // {
    // }
    //document.getElementById("myTableList").innerHTML = myTableListHtml + ': '//this value is printed into table
    //alert (newTask);
    //console.log(newTask)
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
