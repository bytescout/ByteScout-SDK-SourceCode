## How to merge PDF documents from uploaded file (node for PDF merging API in JavaScript with ByteScout Cloud API Server

### Learn to write code merge PDF documents from uploaded file (node for PDF merging API in JavaScript: Simple How To Tutorial

Every ByteScout tool includes sample JavaScript source codes that you can find here or in the folder with installed ByteScout product. PDF merging API in JavaScript can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

Want to learn quickly? These fast application programming interfaces of ByteScout Cloud API Server for JavaScript plus the instruction and the code below will help to learn how to merge PDF documents from uploaded file (node. Open your JavaScript project and simply copy & paste the code and then run your app! Check JavaScript sample code examples to see if they respond to your needs and requirements for the project.

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

##### **app.js:**
    
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

// Source PDF file
const SourceFile1 = "./sample1.pdf";
const SourceFile2 = "./sample2.pdf";

// Destination PDF file name
const DestinationFile = "./result.pdf";

// Upload File-1: - 1. RETRIEVE PRESIGNED URL TO UPLOAD FILE.
getPresignedUrl(SourceFile1)
    .then(([uploadUrl1, uploadedFileUrl1]) => {

        // Upload File-1: - 2. UPLOAD THE FILE TO CLOUD.
        uploadFile(SourceFile1, uploadUrl1)
            .then(() => {

                // Upload File-2: - 1. RETRIEVE PRESIGNED URL TO UPLOAD FILE.
                getPresignedUrl(SourceFile2)
                    .then(([uploadUrl2, uploadedFileUrl2]) => {

                        // Upload File-2: - 2. UPLOAD THE FILE TO CLOUD.
                        uploadFile(SourceFile2, uploadUrl2)
                            .then(() => {

                                const SourceFiles = [
                                    uploadedFileUrl1,
                                    uploadedFileUrl2
                                ];

                                // Perform Merge PDF Documents
                                mergePDFDocuments(SourceFiles, DestinationFile);
                            })
                            .catch(e => {
                                console.log(e);
                            });
                    })
                    .catch(e => {
                        console.log(e);
                    });
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
        let queryPath = `/file/upload/get-presigned-url?contenttype=application/octet-stream&name=${path.basename(localFile)}`;
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

function uploadFile(sourceFile, uploadUrl) {
    return new Promise(resolve => {
        fs.readFile(sourceFile, (err, data) => {
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

function mergePDFDocuments(SourceFiles, DestinationFile) {
    // Prepare request to `Merge PDF` API endpoint
    var queryPath = `/pdf/merge?name=${path.basename(DestinationFile)}&url=${SourceFiles.join(",")}`;
    var reqOptions = {
        host: "localhost",
        path: encodeURI(queryPath)
    };
    // Send request
    https.get(reqOptions, (response) => {
        response.on("data", (d) => {
            // Parse JSON response
            var data = JSON.parse(d);
            if (data.error == false) {
                // Download PDF file
                var file = fs.createWriteStream(DestinationFile);
                https.get(data.url, (response2) => {
                    response2.pipe(file)
                        .on("close", () => {
                            console.log(`Generated PDF file saved as "${DestinationFile}" file.`);
                        });
                });
            }
            else {
                // Service reported error
                console.log(data.message);
            }
        });
    }).on("error", (e) => {
        // Request error
        console.log(e);
    });
}
```

<!-- code block end -->    

<!-- code block begin -->

##### **package.json:**
    
```
{
  "name": "test",
  "version": "1.0.0",
  "description": "PDF.co",
  "main": "app.js",
  "scripts": {
  },
  "keywords": [
    "pdf.co",
    "web",
    "api",
    "bytescout",
    "api"
  ],
  "author": "ByteScout & PDF.co",
  "license": "ISC",
  "dependencies": {
    "request": "^2.88.2"
  }
}

```

<!-- code block end -->