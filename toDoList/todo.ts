
const myTasks: string[] = [];
function AddTask() {


    let newTask: string = ""; //want test values
    newTask = (<HTMLInputElement>document.getElementById("newTask")).value; //value attached to HTML
    myTasks.push(newTask);
    const myTableListHtml = ""; //assigning this to an empty string

    for (let task = 0; task < newTask.length; task++) {        //iteration loop builds up the list
        
        console.log("Balck statement" + task)
    }
    //console.log(newTask);
    document.getElementById("myTableList").innerHTML = myTableListHtml + ': ' + task;//this value is printed into table
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
// function clearTask() {

//     var tableRef = document.getElementById("myTableList");
//     tableRef.innerHTML = " ";
// }