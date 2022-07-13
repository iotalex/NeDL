var myTasks = [];
//const arr: string[] = ['one', 'two',];
function AddTask() {
    // First we need to get the user input from the text box, and add it to the task list
    var newTask = ""; //want test values
    // Get the value of the new task that the user entered
    newTask = document.getElementById("newTask").value; //value attached to HTML
    // Add the new task to the existing array
    myTasks.push(newTask);
    rerenderTaskList();
    //*****/ Next, we need to update the page with the list of all tasks the user has already entered
    /*
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
        */
} //end function AddTask()
//clears the table of all rows
function removeTask() {
    //write someething to count the number of strings (array items)
    //define variable 
    var lastItemIndex = myTasks.length - 1;
    myTasks.splice(lastItemIndex, 1);
    rerenderTaskList();
    //find the value of the array (or number of items); we can use myTasks.length
    // Do the dishes
    // Mow the lawn
    // Take a shower
    //myTasks[lastItemIndex] = "";
    // Do the dishes
    // Mow the lawn
    // 
    //if index = 2, write "" on 2; 
    //3 items, if(there are three items, remove 2)
    //remove - write " " on 2 regarding table list 
    //
    // Remove last task that was entered
    // Re-render the list of tasks on the UI
    // let removeTask: string = ""; //want to delete values
    // // Delete the value of the new task that the user entered
    // removeTask = (<HTMLInputElement>document.getElementById("newTask")).value; //value attached to HTML
    // //Delete the new task from exisit array 
    // removeTask.repeat(removeTask);
    //*****/ Next, we need to update the page with the list of all tasks the user has already entered
    // Starting off with empty string, but this represents the HTML contained in the list element
    //var tableRef = document.getElementById("myTableList");
    //tableRef.innerHTML = " "
}
function clearTask() {
    // Remove all tasks from the array
    //write someething to count the number of strings (array items)
    myTasks.splice(0, myTasks.length);
    // Update the UI
    rerenderTaskList();
}
function rerenderTaskList() {
    // Starting off with empty string, but this represents the HTML contained in the list element
    var myTableListHtml = ""; //assigning this to an empty string
    for (var index = 0; index < myTasks.length; index++) { //iteration loop builds up the list
        // Iterating through each item, we need to build the text that will be displayed on the
        // page for that item
        var itemText = "<tr><td>" + myTasks[index] + "</td></tr>"; //<td> represents the table cell; this is best syntax
        // Add that text to the table list HTML string
        myTableListHtml = myTableListHtml + itemText;
        //console.log(myTasks[index]);//iterates items to the array index 
    }
    document.getElementById("myTableList").innerHTML = myTableListHtml;
}
// var tableRef = document.getElementById("myTableList");
//     tableRef.innerHTML = " ";
