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
                var uploadedFileId = httpRequest.responseText;
                convertToHtml(apiKey, uploadedFileId);
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

function convertToHtml(apiKey, uploadedFileId)
{
    var url = "https://bytescout.io/api/v1/pdftohtml/htmlextractor/extract?apiKey=" + apiKey; // Get your API key by registering at http://www.bytescout.io

    var options = {
        "properties": {
            "extractInvisibleText": "false",
            "trimSpaces": "true",
            "outputImageFormat": "png",
            "outputPageWidth": "1200"
        },
        "input": uploadedFileId,
        "inputType": "fileId",
        "outputType": "link"
    };

    // Prepare request
    var httpRequest = new XMLHttpRequest();
    httpRequest.open("POST", url, true);
    httpRequest.setRequestHeader("Content-Type", "application/json");
    // Handle asynchronous response
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState == 4) {
            // If OK
            if (httpRequest.status == 200) {
                var resultFileLink = httpRequest.responseText;
                document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                document.getElementById("result").innerHTML = resultFileLink;
                var a = document.getElementById("result");
                a.setAttribute("href", resultFileLink);
                a.innerHTML = resultFileLink;
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
    httpRequest.send(JSON.stringify(options));
}
