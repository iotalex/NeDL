async function getRandomExcuse() {
    // first build the API call string by starting with the URL
    var apiString = "https://excuser.herokuapp.com/v1/excuse";

    try {
   // now make the API call to the web service using the string and store what is returned in response
   var response = await fetch(apiString);
    }
    catch (error) {
        alert(error)
        throw error
    }
  
    // finally, print the response in the various formats
    document.getElementById("myRawData").innerHTML = "";   // clear what was previously shown
    document.getElementById("myFormattedData").innerHTML = "";   // clear what was previously shown

    var jsonData = await response.json();  // read the response as JSON
        // stringify and print out the JSON object in the RawData section
        document.getElementById("myRawData").innerHTML = JSON.stringify(jsonData);
        //and then iterate through id# that picks it up     
        let excuseText = JSON.stringify(jsonData[0]['excuse']);
        //alert(jsonData.length);
        alert(excuseText);
     
        
        document.getElementById("myFormattedData").innerHTML = "<p>" + excuseText + "</p>";

    return true;
  }
  
  