function validateANDadd()
{
    //TODO: play items in box 
    var newWord = document.forms["myForm"]["newWord"].value;
    var newNumber = document.forms["myForm"]["newNumber"].value;
    //build if boolean 
    if(newWord == "")
    {
        alert("Please enter a word");
        return false;
    }
    // validate that a 1 or 2 was entered as a number
    else if ((theNewNumber != 1) && (theNewNumber != 2)) {
    // a 1 or 2 was not entered as the number so tell user and clear the field
    alert("Please enter a 1 or 2 for the list.");
    document.forms["myForm"]["newNumber"].value = "";
    return false;
    }









}//end validae function 