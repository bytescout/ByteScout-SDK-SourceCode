## How to convert web page to PDF from link asynchronously for HTML to PDF API in Python with ByteScout Cloud API Server

### Follow this simple tutorial to learn convert web page to PDF from link asynchronously to have HTML to PDF API in Python

These simple tutorials explain the code material for beginners and advanced programmers who are using Python. HTML to PDF API in Python can be applied with ByteScout Cloud API Server. ByteScout Cloud API Server is the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

If you want to speed up the application’s code writing then Python code samples for Python developers help to implement using ByteScout Cloud API Server. For implementation of this functionality, please copy and paste the code below into your app using code editor. Then compile and run your app. Enjoy writing a code with ready-to-use sample Python codes to add HTML to PDF API functions using ByteScout Cloud API Server in Python.

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

##### **ConvertWebPageToPdfFromLinkAsynchronously.py:**
    
```
""" Cloud API asynchronous "PDF To Text" job example.
    Allows to avoid timeout errors when processing huge or scanned PDF documents.
"""
import os
import requests # pip install requests
import time
import datetime

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# URL of web page to convert to PDF document.
SourceUrl = "http://en.wikipedia.org/wiki/Main_Page"
# Destination PDF file name
DestinationFile = ".\\result.pdf"
# (!) Make asynchronous job
Async = True


def main(args = None):
    convertLinkToPDF(SourceUrl, DestinationFile)


def convertLinkToPDF(uploadedFileUrl, destinationFile):
    """Converts Link To PDF using PDF.co Web API"""

    # Prepare URL for 'URL To PDF' API request
    url = "{}/pdf/convert/from/url?async={}&name={}&url={}".format(
        BASE_URL,
        Async,
        os.path.basename(destinationFile),
        uploadedFileUrl
    )

    # Execute request and get response as JSON
    response = requests.get(url, headers={  "content-type": "application/octet-stream" })
    if (response.status_code == 200):
        json = response.json()

        if json["error"] == False:
            # Asynchronous job ID
            jobId = json["jobId"]
            #  URL of the result file
            resultFileUrl = json["url"]
            
            # Check the job status in a loop. 
            # If you don't want to pause the main thread you can rework the code 
            # to use a separate thread for the status checking and completion.
            while True:
                status = checkJobStatus(jobId) # Possible statuses: "working", "failed", "aborted", "success".
                
                # Display timestamp and status (for demo purposes)
                print(datetime.datetime.now().strftime("%H:%M.%S") + ": " + status)
                
                if status == "success":
                    # Download result file
                    r = requests.get(resultFileUrl, stream=True)
                    if (r.status_code == 200):
                        with open(destinationFile, 'wb') as file:
                            for chunk in r:
                                file.write(chunk)
                        print(f"Result file saved as \"{destinationFile}\" file.")
                    else:
                        print(f"Request error: {response.status_code} {response.reason}")
                    break
                elif status == "working":
                    # Pause for a few seconds
                    time.sleep(3)
                else:
                    print(status)
                    break
        else:
            # Show service reported error
            print(json["message"])
    else:
        print(f"Request error: {response.status_code} {response.reason}")


def checkJobStatus(jobId):
    """Checks server job status"""

    url = f"{BASE_URL}/job/check?jobid={jobId}"
    
    response = requests.get(url)
    if (response.status_code == 200):
        json = response.json()
        return json["status"]
    else:
        print(f"Request error: {response.status_code} {response.reason}")

    return None

if __name__ == '__main__':
    main()
```

<!-- code block end -->