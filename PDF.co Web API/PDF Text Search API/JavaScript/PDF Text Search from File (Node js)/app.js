//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


var fs = require("fs");

// `request` module is required for file upload.
// Use "npm install request" command to install.
var request = require("request");

// The authentication key (API Key).
// Get your own by registering at https://app.pdf.co
const API_KEY = "***********************************";

// Source file name
const SourceFile = "./sample.pdf";

// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
const Pages = "";

// PDF document password. Leave empty for unprotected documents.
const Password = "";

// Search string. 
const SearchString = '[4-9][0-9].[0-9][0-9]'; // Regular expression to find numbers in format dd.dd and between 40.00 to 99.99

// Enable regular expressions (Regex) 
const RegexSearch = 'True';

// Prepare URL for PDF text search API call.
// See documentation: https://apidocs.pdf.co
var query = `https://api.pdf.co/v1/pdf/find`;
let reqOptions = {
    uri: query,
    headers: { "x-api-key": API_KEY },
    formData: {
        password: Password,
        pages: Pages,
        searchString: SearchString,
        regexSearch: RegexSearch,
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
    for (let index = 0; index < data.body.length; index++) {
        const element = data.body[index];
        console.log("Found text " + element["text"] + " at coordinates " + element["left"] + ", " + element["top"]);
    }
});
