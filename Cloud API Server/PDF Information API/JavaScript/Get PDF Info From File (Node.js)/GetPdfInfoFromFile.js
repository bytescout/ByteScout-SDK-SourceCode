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

var fs = require("fs");

// `request` module is required for file upload.
// Use "npm install request" command to install.
var request = require("request");

// Source PDF file to get information
const SourceFile = "./sample.pdf";

// Prepare URL for `PDF Info` API call
var query = `https://localhost/pdf/info`;
let reqOptions = {
    uri: query,
    formData: {
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
         // Display PDF document information
         for (var key in data.info) {  
            console.log(`${key}: ${data.info[key]}`);
        }
    }
    else {
        // Service reported error
        console.log("Error: " + data.message);
    }
});
