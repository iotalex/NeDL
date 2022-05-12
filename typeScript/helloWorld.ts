function myFunction() {
    let newName : string = "";
    newName = (<HTMLInputElement>document.getElementById("fname")).value;
    document.getElementById("greeting")!.innerHTML = "Greetings " + newName + " !";
}
