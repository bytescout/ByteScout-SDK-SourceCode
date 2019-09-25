## How to add text and images to PDF in JavaScript using ByteScout Cloud API Server

### Learn to add text and images to PDF in JavaScript

The sample shows instructions and algorithm of how to add text and images to PDF and how to make it run in your JavaScript application. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data! and you can use it to add text and images to PDF with JavaScript.

Want to save time? You will save a lot of time on writing and testing code as you may just take the JavaScript code from ByteScout Cloud API Server for add text and images to PDF below and use it in your application. Follow the instructions from scratch to work and copy the JavaScript code. Complete and detailed tutorials and documentation are available along with installed ByteScout Cloud API Server if you'd like to learn more about the topic and the details of the API.

Our website gives trial version of ByteScout Cloud API Server for free. It also includes documentation and source code samples.

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

##### ****addTextToPDF.js:**
    
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

    var inputText = $("#inputText").val();
    var fontName = $("#fontName").val();
    var fontSize = $("#fontSize").val();
    var fontColor = $("#fontColor").val();

    var destinationXCoordinate = $("#destinationXCoordinate").val();
    var destinationYCoordinate = $("#destinationYCoordinate").val();

    var formData = $("#SourceFile")[0].files[0]; // file to upload

    $("#status").html('Getting presigned url... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

    // Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
    // If it's not then please replace this with with your hosting url.
    $.ajax({
        url: 'https://localhost/file/upload/get-presigned-url?name=test.pdf&contenttype=application/pdf&encrypt=true',
        type: 'GET',
        success: function (result) {

            if (result['error'] === false) {
                console.log(result);
                var presignedUrl = result['presignedUrl']; // reading provided presigned url to put our content into

                $("#status").html('Uploading... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

                $.ajax({
                    url: presignedUrl, // no api key is required to upload file
                    type: 'PUT',
                    headers: { 'content-type': 'application/pdf' }, // setting to pdf type as we are uploading pdf file
                    data: formData,
                    processData: false,
                    success: function (result) {

                        var cUrl = 'https://localhost/pdf/edit/add?name=result.pdf&type=annotation&x=' + destinationXCoordinate +
                            "&y=" + destinationYCoordinate + "&text=" + inputText + "&fontname="+ fontName +"&size="+ fontSize +"&color=" + fontColor + "&url=" + presignedUrl;

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