## How to add text and images to PDF in JavaScript with ByteScout Cloud API Server

### Step-by-step tutorial on how to add text and images to PDF in JavaScript

Sample source code below will display you how to manage a complex task like add text and images to PDF in JavaScript. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing.. It can add text and images to PDF in JavaScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the JavaScript code from ByteScout Cloud API Server for add text and images to PDF below and use it in your application. Just copy and paste the code into your JavaScript application’s code and follow the instructions. Complete and detailed tutorials and documentation are available along with installed ByteScout Cloud API Server if you'd like to learn more about the topic and the details of the API.

The trial version of ByteScout Cloud API Server can be downloaded for free from our website. It also includes source code samples for JavaScript and other programming languages.

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

##### ****addImageToPDF.js:**
    
```
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

    var signatureImageUrl = $("#signatureImageUrl").val();
    var destinationXCoordinate = $("#destinationXCoordinate").val();
    var destinationYCoordinate = $("#destinationYCoordinate").val();
    var destinationHeight = $("#destinationHeight").val();
    var destinationWidth = $("#destinationWidth").val();

    var formData = $("#SourceFile")[0].files[0]; // file to upload

    $("#status").html('Getting presigned url... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

    $.ajax({
        url: 'https://localhost/file/upload/get-presigned-url?name=test.pdf&contenttype=application/pdf&encrypt=true',
        type: 'GET',
        
        success: function (result) {

            if (result['error'] === false) {
                console.log(result);
                var presignedUrl = result['presignedUrl']; // reading provided presigned url to put our content into

                $("#status").html('Uploading... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

                $.ajax({
                    url: presignedUrl,
                    type: 'PUT',
                    headers: { 'content-type': 'application/pdf' }, // setting to pdf type as we are uploading pdf file
                    data: formData,
                    processData: false,
                    success: function (result) {

                        var cUrl = 'https://localhost/pdf/edit/add?name=result.pdf&type=image&x=' + destinationXCoordinate +
                            "&y=" + destinationYCoordinate + "&width=" + destinationWidth + "&height=" + destinationHeight +
                            "&urlimage=" + signatureImageUrl + "&url=" + presignedUrl;

                        $("#status").html('Processing... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');
                        $.ajax({
                            url: cUrl,
                            type: 'POST',
                            processData: false,
                            contentType: false,
                            //data: oData,
                            success: function (result) {
                                $("#status").text('done processing.');

                                if (result.error) {
                                    $("#errorBlock").show();
                                    $("#errors").text(result.message);
                                } else {
                                    $("#resultBlock").show();
                                    $("#inlineOutput").text(JSON.stringify(result));
                                    $("#iframeResultPdf").prop("src", result.url);
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