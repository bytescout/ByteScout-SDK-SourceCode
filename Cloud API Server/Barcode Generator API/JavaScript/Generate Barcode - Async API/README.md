## How to generate barcode async API for barcode generator API in JavaScript and ByteScout Cloud API Server

### How to generate barcode async API in JavaScript with easy ByteScout code samples to make barcode generator API. Step-by-step tutorial

We regularly create and update our sample code library so you may quickly learn barcode generator API and the step-by-step process in JavaScript. ByteScout Cloud API Server helps with barcode generator API in JavaScript. ByteScout Cloud API Server is the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

Use the code displayed below in your application to save a lot of time on writing and testing code.  This sample code in JavaScript is all you need. Just copy-paste it to the code editor, then add a reference to ByteScout Cloud API Server and you are ready to try it! Enjoy writing a code with ready-to-use sample JavaScript codes to implement barcode generator API using ByteScout Cloud API Server.

ByteScout Cloud API Server - free trial version is available on our website. Also, there are other code samples to help you with your JavaScript application included into trial version.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****generate_barcode.js:**
    
```
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
```

<!-- code block end -->