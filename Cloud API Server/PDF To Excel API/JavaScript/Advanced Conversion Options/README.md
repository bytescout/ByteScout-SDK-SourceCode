## PDF to excel API in JavaScript and ByteScout Cloud API Server

### How to apply ByteScout Cloud API Server for PDF to excel API in JavaScript

An easy to understand guide to learn how to PDF to excel API in JavaScript. ByteScout Cloud API Server was made to help with PDF to excel API in JavaScript. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

If you want to quickly learn then these fast application programming interfaces of ByteScout Cloud API Server for JavaScript plus the guideline and the JavaScript code below will help you quickly learn PDF to excel API.  Just copy and paste this JavaScript sample code to your JavaScript application's code editor, add a reference to ByteScout Cloud API Server (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample JavaScript codes to implement PDF to excel API using ByteScout Cloud API Server.

Our website gives free trial version of ByteScout Cloud API Server. It includes all these source code samples with the purpose to assist you with your JavaScript application implementation.

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

##### ****ConvertPdfToXlsFromUrl.js:**
    
```
// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var https = require("https");
var path = require("path");
var fs = require("fs");

// Direct URL of source PDF file.
const SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-excel/sample.pdf";
// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
const Pages = "";
// PDF document password. Leave empty for unprotected documents.
const Password = "";
// Destination XLS file name
const DestinationFile = "./result.xls";

// Sample profile that sets advanced conversion options.
// Advanced options are properties of XLSExtractor class from ByteScout PDF Extractor SDK used in the back-end:
// https://cdn.bytescout.com/help/BytescoutPDFExtractorSDK/html/2712c05b-9674-5253-df76-2a31ed055afd.htm
const Profiles = '{ "profiles": [ { "profile1": { "RichTextFormatting": false, "PageToWorksheet": false } } ] }';

// Prepare request to `PDF To XLS` API endpoint
var queryPath = `/pdf/convert/to/xls?name=${path.basename(DestinationFile)}&password=${Password}&pages=${Pages}&url=${SourceFileUrl}&profiles=${Profiles}&async=True`;
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
            console.log(`Job #${data.jobId} has been created!`);
            checkIfJobIsCompleted(data.jobId, data.url);
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
                // Download XLS file
                var file = fs.createWriteStream(DestinationFile);
                https.get(resultFileUrl, (response2) => {
                    response2.pipe(file)
                        .on("close", () => {
                            console.log(`Generated XLS file saved as "${DestinationFile}" file.`);
                        });
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