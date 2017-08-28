// (!) If you are getting "(403) Forbidden" error please ensure you have set the correct API_KEY

var https = require("https");
var path = require("path");
var fs = require("fs");


// The authentication key (API Key).
// Get your own by registering at https://secure.bytescout.com/users/sign_up
const API_KEY = "***********************************";


// Direct URL of source file to search barcodes in.
const SourceFileUrl = "https://github.com/bytescout/ByteScout-SDK-SourceCode/raw/master/BarCode%20Reader%20SDK/C%23/Export%20Results%20to%20XML%2C%20CSV%2C%20TXT/barcodes.pdf"
// Comma-separated list of barcode types to search. 
// See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeReadFromUrlGet
const BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13";
// Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
const Pages = "";


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
    console.log("statusCode:", response.statusCode);
    console.log("statusMessage:", response.statusMessage);

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
