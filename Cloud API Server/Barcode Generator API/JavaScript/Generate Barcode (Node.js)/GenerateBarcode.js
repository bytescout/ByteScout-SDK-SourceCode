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


// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var https = require("https");
var path = require("path");
var fs = require("fs");

// Result image file name
const DestinationFile = "./barcode.png";
// Barcode type.
const BarcodeType = "Code128";
// Barcode value
const BarcodeValue = "qweasd123456";

// Prepare request to `Barcode Generator` API endpoint
var queryPath = `/barcode/generate?name=${path.basename(DestinationFile)}&type=${BarcodeType}&value=${BarcodeValue}`;
var reqOptions = {
    host: "localhost",
    path: encodeURI(queryPath)
};
// Send request
https.get(reqOptions, (response) => {
    response.on("data", (d) => {
        // Parse JSON response
        var data = JSON.parse(d);
        
        if (data.error == false) {
            // Download the image file
            var file = fs.createWriteStream(DestinationFile);
            https.get(data.url, (response2) => {
                response2.pipe(file).on("close", () => {
                    console.log(`Generated barcode saved to '${DestinationFile}' file.`);
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
