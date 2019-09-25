## How to convert PDF to HTML in jquery async API for PDF to HTML API in JavaScript with ByteScout Cloud API Server

### Learn in simple ways: How to convert PDF to HTML in jquery async API for PDF to HTML API in JavaScript

On this page, you will find sample source codes which show you how to handle a complex task, such as, PDF to HTML API in JavaScript. PDF to HTML API in JavaScript can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

If you want to speed up the application’s code writing then JavaScript code samples for JavaScript developers help to implement using ByteScout Cloud API Server. Follow the tutorial and copy - paste code for JavaScript into your project's code editor. Check JavaScript sample code examples to see if they respond to your needs and requirements for the project.

Trial version of ByteScout is available for free download from our website. This and other source code samples for JavaScript and other programming languages are available.

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

##### ****converter.js:**
    
```
// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var formData, toType, isInline;

$(document).ready(function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
    $("#result").attr("href", '').html('');
});
 
$(document).on("click", "#submit", function () {
    $("#resultBlock").hide();
    $("#errorBlock").hide();
    $("#inlineOutput").text(''); // inline output div
    $("#status").text(''); // status div
 
    formData = $("#form input[type=file]")[0].files[0]; // file to upload
    toType = $("#convertType").val(); // output type
    isInline = $("#outputType").val() == "inline"; // if we need output as inline content or link to output file

    $("#status").html('Requesting presigned url for upload... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

    $.ajax({
        url: 'https://localhost/file/upload/get-presigned-url?name=test.pdf&contenttype=application/pdf&encrypt=true',
        type: 'GET',
        success: function (result) {    

            if (result['error'] === false) {

                var presignedUrl = result['presignedUrl']; // reading provided presigned url to put our content into
                $("#status").html('Uploading... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

                $.ajax({
                    url: presignedUrl, // no api key is required to upload file
                    type: 'PUT',
                    headers: {'content-type': 'application/pdf'}, // setting to pdf type as we are uploading pdf file
                    data: formData,
                    processData: false,
                    success: function (result) {                               
                        
                        $("#status").html('Processing... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

                        $.ajax({
                            url: 'https://localhost/pdf/convert/to/'+toType+'?url='+ presignedUrl + '&encrypt=true&inline=' + isInline + '&async=True',
                            type: 'POST',
                            success: function (result) { 
                                if (result.error) {
                                    $("#status").text('Error uploading file.');
                                }
                                else {
                                    checkIfJobIsCompleted(result.jobId, result.url);
                                }
                            }
                        });
                    },
                    error: function () {
                        $("#status").text('error');
                    }
                  });                

                }
            }
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
                setTimeout(checkIfJobIsCompleted(jobId, resultFileUrl), 3000)
            }
            else if (jobResult.status == "success") {

                $("#status").text('Done converting.');

                $("#resultBlock").show();

                if (isInline && toType != "xls" && toType != "xlsx") {
                    $.ajax({
                        url: resultFileUrl,
                        dataType: 'text',
                        success: function (respText) {
                            $("#inlineOutput").text(respText);
                        }
                    });
                }
                else {
                    $("#result").attr("href", resultFileUrl).html(resultFileUrl);
                }
            }
        }
    });
}

```

<!-- code block end -->