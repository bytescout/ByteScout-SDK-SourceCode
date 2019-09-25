## How to generate barcode (jquery) async API for barcode generator API in JavaScript and ByteScout Cloud API Server

### How to generate barcode (jquery) async API for barcode generator API in JavaScript: Step By Step Instructions

If you want a quick and easy way to add a required functionality into your application then check this sample source code documentation. ByteScout Cloud API Server was designed to assist barcode generator API in JavaScript. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

This simple and easy to understand sample source code in JavaScript for ByteScout Cloud API Server contains different functions and options you should do calling the API to implement barcode generator API. This JavaScript sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. Use of ByteScout Cloud API Server in JavaScript is also described in the documentation given along with the product.

Our website provides free trial version of ByteScout Cloud API Server that gives source code samples to assist with your JavaScript project.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****generate_barcode.js:**
    
```
// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

$(document).ready(function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
});

$(document).on("click", "#submit", function () {

    var url = "https://localhost/barcode/generate?name=barcode.png";
    url += "&type=" + $("#barcodeType").val(); // Set barcode type (symbology)
    url += "&value=" + $("#inputValue").val(); // Set barcode value
    url += "&async=True"; // Set async

    // Show loader
    $("#loader").show();

    $.ajax({
        url: url,
        type: "GET"
    })
        .done(function (data, textStatus, jqXHR) {

            if (data.error) {
                $("#errorBlock").show();
                $("#error").html(data.message);
                $("#loader").hide();
            }
            else {
                checkIfJobIsCompleted(data.jobId, data.url);
            }
        })
        .fail(function (jqXHR, textStatus, errorThrown) {
            $("#errorBlock").show();
            $("#error").html("Request failed. Please check you use the correct API key.");
            $("#loader").hide();
        });
});

function checkIfJobIsCompleted(jobId, resultFileUrl) {
    $.ajax({
        url: 'https://localhost/job/check?jobid=' + jobId,
        type: 'GET',
        success: function (jobResult) {

            $("#status").html(jobResult.status + ' &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

            if (jobResult.status == "working") {
                // Check again after 3 seconds
                setTimeout(function(){
                    checkIfJobIsCompleted(jobId, resultFileUrl);
                }, 3000);
            }
            else if (jobResult.status == "success") {
                $("#resultBlock").show();
                $("#image").attr("src", resultFileUrl);
            }

            $("#loader").hide();
        },
        error: function(){
            $("#errorBlock").show();
            $("#error").html("Request failed. Please check you use the correct API key.");
            $("#loader").hide();
        }
    });
}
```

<!-- code block end -->