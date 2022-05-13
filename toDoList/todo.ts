
const myTasks: string[] = [];
function AddTask() {

    // First we need to get the user input from the text box, and add it to the task list
    let newTask: string = ""; //want test values
    // Get the value of the new task that the user entered
    newTask = (<HTMLInputElement>document.getElementById("newTask")).value; //value attached to HTML
    // Add the new task to the existing array
    myTasks.push(newTask);

    //*****/ Next, we need to update the page with the list of all tasks the user has already entered

    // Starting off with empty string, but this represents the HTML contained in the list element
    let myTableListHtml = ""; //assigning this to an empty string

    for (let index = 0; index < myTasks.length; index++) {   //iteration loop builds up the list
        // Iterating through each item, we need to build the text that will be displayed on the
        // page for that item
        let itemText = "<tr><td>" + myTasks[index] + "</td></tr>";//<td> represents the table cell; this is best syntax
        // Add that text to the table list HTML string
        myTableListHtml = myTableListHtml + itemText;
        //console.log(myTasks[index]);//iterates items to the array index 
    }
   
    document.getElementById("myTableList").innerHTML = myTableListHtml 
}//end function AttTask()


//clears the table of all rows
function clearTask() {

    var tableRef = document.getElementById("myTableList");
    tableRef.innerHTML = " ";
}