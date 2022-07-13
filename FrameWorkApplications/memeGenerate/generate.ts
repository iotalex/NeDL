async function getAllMemes() {
    // first build the API call string by starting with the URL
    var apiString = "https://namo-memes.herokuapp.com/";
      // apiString = apiString + "?type=meat&paras=" + theNewMeme;
    alert(apiString);  // show the API string

    try {
   // now make the API call to the web service using the string and store what is returned in response
   var response = await fetch(apiString);
     }
     catch (error) {
         alert(error)
         throw error
     }

     alert("Hey, we fired the API request!");
  
    // finally, print the response in the various formats
    document.getElementById("myRawData").innerHTML = "";   // clear what was previously shown
    document.getElementById("myFormattedData").innerHTML = "";   // clear what was previously shown
  
    
    return true;
  }
  
  