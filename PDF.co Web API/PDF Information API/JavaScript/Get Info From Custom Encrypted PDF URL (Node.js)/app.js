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


var https = require("https");

// The authentication key (API Key).
// Get your own by registering at https://app.pdf.co
const API_KEY = "***********************************";

// Direct URL of PDF file to get information
// You can also upload your own file into PDF.co and use it as url. Check "Upload File" samples for code snippets: https://github.com/bytescout/pdf-co-api-samples/tree/master/File%20Upload/    
const SourceFileUrl = "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/encryption/sample_encrypted_aes128.pdf";

// Refer to documentations for more info. https://apidocs.pdf.co/32-1-user-controlled-data-encryption-and-decryption
const Profiles = "{ 'DataDecryptionAlgorithm': 'AES128', 'DataDecryptionKey': 'HelloThisKey1234', 'DataDecryptionIV': 'TreloThisKey1234' }";

// Prepare request to `PDF Info` API endpoint
var queryPath = `/v1/pdf/info`;

// JSON payload for api request
var jsonPayload = JSON.stringify({
    url: SourceFileUrl,
    profiles: Profiles
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
            // Display PDF document information
            for (var key in data.info) {
                console.log(`${key}: ${data.info[key]}`);
            }
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

// Write request data
postRequest.write(jsonPayload);
postRequest.end();
