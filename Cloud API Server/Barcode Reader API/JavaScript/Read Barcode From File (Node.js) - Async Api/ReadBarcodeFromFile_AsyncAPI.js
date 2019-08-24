//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
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

// Source file name
const SourceFile = "./sample.pdf";
// Comma-separated list of barcode types to search. 
// barcode types
const BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13";
// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
const Pages = "";

// Prepare request uri for `Barcode Reader` API endpoint
var query = `https://localhost/barcode/read/from/url`;
let reqOptions = {
    uri: query,
    formData: {
        types: BarcodeTypes,
        pages: Pages,
        async: 'True',
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
    console.log(`Job #${data.jobId} has been created!`);
    checkIfJobIsCompleted(data.jobId, data.url);
});


function checkIfJobIsCompleted(jobId, resultFileUrlJson) {
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
				setTimeout(function(){ checkIfJobIsCompleted(jobId, resultFileUrlJson);}, 3000);
            }
            else if (data.status == "success") {

                request({ method: 'GET', uri: resultFileUrlJson, gzip: true },
                function (error, response, body) {

                    // Parse JSON response
                    let respJsonFileArray = JSON.parse(body);

                    respJsonFileArray.forEach((element) => {
                        console.log("Found barcode:");
                        console.log("  Type: " + element["TypeName"]);
                        console.log("  Value: " + element["Value"]);
                        console.log("  Document Page Index: " + element["Page"]);
                        console.log("  Rectangle: " + element["Rect"]);
                        console.log("  Confidence: " + element["Confidence"]);
                        console.log();
                    }, this);
                });
            }
            else {
                console.log(`Operation ended with status: "${data.status}".`);
            }
        })
    });
}
