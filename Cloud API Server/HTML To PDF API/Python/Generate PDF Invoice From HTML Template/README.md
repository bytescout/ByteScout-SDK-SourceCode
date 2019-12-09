## How to generate PDF invoice from HTML template for HTML to PDF API in Python and ByteScout Cloud API Server

### Step-by-step tutorial:How to generate PDF invoice from HTML template to have HTML to PDF API in Python

Check these thousands of pre-made source code samples for simple implementation in your own programming projects. HTML to PDF API in Python can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

The SDK samples displayed below below explain how to quickly make your application do HTML to PDF API in Python with the help of ByteScout Cloud API Server.  This sample code in Python is all you need. Just copy-paste it to the code editor, then add a reference to ByteScout Cloud API Server and you are ready to try it! Use of ByteScout Cloud API Server in Python is also described in the documentation given along with the product.

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

##### **GeneratePdfInvoiceFromHtmlTemplate.py:**
    
```
import os
import  json
import requests # pip install requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# HTML template
file_read = open(".\\invoice_template.html", mode='r')
Template = file_read.read()
file_read.close()

# Data to fill the template
file_read = open(".\\invoice_data.json", mode='r')
TemplateData = json.dumps(file_read.read())
file_read.close()

# Destination PDF file name
DestinationFile = ".\\result.pdf"


def main(args = None):
    GeneratePDFFromTemplate(Template, TemplateData, DestinationFile)


def GeneratePDFFromTemplate(template, templateData, destinationFile):
    """Converts HTML to PDF using PDF.co Web API"""

    data = {
        'templateData': templateData,
        'html': template
    }

    # Prepare URL for 'HTML To PDF' API request
    url = "{}/pdf/convert/from/html?name={}".format(
        BASE_URL,
        os.path.basename(destinationFile)
    )

    # Execute request and get response as JSON

    response = requests.post(url, data=data)
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