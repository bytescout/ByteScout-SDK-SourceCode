## How to add text and images to PDF in JavaScript using ByteScout Cloud API Server

### Learn to code in JavaScript to add text and images to PDF with this step-by-step tutorial

This sample source code below will display you how to add text and images to PDF in JavaScript. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing.. It can add text and images to PDF in JavaScript.

The following code snippet for ByteScout Cloud API Server works best when you need to quickly add text and images to PDF in your JavaScript application.  Simply copy and paste in your JavaScript project or application you and then run your app! Enjoy writing a code with ready-to-use sample JavaScript codes.

The trial version of ByteScout Cloud API Server can be downloaded for free from our website. It also includes source code samples for JavaScript and other programming languages.

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

##### ****AddTextByFindingTargetCoordinates.js:**
    
```
var https = require("https");
var path = require("path");
var fs = require("fs");

// `request` module is required for file upload.
// Use "npm install request" command to install.
var request = require("request");

// Direct URL of source PDF file.
const SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf";

// Search string. 
const SearchString = 'Notes';

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.
var queryFindText = `https://localhost/pdf/find`;
let reqOptionsFindText = {
    uri: queryFindText,
    formData: {
        url: SourceFileUrl,
        searchString: SearchString
    }
};

// Send request
request.get(reqOptionsFindText, function (error, responseFindText, bodyFindText) {
    if (error) {
        return console.error("Error: ", error);
    }

    // Parse JSON response
    let dataFindText = JSON.parse(bodyFindText);
    if (dataFindText.body.length > 0) {
        var element = dataFindText.body[0];
        console.log("Found text " + element["text"] + " at coordinates " + element["left"] + ", " + element["top"]);

        // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
        const Pages = "";

        // PDF document password. Leave empty for unprotected documents.
        const Password = "";

        // Destination PDF file name
        const DestinationFile = "./result.pdf";

        // Text annotation params
        const Type = "annotation";
        const X = +element["left"];
        const Y = +element["top"] + 25;
        const Text = "Some notes will go here... Some notes will go here.... Some notes will go here.....";
        const FontName = "Times New Roman";
        const FontSize = 12;
        const Color = "FF0000";

        // * Add Text *
        // Prepare request to `PDF Edit` API endpoint
        var queryPath = `/pdf/edit/add?name=${path.basename(DestinationFile)}&password=${Password}&pages=${Pages}&url=${SourceFileUrl}&type=${Type}&x=${X}&y=${Y}&text=${Text}&fontname=${FontName}&size=${FontSize}&color=${Color}`;
        var reqOptions = {
            host: "localhost",
            path: encodeURI(queryPath),
            
        };
        // Send request
        https.get(reqOptions, (response) => {
            response.on("data", (d) => {
                // Parse JSON response
                var data = JSON.parse(d);

                if (data.error == false) {
                    // Download the PDF file
                    var file = fs.createWriteStream(DestinationFile);
                    https.get(data.url, (response2) => {
                        response2.pipe(file).on("close", () => {
                            console.log(`Generated PDF file saved to '${DestinationFile}' file.`);
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
            console.error(e);
        });

    } else {
        console.error("No result found.");
    }
});
```

<!-- code block end -->