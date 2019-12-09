## How to add text and images to PDF in Python using ByteScout Cloud API Server

### Step-by-step tutorial on how to add text and images to PDF in Python

Quickly learn how to add text and images to PDF in Python with this sample source code. ByteScout Cloud API Server: the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!. It can add text and images to PDF in Python.

The following code snippet for ByteScout Cloud API Server works best when you need to quickly add text and images to PDF in your Python application. Follow the instructions from scratch to work and copy the Python code. Check Python sample code samples to see if they respond to your needs and requirements for the project.

Our website gives trial version of ByteScout Cloud API Server for free. It also includes documentation and source code samples.

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

##### **AddTextToExistingPDF.py:**
    
```
import os
import requests # pip install requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# Direct URL of source PDF file.
SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf"

#Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
Pages = ""

# PDF document password. Leave empty for unprotected documents.
Password = ""

# Destination PDF file name
DestinationFile = ".//result.pdf"

# Text annotation params
Type = "annotation"
X = 400
Y = 600
Text = "APPROVED"
FontName = "Times New Roman"
FontSize = 24
Color = "FF0000"


def main(args = None):
    addTextToExistingPDF(DestinationFile)

def addTextToExistingPDF(destinationFile):
    """Add Text using PDF.co Web API"""

    # Prepare URL for 'PDF Edit' API request
    url = "{}/pdf/edit/add?name={}&password={}&pages={}&url={}&type={}&x={}&y={}&text={}&fontname={}&size={}&color={}".format(
        BASE_URL,
        os.path.basename(destinationFile),
        Password,
        Pages,
        SourceFileUrl,
        Type,
        X,
        Y,
        Text,
        FontName,
        FontSize,
        Color
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