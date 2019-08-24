//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

function generateBarcode() {
    // Hide result blocks
    document.getElementById("errorBlock").style.display = "none";
    document.getElementById("resultBlock").style.display = "none";

    // Get barcode type
    var barcodeType = document.getElementById("barcodeType").value;
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
    url += "&async=True"; // Set async api

    // Prepare request
    var httpRequest = new XMLHttpRequest();
    httpRequest.open("GET", url, true);
     
    // Asynchronous response handler
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState == 4) {
            // If OK
            if (httpRequest.status == 200) {
                var result = JSON.parse(httpRequest.responseText);
                checkIfJobIsCompleted(result.jobId, result.url);
            }
            // Else display error
            else {
                document.getElementById("errorBlock").style.display = "block"; // show hidden errorBlock
                document.getElementById("error").innerHTML = "Request failed. Please check you use the correct API key.";

                // Hide loader
                showLoader(false);
            }
        }
    }
    // Send request
    httpRequest.send();

    return true;
}

function checkIfJobIsCompleted(jobId, resultFileUrl) {

    var url = 'https://localhost/job/check?jobid=' + jobId;

    // Prepare request
    var httpRequest = new XMLHttpRequest();
    httpRequest.open("GET", url, true);
     
    // Asynchronous response handler
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState == 4) {
            // If OK
            if (httpRequest.status == 200) {
                var jobResult = JSON.parse(httpRequest.responseText);

                if (jobResult.status == "working") {
                    // Check again after 3 seconds
                    setTimeout(function(){
                        checkIfJobIsCompleted(jobId, resultFileUrl);
                    }, 3000);
                }
                else if (jobResult.status == "working") {
                    document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                    document.getElementById("image").setAttribute("src", resultFileUrl); // Set image link to display

                    // Hide loader
                    showLoader(false);
                }
            }
            // Else display error
            else {
                document.getElementById("errorBlock").style.display = "block"; // show hidden errorBlock
                document.getElementById("error").innerHTML = "Request failed. Please check you use the correct API key.";

                // Hide loader
                showLoader(false);
            }
        }
    }

    // Send request
    httpRequest.send();
}


function showLoader(isDisplay) {
    var loader = document.getElementById("loader");

    if (isDisplay) {
        loader.style.display = "";
    }
    else {
        loader.style.display = "none";
    }
}
