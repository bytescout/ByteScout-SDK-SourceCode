function createPdfInvoice()
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
    
    var templateUrl = document.getElementById("templateUrl").value.trim();
    var templateData = document.getElementById("templateData").value.trim();
    
    // Prepare URL
    var url = "https://bytescout.io/api/v1/htmltopdf/convert";
    url += "?apiKey=" + apiKey; // Get your API key by registering at http://www.bytescout.io
    url += "&properties.templateData=" + encodeURIComponent(templateData); // Set page orientation
    url += "&inputType=link"; // Set input type
    url += "&input=" + encodeURIComponent(templateUrl); // Set input value
    url += "&outputType=link"; // Set output type Link

    // Prepare request
    var httpRequest = new XMLHttpRequest();
    httpRequest.open("GET", url, true);
    // Handle asynchronous response
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState == 4) {
            // If OK, display result
            if (httpRequest.status == 200) {
                var pdfFileLink = httpRequest.responseText;
                document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                var a = document.getElementById("result");
                a.setAttribute("href", pdfFileLink);
                a.innerHTML = pdfFileLink;
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