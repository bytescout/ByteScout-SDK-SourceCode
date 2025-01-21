//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var https = require("https");
var path = require("path");
var fs = require("fs");

// `request` module is required for file upload.
// Use "npm install request" command to install.
var request = require("request");

// Direct URL of source PDF file.
const SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf";

// Search string. 
const SearchString = 'Your Company Name';

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

// Prepare URL for PDF text search API call.
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

        // Image params
        const Type = "image";
        const X = 450;
        const Y = +element["top"];
        const Width = 119;
        const Height = 32;
        const ImageUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png";

        // * Add image *
        // Prepare request to `PDF Edit` API endpoint
        var queryPath = `/pdf/edit/add?name=${path.basename(DestinationFile)}&password=${Password}&pages=${Pages}&url=${SourceFileUrl}&type=${Type}&x=${X}&y=${Y}&width=${Width}&height=${Height}&urlimage=${ImageUrl}`;
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
