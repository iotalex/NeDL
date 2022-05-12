
function AddTask() {
    
    
    let newTask : string = ""; //want test values
    newTask = (<HTMLInputElement>document.getElementById("newTask")).value; //value attached to HTML
    document.getElementById("myTableList").innerHTML = newTask + ': '//this value is printed into table
    //print in a list
    //add a row to the list 

    //use bootstrap for the rest (maybe find a common UI to put in here)????

    //var tableRef = document.getElementById("myTableList");
    //    var tableRef: HTMLTableElement = <HTMLTableElement> document.getElementById("myTable");
    // alert (newTask);
//    var table: HTMLTableElement = document.getElementById("myTableList");


    
}


//clears the table of all rows
function clearTask(){
    
    var tableRef = document.getElementById("myTableList");
    tableRef.innerHTML = " ";
}