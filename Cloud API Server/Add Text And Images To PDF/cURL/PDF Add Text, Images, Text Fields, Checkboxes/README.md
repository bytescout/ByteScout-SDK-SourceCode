## How to add text and images to PDF in cURL using ByteScout Cloud API Server What is ByteScout Cloud API Server? It is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### **AddImageToPDF.cmd:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/pdf/edit/add' \
--header 'Content-Type: application/json' \
--header 'x-api-key: {{x-api-key}}' \
--data-raw '{
    "async": false,
    "encrypt": true,
    "name": "newDocument",
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf",
    "annotations":[
        {
            "text":"Testing, one, two, three.",
            "x": 10,
            "y": 10,
            "size": 12,
            "pages": "0-"
        },
        {
            "text":"Testing Clickable Links \r\n(CLICK ME!)",
            "x": 200,
            "y": 200,
            "size": 24,
            "pages": "0-",
            "color": "CCBBAA",
            "link": "https://bytescout.com/"
        },
      {
            "text":"Simple text label (default type)",
            "x": 100,
            "y": 100,
            "size": 12,
            "pages": "0-",
            "type": "Text"
        },
       {
            "text":"sample prefilled text",
            "x": 10,
            "y": 30,
            "size": 12,
            "pages": "0-",
            "type": "TextField",
            "id": "textfield1"
        },
              {
            "x": 100,
            "y": 150,
            "size": 12,
            "pages": "0-",
            "type": "Checkbox",
            "id": "checkbox2"
        },
              {
            "x": 100,
            "y": 170,
            "size": 12,
            "pages": "0-",
            "link": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png",
            "type": "CheckboxChecked",
            "id":"checkbox3"
        }          
        
    ],
    
    "images": [
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png",
            "x": 450,
            "y": 10,
            "pages": "0"
        },
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png",
            "x": 450,
            "y": 100,
            "width": 50,
            "height": 50,
            "pages": "0"
        },
        {
            "url": "bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png",
            "x": 200,
            "y": 250,
            "pages": "0",
            "link": "www.pdf.co"
        }
        
    ]
}'
```

<!-- code block end -->