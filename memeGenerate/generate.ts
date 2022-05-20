async function getAllMemes() {
    // first build the API call string by starting with the URL
    var apiString = "https://mememaker.github.io/API/";
    // next add the parameters to the string using the drop down lists
    var theNewParagraphs = document.getElementById("newParagraphs").value;
    apiString = apiString + "?type=meat&paras=" + theNewParagraphs;
    alert(apiString);  // show the API string
  
    // now make the API call to the web service using the string and store what is returned in response
    var response = await fetch(apiString);
  
    // finally, print the response in the various formats
    document.getElementById("myRawData").innerHTML = "";   // clear what was previously shown
    document.getElementById("myFormattedData").innerHTML = "";   // clear what was previously shown
  
    var jsonData = await response.json();  // read the response as JSON
    // Check HTTP status code; exit out / return error message if not 200 (HTTP_STATUS_SUCCESS)
    var statusCode = jsonData['code'];
    // Create for loop using jsonData['data'].length
    //how many elements do I have in the json? 
        //and then iterate through id# that picks it up 


    // stringify and print out the JSON object in the RawData section
    document.getElementById("myRawData").innerHTML = JSON.stringify(jsonData);
   
    // loop through the JSON object one paragraph at a time and print each in the FormattedData section
    for (var para in jsonData) {   
        document.getElementById("myFormattedData").innerHTML += "<p>" + jsonData[para] + "</p>";
      }
  
    return true;
  }
  
  