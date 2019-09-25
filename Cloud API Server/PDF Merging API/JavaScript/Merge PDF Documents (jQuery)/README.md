## How to merge PDF documents (jquery) for PDF merging API in JavaScript and ByteScout Cloud API Server

### Step-by-step tutorial:How to merge PDF documents (jquery) to have PDF merging API in JavaScript

If you want a quick and easy way to add a required functionality into your application then check this sample source code documentation. ByteScout Cloud API Server was designed to assist PDF merging API in JavaScript. ByteScout Cloud API Server is the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

This simple and easy to understand sample source code in JavaScript for ByteScout Cloud API Server contains different functions and options you should do calling the API to implement PDF merging API. For implementation of this functionality, please copy and paste the code below into your app using code editor. Then compile and run your app. Use of ByteScout Cloud API Server in JavaScript is also described in the documentation given along with the product.

Free! Free! Free! ByteScout free trial version is available for FREE download from our website. Programming tutorials along with source code samples are assembled.

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

##### ****merge.js:**
    
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

    var formData = new FormData();
    formData.append('name', 'result.pdf');
    
    // Append files in input request
    formData.append('file[]', $("#form input[type=file]")[0].files[0]);
    formData.append('file[]', $("#form input[type=file]")[1].files[0]);

    $("#status").html('Processing... &nbsp;&nbsp;&nbsp; <img src="ajax-loader.gif" />');

    $.ajax({
        url: 'https://localhost/pdf/merge',
        type: 'POST',
        
        data: formData,
        contentType: false, // NEEDED, DON'T OMIT THIS (requires jQuery 1.6+)
        processData: false, // NEEDED, DON'T OMIT THIS
        success: function (result) {
            $("#status").text('Success!');

            $("#resultBlock").show();
            $("#inlineOutput").html('<iframe style="width:100%; height:500px;" src="'+ result.url +'" />');
        },
        error: function () {
            $("#status").text('error');
        }
    });
 });
```

<!-- code block end -->