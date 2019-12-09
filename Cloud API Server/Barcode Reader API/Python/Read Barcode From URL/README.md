## How to read barcode from URL for barcode reader API in Python using ByteScout Cloud API Server

### Step-by-step tutorial:How to read barcode from URL to have barcode reader API in Python

On this page, you will find sample source codes which show you how to handle a complex task, such as, barcode reader API in Python. ByteScout Cloud API Server was designed to assist barcode reader API in Python. ByteScout Cloud API Server is the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

The SDK samples displayed below below explain how to quickly make your application do barcode reader API in Python with the help of ByteScout Cloud API Server. This Python sample code can be used by copying and pasting into your project. Once done,just compile your project and click Run. Further improvement of the code will make it more robust.

ByteScout Cloud API Server - free trial version is available on our website. Also, there are other code samples to help you with your Python application included into trial version.

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

##### **ReadBarcodeFromUrl.py:**
    
```
import os
import requests  # pip install requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# Direct URL of source file to search barcodes in.
SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf"

# Comma-separated list of barcode types to search.
# See valid barcode types in the documentation https://app.pdf.co/documentation/api/1.0/barcode/read_from_url.html
BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13"

# Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
Pages = ""


def main(args=None):
    readBarcodes(SourceFileURL)

def readBarcodes(uploadedFileUrl):
    """Get Barcode Information using PDF.co Web API"""

    # Prepare URL for 'Barcode Reader' API request
    url = "{}/barcode/read/from/url?types={}&pages={}&url={}".format(
        BASE_URL,
        BarcodeTypes,
        Pages,
        uploadedFileUrl
    )

    # Execute request and get response as JSON
    response = requests.get(url, headers={ "content-type": "application/octet-stream"})
    if (response.status_code == 200):
        json = response.json()

        if json["error"] == False:
            # Display information
            for barcode in json["barcodes"]:
                print("Found barcode:")
                print(f"  Type: {barcode['TypeName']}")
                print(f"  Value: {barcode['Value']}")
                print(f"  Document Page Index: {barcode['Page']}")
                print(f"  Rectangle: {barcode['Rect']}")
                print(f"  Confidence: {barcode['Confidence']}")
                print("")
        else:
            # Show service reported error
            print(json["message"])
    else:
        print(f"Request error: {response.status_code} {response.reason}")


if __name__ == '__main__':
    main()
```

<!-- code block end -->