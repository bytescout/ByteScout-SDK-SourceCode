## How to add text and images to PDF in Python and ByteScout Cloud API Server

### Step-by-step tutorial on how to add text and images to PDF in Python

Add text and images to PDF is simple to apply in Python if you use these source codes below. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing.. It can be applied to add text and images to PDF using Python.

The following code snippet for ByteScout Cloud API Server works best when you need to quickly add text and images to PDF in your Python application. This Python sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Applying Python application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### **AddImageByFindingTargetCoordinates.py:**
    
```
import os
import requests # pip install requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# Direct URL of source PDF file.
SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf"

# Search string.
SearchString = 'Your Company Name'

# Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
Pages = ""

# PDF document password. Leave empty for unprotected documents.
Password = ""

# Destination PDF file name
DestinationFile = ".//result.pdf"

# Image params
Type = "image"
Width = 119
Height = 32
ImageUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png"


def main(args = None):
    # First of all try to find Text within input PDF file
    res = findTextWithinPDF(SourceFileUrl, SearchString)

    if res:
        addImageToPDF(DestinationFile, res['top'], res['left'])
    else:
        print("No result found!")


def findTextWithinPDF(sourceFile, searchText):
    # Prepare URL for PDF text search API call
    # See documentation: https://app.pdf.co/documentation/api/1.0/pdf/find.html

    retVal = dict()

    url = "{}/pdf/find?url={}&searchString={}".format(
        BASE_URL,
        sourceFile,
        searchText
    )

    # Execute request and get response as JSON
    response = requests.get(url, headers={"content-type": "application/octet-stream"})
    if (response.status_code == 200):
        json = response.json()

        if json["error"] == False:
            # print(json)
            if json["body"]:
                retVal['top'] = json["body"][0]['top']
                retVal['left'] = json["body"][0]['left']
        else:
            # Show service reported error
            print(json["message"])
    else:
        print(f"Request error: {response.status_code} {response.reason}")

    return retVal



def addImageToPDF(destinationFile, top, left):
    """Add image using PDF.co Web API"""

    # Prepare URL for 'PDF Edit' API request
    url = "{}/pdf/edit/add?name={}&password={}&pages={}&url={}&type={}&x={}&y={}&width={}&height={}&urlimage={}".format(
        BASE_URL,
        os.path.basename(destinationFile),
        Password,
        Pages,
        SourceFileUrl,
        Type,
        top + 300,
        left,
        Width,
        Height,
        ImageUrl
    )

    # Execute request and get response as JSON
    response = requests.get(url, headers={"content-type": "application/octet-stream" })

    if (response.status_code == 200):

        json = response.json()

        if json["error"] == False:
            #  Get URL of result file
            resultFileUrl = json["url"]

            # Download result file
            r = requests.get(resultFileUrl, stream=True)
            with open(destinationFile, 'wb') as file:
                for chunk in r:
                    file.write(chunk)
            print(f"Result file saved as \"{destinationFile}\" file.")
        else:
            # Show service reported error
            print(json["message"])
    else:
        print(f"Request error: {response.status_code} {response.reason}")

if __name__ == '__main__':
    main()
```

<!-- code block end -->