## PDF fill PDF forms in cURL and ByteScout Cloud API Server ByteScout Cloud API Server: the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

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

##### **FillPDFForms.cmd:**
    
```
# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

curl --location --request POST 'https://localhost/pdf/edit/add' \
--header 'Content-Type: application/json' \
--header 'x-api-key: {{x-api-key}}' \
--data-raw '{
    "async": false,
    "encrypt": false,
    "name": "f1040-filled",
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-form/f1040.pdf",
    "fields": [
        {
            "fieldName": "topmostSubform[0].Page1[0].FilingStatus[0].c1_01[1]",
            "pages": "1",
            "text": "True"
        },
        {
            "fieldName": "topmostSubform[0].Page1[0].f1_02[0]",
            "pages": "1",
            "text": "John A."
        },        
        {
            "fieldName": "topmostSubform[0].Page1[0].f1_03[0]",
            "pages": "1",
            "text": "Doe"
        },        
        {
            "fieldName": "topmostSubform[0].Page1[0].YourSocial_ReadOrderControl[0].f1_04[0]",
            "pages": "1",
            "text": "123456789"
        },
        {
            "fieldName": "topmostSubform[0].Page1[0].YourSocial_ReadOrderControl[0].f1_05[0]",
            "pages": "1",
            "text": "Joan B."
        },
        {
            "fieldName": "topmostSubform[0].Page1[0].YourSocial_ReadOrderControl[0].f1_05[0]",
            "pages": "1",
            "text": "Joan B."
        },
        {
            "fieldName": "topmostSubform[0].Page1[0].YourSocial_ReadOrderControl[0].f1_06[0]",
            "pages": "1",
            "text": "Doe"
        },
        {
            "fieldName": "topmostSubform[0].Page1[0].YourSocial_ReadOrderControl[0].f1_07[0]",
            "pages": "1",
            "text": "987654321"
        }     



    ],
    "annotations":[
        {
            "text":"Sample Filled with PDF.co API using /pdf/edit/add. Get fields from forms using /pdf/info/fields",
            "x": 10,
            "y": 10,
            "size": 12,
            "pages": "0-",
            "color": "FFCCCC",
            "link": "https://pdf.co"
        }
    ],    
    "images": [        
    ]
}'
```

<!-- code block end -->