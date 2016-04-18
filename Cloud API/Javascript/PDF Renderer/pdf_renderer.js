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
                RenderPDF(apiKey, uploadedFileId);
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


function RenderPDF(apiKey, uploadedFileId)
{
    var url = "https://bytescout.io/api/v1/pdfrenderer/render?apiKey=" + apiKey;

    var pageIndex = document.getElementById("pageIndex").value;
    var resolution = document.getElementById("resolution").value;
    var rasterOutputFormat = document.getElementById("rasterOutputFormat").value;

    var options = {
        "properties": {
            "pageIndex": pageIndex,
            "resolution": resolution,
            "jpegQuality": 85,
            "rasterOutputFormat": rasterOutputFormat
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
    httpRequest.send(JSON.stringify(options));
}
