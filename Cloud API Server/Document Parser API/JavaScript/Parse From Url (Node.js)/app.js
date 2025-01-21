//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


/*jshint esversion: 6 */

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var https = require("https");
var fs = require("fs");

// `request` module is required for file upload.
// Use "npm install request" command to install.
var request = require("request");

// Source PDF file
const SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf";

// Destination PDF file name
const DestinationFile = "./result.json";

// Template text. Use Document Parser (https://pdf.co/document-parser, https://app.pdf.co/document-parser)
// to create templates.
// Read template from file:
var templateText = fs.readFileSync("./MultiPageTable-template1.yml", "utf-8");

// URL for `Document Parser` API call
var query = `https://localhost/pdf/documentparser`;
var jsonRequestObject = {
    url: SourceFileUrl,
    template: templateText
};

request(
    {
        url: query,
        method: "POST",
        json: true,
        body: jsonRequestObject
    },
    function (error, response, body) {

        if (error) {
            return console.error("Error: ", error);
        }

        // Parse JSON response
        let data = JSON.parse(JSON.stringify(body));

        if (data.error == false) {
            //Download generated file
            var file = fs.createWriteStream(DestinationFile);
            https.get(data.url, (response2) => {
                response2.pipe(file)
                    .on("close", () => {
                        console.log(`Generated result file saved as "${DestinationFile}" file.`);
                    });
            });
        }
        else {
            // Service reported error
            console.log("Error: " + data.message);
        }
    }
);
