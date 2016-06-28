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
    var pageIndex = document.getElementById("pageIndex").value;

    var httpRequest = new XMLHttpRequest();
    httpRequest.open("POST", url, true);

    // Handle asynchronous response
    httpRequest.onreadystatechange = function () {
        if (httpRequest.readyState == 4) {
            // If OK
            if (httpRequest.status == 200) {
                var uploadedFileId = httpRequest.responseText;
                switch(document.getElementById("extractionType").value) {
                    case "0":
                        ExtractText(apiKey, uploadedFileId, pageIndex);
                        break;
                    case "1":
                        ExtractCSV(apiKey, uploadedFileId, pageIndex);
                        break;
                    case "2":
                        ExtractXLS(apiKey, uploadedFileId, pageIndex);
                        break;
                    case "3":
                        ExtractXML(apiKey, uploadedFileId, pageIndex);
                        break;
                    case "4":
                        ExtractJSON(apiKey, uploadedFileId, pageIndex);
                        break;
                    case "5":
                        ExtractInfo(apiKey, uploadedFileId);
                        break;
                }
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

function ExtractText(apiKey, uploadedFileId, pageIndex)
{
    var url = "https://bytescout.io/api/v1/pdfextractor/textextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": pageIndex,
            "endPageIndex": pageIndex,
            "extractInvisibleText": "false"
        },
        "input": uploadedFileId,
        "inputType": "fileId"
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
    httpRequest.send(JSON.stringify(options));
}

function ExtractCSV(apiKey, uploadedFileId, pageIndex)
{
    var url = "https://bytescout.io/api/v1/pdfextractor/csvextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": pageIndex,
            "endPageIndex": pageIndex,
            "extractInvisibleText": "false"
        },
        "input": uploadedFileId,
        "inputType": "fileId"
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
    httpRequest.send(JSON.stringify(options));
}

function ExtractXLS(apiKey, uploadedFileId, pageIndex)
{
    var url = "https://bytescout.io/api/v1/pdfextractor/xlsextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": pageIndex,
            "endPageIndex": pageIndex,
            "extractInvisibleText": "false",
            "outputFormat": "xlsx"
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
                document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                document.getElementById("result").innerHTML = 
                    "<div><a href='" + httpRequest.responseText + "' target='_blank'>" + httpRequest.responseText + "</a></div>";
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

function ExtractXML(apiKey, uploadedFileId, pageIndex)
{
    var url = "https://bytescout.io/api/v1/pdfextractor/xmlextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": pageIndex,
            "endPageIndex": pageIndex,
            "extractInvisibleText": "false"
        },
        "input": uploadedFileId,
        "inputType": "fileId"
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
                document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                document.getElementById("result").innerText = httpRequest.responseText;
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

function ExtractJSON(apiKey, uploadedFileId, pageIndex)
{
    var url = "https://bytescout.io/api/v1/pdfextractor/jsonextractor/extract?apiKey=" + apiKey;

    var options = {
        "properties": {
            "startPageIndex": pageIndex,
            "endPageIndex": pageIndex,
            "extractInvisibleText": "false"
        },
        "input": uploadedFileId,
        "inputType": "fileId"
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
                document.getElementById("resultBlock").style.display = "block"; // show hidden resultBlock
                document.getElementById("result").innerText = httpRequest.responseText;
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

function ExtractInfo(apiKey, uploadedFileId)
{
    var url = "https://bytescout.io/api/v1/pdfextractor/infoextractor/extract?apiKey=" + apiKey;

    var options = {
        "input": uploadedFileId,
        "inputType": "fileId"
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
    httpRequest.send(JSON.stringify(options));
}
