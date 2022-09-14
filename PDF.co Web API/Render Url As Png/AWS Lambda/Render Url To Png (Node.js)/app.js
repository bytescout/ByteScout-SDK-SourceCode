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

// Input url file
const InputUrl = "https://www.wikipedia.org";

// Prepare request to `Urlto Png` API endpoint
var queryPath = `/v1/url/convert/to/png`;

// JSON payload for api request
var jsonPayload = JSON.stringify({
    name: 'result.png', url: InputUrl
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

exports.handler = async (event) => {

    let dataString = '';
    const promise_response = await new Promise((resolve, reject) => {
        
        // Send request
        var postRequest = https.request(reqOptions, (response) => {
            response.on('data', chunk => {
                dataString += chunk;
            });
            
            response.on('end', () => {
                resolve({
                    statusCode: 200,
                    body: JSON.stringify(JSON.parse(dataString), null, 4)
                });
            });
              
        }).on("error", (e) => {
            reject({
                statusCode: 500,
                body: 'Something went wrong!'
            });
        });
        
        // Write request data
        postRequest.write(jsonPayload);
        postRequest.end();
    });

    return promise_response;
};
