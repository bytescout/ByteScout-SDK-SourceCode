## How to PDF text search API in JavaScript and ByteScout Cloud API Server

### This code in JavaScript shows how to PDF text search API with this how to tutorial

These sample source codes on this page below are displaying how to PDF text search API in JavaScript. ByteScout Cloud API Server can PDF text search API. It can be applied from JavaScript. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

Want to save time? You will save a lot of time on writing and testing code as you may just take the JavaScript code from ByteScout Cloud API Server for PDF text search API below and use it in your application. Follow the instructions from scratch to work and copy the JavaScript code. Enjoy writing a code with ready-to-use sample JavaScript codes.

Trial version of ByteScout Cloud API Server is available for free. Source code samples are included to help you with your JavaScript app.

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

##### ****PDFTextSearchFromUploadedFileAsyncAPI.js:**
    
```
/*jshint esversion: 6 */

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var https = require("https");
var path = require("path");
var fs = require("fs");

// `request` module is required for file upload.
// Use "npm install request" command to install.
var request = require("request");
 // Source file name
const SourceFile = "./sample.pdf";

// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
const Pages = "";

// PDF document password. Leave empty for unprotected documents.
const Password = "";

// Search string. 
const SearchString = '[4-9][0-9].[0-9][0-9]'; // Regular expression to find numbers in format dd.dd and between 40.00 to 99.99

// Enable regular expressions (Regex) 
const RegexSearch = 'True';

// 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
getPresignedUrl(SourceFile)
    .then(([uploadUrl, uploadedFileUrl]) => {
        // 2. UPLOAD THE FILE TO CLOUD.
        uploadFile(SourceFile, uploadUrl)
            .then(() => {
                // 3. PDF Text Search FROM UPLOADED FILE
                pdfTextSearch(uploadedFileUrl);
            })
            .catch(e => {
                console.log(e);
            });
    })
    .catch(e => {
        console.log(e);
    });


function getPresignedUrl(localFile) {
    return new Promise(resolve => {
        // Prepare request to `Get Presigned URL` API endpoint
        let queryPath = `/file/upload/get-presigned-url?contenttype=application/octet-stream&name=${path.basename(SourceFile)}`;
        let reqOptions = {
            host: "localhost",
            path: encodeURI(queryPath)
        };
        // Send request
        https.get(reqOptions, (response) => {
            response.on("data", (d) => {
                let data = JSON.parse(d);
                if (data.error == false) {
                    // Return presigned url we received
                    resolve([data.presignedUrl, data.url]);
                }
                else {
                    // Service reported error
                    console.log("getPresignedUrl(): " + data.message);
                }
            });
        })
            .on("error", (e) => {
                // Request error
                console.log("getPresignedUrl(): " + e);
            });
    });
}

function uploadFile(localFile, uploadUrl) {
    return new Promise(resolve => {
        fs.readFile(SourceFile, (err, data) => {
            request({
                method: "PUT",
                url: uploadUrl,
                body: data,
                headers: {
                    "Content-Type": "application/octet-stream"
                }
            }, (err, res, body) => {
                if (!err) {
                    resolve();
                }
                else {
                    console.log("uploadFile() request error: " + e);
                }
            });
        });
    });
}

function pdfTextSearch(uploadedFileUrl) {
    // Prepare URL for PDF text search API call.
    var query = `https://localhost/pdf/find`;
    let reqOptions = {
        uri: query,
        formData: {
            password: Password,
            pages: Pages,
            url: uploadedFileUrl,
            searchString: SearchString,
            regexSearch: RegexSearch,
            async: 'True'
        }
    };

    // Send request
    request.get(reqOptions, function (error, response, body) {
        if (error) {
            return console.error("Error: ", error);
        }

        // Parse JSON response
        let data = JSON.parse(body);
        checkIfJobIsCompleted(data.jobId, data.url);
    });
}


function checkIfJobIsCompleted(jobId, resultFileUrl) {
    let queryPath = `/job/check?jobid=${jobId}`;
    let reqOptions = {
        host: "localhost",
        path: encodeURI(queryPath),
        method: "GET"
    };

    https.get(reqOptions, (response) => {
        response.on("data", (d) => {
            response.setEncoding("utf8");

            // Parse JSON response
            let data = JSON.parse(d);
            console.log(`Checking Job #${jobId}, Status: ${data.status}, Time: ${new Date().toLocaleString()}`);

            if (data.status == "working") {
                // Check again after 3 seconds
                setTimeout(function () { checkIfJobIsCompleted(jobId, resultFileUrl); }, 3000);
            }
            else if (data.status == "success") {
                request({ method: 'GET', uri: resultFileUrl, gzip: true },
                    function (error, response, body) {

                        // Parse JSON response
                        let respJsonFileArray = JSON.parse(body);

                        respJsonFileArray.forEach((element) => {
                            console.log("Found text " + element["text"] + " at coordinates " + element["left"] + ", " + element["top"]);
                        }, this);
                    });
            }
            else {
                console.log(`Operation ended with status: "${data.status}".`);
            }
        })
    });
}
```

<!-- code block end -->