function checkPalindrome() {
    // place the values in the form into variables
    var theNewWord = document.forms["myForm"]["newWord"].value;

//find the length of a string
//let myForm = document.forms["myForm"];  // This gets the UI form
//let myWordControl = myForm["newWord"];  // This gets the <input/> control for the new word
//let newWordString = myWordControl.value;// This gets the value of the control, which is the new word (string)
//let newWordLen = newWordString.length;// This is getting the length of the string.  (integer)

    const len = document.forms["myForm"]["newWord"].value.length

    var theNewNumber = document.forms["myForm"]["newNumber"].value;
    // validate that something was entered as a word
    
   
    if (theNewWord == "") {
      alert("Please enter a word to check");
      return false;
    }
    // validate that a 1 or 2 was entered as a number
    else if ((theNewNumber != 1) && (theNewNumber != 2)) {
      // a 1 or 2 was not entered as the number so tell user and clear the field
      alert("Please enter a 1 or 2 for the list.");
      document.forms["myForm"]["newNumber"].value = "";
      return false;
    }

    else {
        // a word was entered and a 1 or 2 was entered as the number 
        // so add the word to the proper table 
        if (theNewNumber==1){
           var tableRef = document.getElementById("myList1");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ": " + checkPalindrome1(theNewWord);}
        else{
           var tableRef = document.getElementById("myList2");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ": " + checkPalindrome2(theNewWord);}
        // erase the form fields
        document.forms["myForm"]["newWord"].value = "";
        document.forms["myForm"]["newNumber"].value = "";
        return true;
    }

    
  }//end validate function

  // bb lol abba rotor abccba

//TODO: create a function for 1 palindrome algorithm  (bool)
// wordtocheck is a string that we need to validate
function checkPalindrome1(wordtocheck)///***stubbing it out */
{
  //TODO: what is logic to determin it's a palindrome

  //// TODO: Get string length
  let len = wordtocheck.length;
  let lastCharacterIndex = len - 1;  // If string is 8 characters, this will be 7
  // Start
  // Termination condition
  // Incrementer

  // i++ == i = i + 1 == ++i
  // rotor
  
  for (let i = 0; i < len / 2; i++) {

    // check if first and last string are same
//    if (document.forms["myForm"]["newWord"].value[i] !== document.forms["myForm"]["newWord"].value[len - 1 - i]) {
    if (wordtocheck[i] !== wordtocheck[lastCharacterIndex - i]) {
        return 'It is not a palindrome';
    }
  
  }
  //TODO: replace below with true
  return "it is a palindrome " + wordtocheck; 
}

//TODO: create a function for 2 palindrome algorithm 
function checkPalindrome2(wordtocheck)
{
  //TODO:  

  //TODO:
  return "in check palindrom 2 " + wordtocheck; 
}

  function clearList1() {
    // clear the table of all rows
    var tableRef = document.getElementById("myList1");
    tableRef.innerHTML = " ";
  }

  function clearList2() {
    // clear the table of all rows
    var tableRef = document.getElementById("myList2");
    tableRef.innerHTML = " ";
  }