// (!) If you are getting "(403) Forbidden" error please ensure you have set the correct API_KEY

var https = require("https");
var path = require("path");
var fs = require("fs");


// The authentication key (API Key).
// Get your own by registering at https://secure.bytescout.com/users/sign_up
const API_KEY = "***********************************";


// Result file name
const ResultFileName = "./barcode.png";
// Barcode type. See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeGenerateGet
const BarcodeType = "Code128";
// Barcode value
const BarcodeValue = "qweasd123456";


// Prepare URL for `Barcode Generator` API call
var queryPath = `/v1/barcode/generate?name=${path.basename(ResultFileName)}&type=${BarcodeType}&value=${BarcodeValue}`;
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
            // Get URL of generated barcode image file
            var resultFileUrl = data.url;

            // Download the image file
            var file = fs.createWriteStream(ResultFileName);
            https.get(resultFileUrl, function(response2) {
                response2.pipe(file);
              });

            console.log(`Generated barcode saved to '${ResultFileName}' file.`);
        }
        else {
            console.log(data.message);
        }
    });

}).on("error", function(e) {
    console.error(e);
});
