## email extractor in Python with PDF.co Web API PDF.co Web API is the Rest API that provides set of data extraction functions, tools for documents manipulation, splitting and merging of pdf files. Includes built-in OCR, images recognition, can generate and read barcodes from images, scans and pdf.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=PDF.co%20Web%20API%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=PDF.co%20Web%20API%20Question) 

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

##### **EmailToPDF.py:**
    
```
import requests

url = "https://api.pdf.co/v1/pdf/convert/from/email"

payload={'url': 'https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/email-to-pdf/sample.eml',
'embedAttachments': 'true',
'convertAttachments': 'true',
'paperSize': 'Letter',
'name': 'email-with-attachments',
'async': 'false'}
files=[

]
headers = {
		'Content-Type': 'application/json',
		'x-api-key': '{{x-api-key}}'
}

response = requests.request("POST", url, headers=headers, json=payload, files=files)

print(response.text)

```

<!-- code block end -->