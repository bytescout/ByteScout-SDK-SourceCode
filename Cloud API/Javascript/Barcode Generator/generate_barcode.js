function generateBarcode()
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
    // Get barcode type
    var barcodeType=document.getElementById("barcodeType").value;
    // Get barcode value
    var inputValue = document.getElementById("inputValue").value.trim();
    if (inputValue == null || inputValue == "") {
        alert("Barcode Value should not be empty.");
        return false;
    }

    // Prepare URL
    var url = "https://bytescout.io/api/v1/barcode/generate";
    url += "?apiKey=" + apiKey; // Get your API key by registering at http://www.bytescout.io
    url += "&properties.symbology=" + barcodeType; // Set barcode type (symbology)
    url += "&input=" + inputValue; // Set barcode value
    url += "&outputType=link"; // Set output type Link

    // Prepare request
    var httpRequest = new XMLHttpRequest();
    httpRequest.open("GET", url, true);
    // Handle asynchronous response
    httpRequest.onreadystatechange = function() {
        if (httpRequest.readyState == 4) {
            // If OK
            if (httpRequest.status == 200) {
                var imageLink = httpRequest.responseText;
                document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                document.getElementById("image").setAttribute("src", imageLink); // Set image link to display
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

    return true;
}
