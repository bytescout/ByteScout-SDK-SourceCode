## How to generate barcode (jquery) for barcode generator API in JavaScript using ByteScout Cloud API Server

### How to generate barcode (jquery) in JavaScript with easy ByteScout code samples to make barcode generator API. Step-by-step tutorial

These simple tutorials explain the code material for beginners and advanced programmers who are using JavaScript. ByteScout Cloud API Server helps with barcode generator API in JavaScript. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

Want to learn quickly? These fast application programming interfaces of ByteScout Cloud API Server for JavaScript plus the instruction and the code below will help to learn how to generate barcode (jquery).  This sample code in JavaScript is all you need. Just copy-paste it to the code editor, then add a reference to ByteScout Cloud API Server and you are ready to try it! Further improvement of the code will make it more robust.

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

    $.ajax({
        url: url,
        type: "GET"
    })
    .done (function(data, textStatus, jqXHR) { 
        if (data.error == false) {
            $("#resultBlock").show();
            $("#image").attr("src", data.url);
        }
        else {
            $("#errorBlock").show();
            $("#error").html(data.message);
        }
    })
    .fail (function(jqXHR, textStatus, errorThrown) { 
        $("#errorBlock").show();
        $("#error").html("Request failed. Please check you use the correct API key.");
    });
});

```

<!-- code block end -->