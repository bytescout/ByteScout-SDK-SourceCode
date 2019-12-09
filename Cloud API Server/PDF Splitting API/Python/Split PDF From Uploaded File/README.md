## How to split PDF from uploaded file for PDF splitting API in Python using ByteScout Cloud API Server

### Learn in simple ways: How to split PDF from uploaded file for PDF splitting API in Python

On this page, you will find sample source codes which show you how to handle a complex task, such as, PDF splitting API in Python. ByteScout Cloud API Server was designed to assist PDF splitting API in Python. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

If you want to speed up the application’s code writing then Python code samples for Python developers help to implement using ByteScout Cloud API Server. For implementation of this functionality, please copy and paste the code below into your app using code editor. Then compile and run your app. Use of ByteScout Cloud API Server in Python is also described in the documentation given along with the product.

Our website provides free trial version of ByteScout Cloud API Server that gives source code samples to assist with your Python project.

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

##### **SplitPDFFromUploadedFile.py:**
    
```
import os
import requests # pip install requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# Source PDF file
SourceFile = ".\\sample.pdf"
# Comma-separated list of page numbers (or ranges) to process. Example: '1,3-5,7-'.
Pages = "1-2,3-"


def main(args = None):
    uploadedFileUrl = uploadFile(SourceFile)
    if (uploadedFileUrl != None):
        splitPDF(uploadedFileUrl)


def splitPDF(uploadedFileUrl):
    """Split PDF using PDF.co Web API"""

    # Prepare URL for 'Split PDF' API request
    url = "{}/pdf/split?pages={}&url={}".format(
        BASE_URL,
        Pages,
        uploadedFileUrl
    )

    # Execute request and get response as JSON
    response = requests.get(url, headers={  "content-type": "application/octet-stream" })
    if (response.status_code == 200):
        json = response.json()

        if json["error"] == False:

            # Download generated PNG files
            part = 1

            for resultFileUrl in json["urls"]:
                # Download Result File
                r = requests.get(resultFileUrl, stream=True)

                localFileUrl = f"Page{part}.pdf"

                if r.status_code == 200:
                    with open(localFileUrl, 'wb') as file:
                        for chunk in r:
                            file.write(chunk)
                    print(f"Result file saved as \"{localFileUrl}\" file.")
                else:
                    print(f"Request error: {response.status_code} {response.reason}")

                part = part + 1
        else:
            # Show service reported error
            print(json["message"])
    else:
        print(f"Request error: {response.status_code} {response.reason}")


def uploadFile(fileName):
    """Uploads file to the cloud"""
    
    # 1. RETRIEVE PRESIGNED URL TO UPLOAD FILE.

    # Prepare URL for 'Get Presigned URL' API request
    url = "{}/file/upload/get-presigned-url?contenttype=application/octet-stream&name={}".format(
        BASE_URL, os.path.basename(fileName))
    
    # Execute request and get response as JSON
    response = requests.get(url)
    if (response.status_code == 200):
        json = response.json()
        
        if json["error"] == False:
            # URL to use for file upload
            uploadUrl = json["presignedUrl"]
            # URL for future reference
            uploadedFileUrl = json["url"]

            # 2. UPLOAD FILE TO CLOUD.
            with open(fileName, 'rb') as file:
                requests.put(uploadUrl, data=file, headers={  "content-type": "application/octet-stream" })

            return uploadedFileUrl
        else:
            # Show service reported error
            print(json["message"])    
    else:
        print(f"Request error: {response.status_code} {response.reason}")

    return None


if __name__ == '__main__':
    main()
```

<!-- code block end -->