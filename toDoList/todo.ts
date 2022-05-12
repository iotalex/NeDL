function AddTask() {
    
    
    let newTask : string = ""; //want test values
    newTask = (<HTMLInputElement>document.getElementById("newTask")).value; //value attached to HTML
    document.getElementById("myTableList").innerHTML = newTask + ': '//this value is printed into table


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