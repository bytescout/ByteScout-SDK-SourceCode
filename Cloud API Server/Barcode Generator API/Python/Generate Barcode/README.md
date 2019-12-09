## How to generate barcode for barcode generator API in Python and ByteScout Cloud API Server

### Step-by-step tutorial:How to generate barcode to have barcode generator API in Python

On this page, you will find sample source codes which show you how to handle a complex task, such as, barcode generator API in Python. Barcode generator API in Python can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

If you want to speed up the application’s code writing then Python code samples for Python developers help to implement using ByteScout Cloud API Server. Follow the tutorial and copy - paste code for Python into your project's code editor. Enjoy writing a code with ready-to-use sample Python codes to add barcode generator API functions using ByteScout Cloud API Server in Python.

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

##### **GenerateBarcode.py:**
    
```
import os
import requests # pip install requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# Result file name
ResultFile = ".\\barcode.png"
# Barcode type. See valid barcode types in the documentation https://app.pdf.co/documentation/api/1.0/barcode/generate.html
BarcodeType = "Code128"
# Barcode value
BarcodeValue = "qweasd123456"


def main(args = None):
    generateBarcode(ResultFile)

def generateBarcode(destinationFile):
    """Generates Barcode using PDF.co Web API"""

    # Prepare URL for 'Barcode Generate' API request
    url = "{}/barcode/generate?name={}&type={}&value={}".format(
        BASE_URL,
        os.path.basename(destinationFile),
        BarcodeType,
        BarcodeValue
    )

    # Execute request and get response as JSON
    response = requests.get(url, headers={ "content-type": "application/octet-stream" })
    if (response.status_code == 200):
        json = response.json()

        if json["error"] == False:
            #  Get URL of result file
            resultFileUrl = json["url"]            
            # Download result file
            r = requests.get(resultFileUrl, stream=True)
            if (r.status_code == 200):
                with open(destinationFile, 'wb') as file:
                    for chunk in r:
                        file.write(chunk)
                print(f"Result file saved as \"{destinationFile}\" file.")
            else:
                print(f"Request error: {response.status_code} {response.reason}")
        else:
            # Show service reported error
            print(json["message"])
    else:
        print(f"Request error: {response.status_code} {response.reason}")

if __name__ == '__main__':
    main()
```

<!-- code block end -->