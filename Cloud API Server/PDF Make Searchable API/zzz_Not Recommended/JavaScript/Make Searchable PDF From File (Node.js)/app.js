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

// Source PDF file
const SourceFile = "./sample.pdf";
// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
const Pages = "";
// PDF document password. Leave empty for unprotected documents.
const Password = "";
// OCR language. "eng", "fra", "deu", "spa"  supported currently. Let us know if you need more.
const Language = "eng";
// Destination PDF file name
const DestinationFile = "./result.pdf";


// Prepare URL for `Make Searchable PDF` API endpoint
var query = `https://localhost/pdf/makesearchable`;
let reqOptions = {
    uri: query,
    formData: {
        name: path.basename(DestinationFile),
        password: Password,
        pages: Pages,
        lang: Language,
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
        console.log("Error: " + data.message);
    }
});
