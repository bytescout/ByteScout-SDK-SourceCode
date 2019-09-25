## How to convert PDF to PNG from URL (node for PDF to image API in JavaScript with ByteScout Cloud API Server

### Step-by-step tutorial:How to convert PDF to PNG from URL (node to have PDF to image API in JavaScript

The easy to understand coding guides help you check the features without any need to write your own code. ByteScout Cloud API Server was designed to assist PDF to image API in JavaScript. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

Want to learn quickly? These fast application programming interfaces of ByteScout Cloud API Server for JavaScript plus the instruction and the code below will help to learn how to convert PDF to PNG from URL (node.  This sample code in JavaScript is all you need. Just copy-paste it to the code editor, then add a reference to ByteScout Cloud API Server and you are ready to try it! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

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

##### ****ConvertPdfToPngFromUrl.js:**
    
```
// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var https = require("https");
var fs = require("fs");

// Source PDF file
const SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf";
// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
const Pages = "";
// PDF document password. Leave empty for unprotected documents.
const Password = "";


// Prepare request to `PDF To PNG` API endpoint
var queryPath = `/pdf/convert/to/png?password=${Password}&pages=${Pages}&url=${SourceFileUrl}`;
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
            // Download generated PNG files
            var page = 1;
            data.urls.forEach((url) => {
                var localFileName = `./page${page}.jpg`;
                var file = fs.createWriteStream(localFileName);
                https.get(url, (response2) => {
                    response2.pipe(file)
                    .on("close", () => {
                        console.log(`Generated JPEG file saved as "${localFileName}" file.`);
                    });
                });
                page++;
            }, this);
        }
        else {
            // Service reported error
            console.log(data.message);
        }
    });
}).on("error", (e) => {
    // Request error
    console.error(e);
});

```

<!-- code block end -->