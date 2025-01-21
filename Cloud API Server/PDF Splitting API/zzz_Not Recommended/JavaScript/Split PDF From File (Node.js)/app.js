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
var path = require("path");
var fs = require("fs");

// `request` module is required for file upload.
// Use "npm install request" command to install.
var request = require("request");

// Source PDF file to split
const SourceFile = "./sample.pdf";
// Comma-separated list of page numbers (or ranges) to process. Example: '1,3-5,7-'.
const Pages = "1-2,3-";

// Prepare URL for `Split PDF` API endpoint
var query = `https://localhost/pdf/split`;
let reqOptions = {
    uri: query,
    formData: {
        pages: Pages,
        file: fs.createReadStream(SourceFile)
    }
};

// Send request
request.post(reqOptions, function (error, response, body) {
    if (error) {
        return console.error("Error: ", error);
    }

    // Parse JSON response
    let data = JSON.parse(body);
    if (data.error == false) {
        // Download generated PDF files
        var part = 1;
        data.urls.forEach((url) => {
            var localFileName = `./part${part}.pdf`;
            var file = fs.createWriteStream(localFileName);
            https.get(url, (response2) => {
                response2.pipe(file)
                    .on("close", () => {
                        console.log(`Generated PDF file saved as "${localFileName}" file.`);
                    });
            });
            part++;
        }, this);
    }
    else {
        // Service reported error
        console.log("Error: " + data.message);
    }
});
