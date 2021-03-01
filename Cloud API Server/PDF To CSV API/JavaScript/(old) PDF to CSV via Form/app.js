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


/*jshint esversion: 6 */

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

// set to the host name for the local server
const ApiServerHost = "localhost";

// uncomment for http:
const ApiServerPort = "8080";
const ApiServerProtocol = "http";

// uncomment for https:
//const ApiServerPort = "443";
//const ApiServerProtocol = "https";


const ApiServerHostWithProtocol = `${ApiServerProtocol}://${ApiServerHost}:${ApiServerPort}`; 

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
// Destination CSV file name
const DestinationFile = "./result.csv";
const IsAsync = 'true';

// Prepare request uri for `PDF To CSV` API call
var query = `${ApiServerHostWithProtocol}/pdf/convert/to/csv`;

let reqOptions = {
    // url to the endpoint
    uri: query,
    // formdata that contains a file and the config
    formData: {
        // reading source file data 
        file: fs.createReadStream(SourceFile),
        // setting all the options in the `data` parameter as json string
        data: `{async: ${IsAsync}, pages: '${Pages}', password: '${Password}' }`
    },
};

// Send request
request.post(reqOptions, function (error, response, body) {
    if (error) {
        return console.error("Error: ", error + body);
    }

    console.log("The response received from API Server was: " + body);


    // Parse JSON response
    let data = JSON.parse(body);
    console.log(`Background Job #${data.jobId} has been created!`);
    checkIfJobIsCompleted(data.jobId, data.url);
});


function checkIfJobIsCompleted(jobId, resultFileUrl) {
    console.log(`Checking the status of the job #${jobId}..`);
    let queryPath = `/job/check?jobid=${jobId}`;
    let reqOptions = {
        host: ApiServerHost,
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
                setTimeout(function(){ checkIfJobIsCompleted(jobId, resultFileUrl); }, 3000);
            }
            else if (data.status == "success") {
                // Download CSV file
                var file = fs.createWriteStream(DestinationFile);
                https.get(resultFileUrl, (response2) => {
                    response2.pipe(file)
                        .on("close", () => {
                            console.log(`Generated CSV file saved as "${DestinationFile}" file.`);
                        });
                });
            }
            else {
                console.log(`Operation ended with status: "${data.status}".`);
            }
        })
    });
}
