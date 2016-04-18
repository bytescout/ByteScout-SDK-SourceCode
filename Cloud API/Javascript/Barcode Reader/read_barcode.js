function onSubmit() 
{
    // Hide result blocks
    document.getElementById("errorBlock").style.display = "none";
    document.getElementById("resultBlock").style.display = "none";

    // Get API Key
    var apiKey = document.getElementById("apiKey").value.trim();
    if (apiKey == null || apiKey == "") {
        alert("API Key should not be empty.");
        return false;
    }

    // UPLOAD FILE

    var url = "https://bytescout.io/api/v1/file/upload?apiKey=" + apiKey; // Get your API key by registering at http://www.bytescout.io
    var formData = new FormData(document.getElementById("form1"));

    var httpRequest = new XMLHttpRequest();
    httpRequest.open("POST", url, true);

    // Handle asynchronous response
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState == 4) { 
            // If OK
            if (httpRequest.status == 200) {
                readBarcode(apiKey, httpRequest.responseText);
            }
            // Else display error
            else {
                document.getElementById("errorBlock").style.display = "block"; // show hidden errorBlock
                // Display error
                document.getElementById("statusCode").innerHTML = httpRequest.status + " - " + httpRequest.statusText;
                document.getElementById("errors").innerHTML = httpRequest.responseText;
            }
        }
    }

    httpRequest.send(formData);

    return true;
}

function readBarcode(apiKey, uploadedFileId)
{
    // Prepare URL
    var url = "https://bytescout.io/api/v1/barcodereader/read";
    url += "?apiKey=" + apiKey;
    url += "&inputType=fileID";
    url += "&input=" + uploadedFileId; // Specify uploaded file id
    url += "&outputType=content"; // Set output type Content.

    // Add selected barcode types to find
    var listBox = document.getElementById("barcodeTypesToFind");
    for (var i = 0; i < listBox.options.length; i++) {
        if (listBox.options[i].selected == true) {
            url += "&properties.barcodeTypesToFind." + listBox.options[i].value + "=true";
        }
    }

    // Prepare request
    var httpRequest = new XMLHttpRequest();
    httpRequest.open("GET", url, true);
    // Handle asynchronous response
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState == 4) {
            // If OK
            if (httpRequest.status == 200) {
                document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                document.getElementById("result").innerHTML = httpRequest.responseText;
            }
                // Else display error
            else {
                document.getElementById("errorBlock").style.display = "block"; // show hidden errorBlock
                // Display error
                document.getElementById("statusCode").innerHTML = httpRequest.status + " - " + httpRequest.statusText;
                document.getElementById("errors").innerHTML = httpRequest.responseText;
            }
        }
    }
    // Send request
    httpRequest.send();
}
