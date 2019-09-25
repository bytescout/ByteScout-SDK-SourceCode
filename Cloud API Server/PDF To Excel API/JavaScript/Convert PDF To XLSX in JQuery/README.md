## How to convert PDF to XLSX in jquery for PDF to excel API in JavaScript using ByteScout Cloud API Server

### Follow this simple tutorial to learn convert PDF to XLSX in jquery to have PDF to excel API in JavaScript

Quick guide:Learn how to convert PDF to XLSX in jquery in JavaScript. ByteScout Cloud API Server was designed to assist PDF to excel API in JavaScript. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

This simple and easy to understand sample source code in JavaScript for ByteScout Cloud API Server contains different functions and options you should do calling the API to implement PDF to excel API.  This sample code in JavaScript is all you need. Just copy-paste it to the code editor, then add a reference to ByteScout Cloud API Server and you are ready to try it! You can use these JavaScript sample examples in one or many applications.

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
 
    var formData = $("#form input[type=file]")[0].files[0]; // file to upload
    var toType = $("#convertType").val(); // output type
    var isInline = $("#outputType").val() == "inline"; // if we need output as inline content or link to output file

    $("#status").html('Requesting presigned url for upload... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

    $.ajax({
        url: 'https://localhost/file/upload/get-presigned-url?name=test.pdf&contenttype=application/pdf&encrypt=true',
        type: 'GET',
        success: function (result) {    

            if (result['error'] === false) {
                var presignedUrl = result['presignedUrl']; // reading provided presigned url to put our content into
                var accessUrl = result['url']; // reading output url that will indicate uploaded file

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
                            url: 'https://localhost/pdf/convert/to/'+toType+'?url='+ presignedUrl + '&encrypt=true&inline=' + isInline,
                            type: 'POST', 
                            success: function (result) { 

                                $("#status").text('done converting.');

                                // console.log(JSON.stringify(result));
                                
                                $("#resultBlock").show();

                                if (isInline)
                                {                                    
                                    $("#inlineOutput").text(result['body']);
                                }
                                else {
                                    $("#result").attr("href", result['url']).html(result['url']);
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
 

```

<!-- code block end -->