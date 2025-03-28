//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

function generateBarcode()
{
    // Hide result blocks
    document.getElementById("errorBlock").style.display = "none";
    document.getElementById("resultBlock").style.display = "none";

    // Get barcode type
    var barcodeType=document.getElementById("barcodeType").value;
    // Get barcode value
    var inputValue = document.getElementById("inputValue").value.trim();
    if (inputValue == null || inputValue == "") {
        alert("Barcode Value should not be empty.");
        return false;
    }

    //show loader
    showLoader(true);

    // Prepare URL
    var url = "https://localhost/barcode/generate?name=barcode.png";
    url += "&type=" + barcodeType; // Set barcode type (symbology)
    url += "&value=" + inputValue; // Set barcode value

    // Prepare request
    var httpRequest = new XMLHttpRequest();
    httpRequest.open("GET", url, true);
     
    // Asynchronous response handler
    httpRequest.onreadystatechange = function() {
        if (httpRequest.readyState == 4) {
            // If OK
            if (httpRequest.status == 200) {
                var result = JSON.parse(httpRequest.responseText);
                if (result.error == false) {
                    document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                    document.getElementById("image").setAttribute("src", result.url); // Set image link to display
                }
                else {
                    document.getElementById("errorBlock").style.display = "block"; // show hidden errorBlock
                    document.getElementById("error").innerHTML = result.message;
                }
            }
            // Else display error
            else {
                document.getElementById("errorBlock").style.display = "block"; // show hidden errorBlock
                document.getElementById("error").innerHTML = "Request failed. Please check you use the correct API key.";
            }

            // Hide loader
            showLoader(false);
        }
    }
    // Send request
    httpRequest.send();

    return true;
}

function showLoader(isDisplay){
    var loader = document.getElementById("loader");

    if(isDisplay){
        loader.style.display = "";
    }
    else{
        loader.style.display="none";
    }
}
