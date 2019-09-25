## How to generate barcode for barcode generator API in JavaScript using ByteScout Cloud API Server

### Learn in simple ways: How to generate barcode for barcode generator API in JavaScript

This page displays the step-by-step instructions and algorithm of how to generate barcode and how to apply it in your application. Barcode generator API in JavaScript can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

This simple and easy to understand sample source code in JavaScript for ByteScout Cloud API Server contains different functions and options you should do calling the API to implement barcode generator API. This JavaScript sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. Writing JavaScript application mostly includes various stages of the software development so even if the functionality works please check it with your data and the production environment.

Our website provides free trial version of ByteScout Cloud API Server that gives source code samples to assist with your JavaScript project.

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
```

<!-- code block end -->