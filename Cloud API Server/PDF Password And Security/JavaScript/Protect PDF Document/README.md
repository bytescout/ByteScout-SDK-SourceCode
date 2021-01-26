## PDF password and security in JavaScript and ByteScout Cloud API Server ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### **app.js:**
    
```
// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var https = require("https");
var path = require("path");
var fs = require("fs");

// The authentication key (API Key).
// Get your own by registering at https://app.pdf.co/documentation/api
const API_KEY = "***********************************";


// Direct URL of source PDF file.
const SourceFileUrl = "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample1.pdf";

// Destination PDF file name
const DestinationFile = "./protected.pdf";

// Passwords to protect PDF document
// The owner password will be required for document modification.
// The user password only allows to view and print the document.
const OwnerPassword = "123456";
const UserPassword = "654321";

// Encryption algorithm. 
// Valid values: "RC4_40bit", "RC4_128bit", "AES_128bit", "AES_256bit".
const EncryptionAlgorithm = "AES_128bit";

// Allow or prohibit content extraction for accessibility needs.
const AllowAccessibilitySupport = true;

// Allow or prohibit assembling the document.
const AllowAssemblyDocument = true;

// Allow or prohibit printing PDF document.
const AllowPrintDocument = true;

// Allow or prohibit filling of interactive form fields (including signature fields) in PDF document.
const AllowFillForms = true;

// Allow or prohibit modification of PDF document.
const AllowModifyDocument = true;

// Allow or prohibit copying content from PDF document.
const AllowContentExtraction = true;

// Allow or prohibit interacting with text annotations and forms in PDF document.
const AllowModifyAnnotations = true;

// Allowed printing quality.
// Valid values: "HighResolution", "LowResolution"
const PrintQuality = "HighResolution";

// Runs processing asynchronously. 
// Returns Use JobId that you may use with /job/check to check state of the processing (possible states: working, failed, aborted and success).
const async = false;


// Prepare request to `PDF Security` API endpoint
var queryPath = `/v1/pdf/security/add`;

// JSON payload for api request
var jsonPayload = JSON.stringify({
    name: path.basename(DestinationFile),
    url: SourceFileUrl,
    ownerPassword: OwnerPassword,
    userPassword: UserPassword,
    encryptionAlgorithm: EncryptionAlgorithm,
    allowAccessibilitySupport: AllowAccessibilitySupport,
    allowAssemblyDocument: AllowAssemblyDocument,
    allowPrintDocument: AllowPrintDocument,
    allowFillForms: AllowFillForms,
    allowModifyDocument: AllowModifyDocument,
    allowContentExtraction: AllowContentExtraction,
    allowModifyAnnotations: AllowModifyAnnotations,
    printQuality: PrintQuality,
    async: async
});

var reqOptions = {
    host: "api.pdf.co",
    method: "POST",
    path: queryPath,
    headers: {
        "x-api-key": API_KEY,
        "Content-Type": "application/json",
        "Content-Length": Buffer.byteLength(jsonPayload, 'utf8')
    }
};
// Send request
var postRequest = https.request(reqOptions, (response) => {
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

// Write request data
postRequest.write(jsonPayload);
postRequest.end();
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