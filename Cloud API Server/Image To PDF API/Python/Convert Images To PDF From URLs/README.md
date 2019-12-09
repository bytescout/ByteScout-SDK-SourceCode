## How to convert images to PDF from urls for image to PDF API in Python using ByteScout Cloud API Server

### Learn in simple ways: How to convert images to PDF from urls for image to PDF API in Python

The sample source codes on this page will show you how to create image to PDF API in Python. Image to PDF API in Python can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

If you want to speed up the application’s code writing then Python code samples for Python developers help to implement using ByteScout Cloud API Server. For implementation of this functionality, please copy and paste the code below into your app using code editor. Then compile and run your app. Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Trial version of ByteScout is available for free download from our website. This and other source code samples for Python and other programming languages are available.

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

##### **ConvertImagesToPdfFromUrls.py:**
    
```
import os
import requests # pip install requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# Direct URLs of image files to convert to PDF document
SourceFiles = [
    "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image1.png",
    "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image2.jpg"
]
# Destination PDF file name
DestinationFile = ".\\result.pdf"

def main(args = None):
    SourceFileURL = ",".join(SourceFiles)
    convertImageToPDF(SourceFileURL, DestinationFile)


def convertImageToPDF(uploadedFileUrl, destinationFile):
    """Converts Image to PDF using PDF.co Web API"""

    # Prepare URL for 'Image To PDF' API request
    url = "{}/pdf/convert/from/image?name={}&url={}".format(
        BASE_URL,
        os.path.basename(destinationFile),
        uploadedFileUrl
    )

    # Execute request and get response as JSON
    response = requests.get(url, headers={  "content-type": "application/octet-stream" })
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