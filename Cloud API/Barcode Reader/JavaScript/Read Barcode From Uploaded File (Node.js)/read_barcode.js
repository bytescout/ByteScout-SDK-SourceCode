// (!) If you are getting "(403) Forbidden" error please ensure you have set the correct API_KEY

var https = require("https");
var path = require("path");
var fs = require("fs");
var url = require("url");

var request = require("request");


// The authentication key (API Key).
// Get your own by registering at https://secure.bytescout.com/users/sign_up
const API_KEY = "***********************************";


// Source file name
const SourceFile = "./sample.pdf";
// Comma-separated list of barcode types to search. 
// See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeReadFromUrlGet
const BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13";
// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
const Pages = "";


// 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
// * If you already have a direct file URL, skip to the step 3.

// Prepare request to `Get Presigned URL` API endpoint
var queryPath = `/v1/file/upload/get-presigned-url?contenttype=binary/octet-stream&name=${path.basename(SourceFile)}`;
var reqOptions = {
    host: "bytescout.io",
    path: encodeURI(queryPath),
    headers: { "x-api-key": API_KEY }
};
// Send request
https.get(reqOptions, function(response) {
    response.on("data", function(d) {
        // Parse JSON response
        var data = JSON.parse(d)
        
        if (data.error == false) {
            // Get URL to use for the file upload
            var uploadUrl = data.presignedUrl;
            // Get URL of uploaded file to use with later API calls
            var uploadedFileUrl = data.url;

            // 2. UPLOAD THE FILE TO CLOUD.

            // Prepare PUT request
            var reqOptions = url.parse(uploadUrl);
            reqOptions["method"] = "PUT"; 
            reqOptions["headers"] = { 
                "x-api-key": API_KEY,
                "content-type": "binary/octet-stream"
            };
            // var reqOptions = {
            //     url: uploadUrl,
            //     headers: { 
            //         "x-api-key": API_KEY,
            //         "content-type": "binary/octet-stream"
            //     }
            // };
            // Send file
            fs.createReadStream(SourceFile).pipe(
                https.request(reqOptions, function(response) {
                //request.put(reqOptions, function(err, res, body) {
                    response.on("data", function(d) {
                    //response.on("end", function() {
                    // if(err) {
                    //     console.log('error', err);
                    // } else {
                        console.log("YES!");
                        console.log(d);
                        var data = JSON.parse(d)
                        console.log(data);
                        // 3. READ BARCODES FROM UPLOADED FILE

                        // Prepare request to `Barcode Reader` API endpoint
                        var queryPath = `/v1/barcode/read/from/url?types=${BarcodeTypes}&pages=${Pages}&url=${uploadedFileUrl}`;
                        var reqOptions = {
                            host: "bytescout.io",
                            path: encodeURI(queryPath),
                            method: "GET",
                            headers: { "x-api-key": API_KEY }
                        };
                        // Send request
                        https.get(reqOptions, function(response) {
                            response.on("data", function(d) {
                                // Parse JSON response
                                var data = JSON.parse(d)
                                
                                if (data.error == false) {
                                    // Display found barcodes in console
                                    data.barcodes.array.forEach(function(element) {
                                        console.log("Found barcode:");
                                        console.log("  Type: " + element["TypeName"]);
                                        console.log("  Value: " + element["Value"]);
                                        console.log("  Document Page Index: " + element["Page"]);
                                        console.log("  Rectangle: " + element["Rect"]);
                                        console.log("  Confidence: " + element["Confidence"]);
                                        console.log();
                                    }, this);
                                }
                                else {
                                    console.log(data.message);
                                }
                            });
                        });
                    });
                })
                // .on("error", function(e) {
                //     console.error(e);
                // })
            );
        }
        else {
            console.log(data.message);
        }
    });
})
.on("error", function(e) {
    console.error(e);
});

/*
// Prepare URL for `Barcode Generator` API call
var queryPath = `/v1/barcode/read/from/url?types=${BarcodeTypes}&pages=${Pages}&url=${SourceFileUrl}`;
var reqOptions = {
    host: "bytescout.io",
    path: encodeURI(queryPath),
    method: "GET",
    headers: {
        "x-api-key": API_KEY
    }
};

https.get(reqOptions, function(response) {

    response.on("data", function(d) {
        // Parse JSON response
        var data = JSON.parse(d)
        
        if (data.error == false) {
            
            // Display found barcodes in console
            data.barcodes.forEach(function(element) {
                console.log("Found barcode:");
                console.log("  Type: " + element.TypeName);
                console.log("  Value: " + element.Value);
                console.log("  Document Page Index: " + element.Page);
                console.log("  Rectangle: " + element.Rect);
                console.log("  Confidence: " + element.Confidence);
                console.log("");
            }, this);
        }
        else {
            console.log(data.message);
        }
    });

}).on("error", function(e) {
    console.error(e);
});
*/