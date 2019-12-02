import os
import requests  # pip install requests

# Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
# If it's not then please replace this with with your hosting url.

# Base URL for PDF.co Web API requests
BASE_URL = "https://localhost"

# Direct URL of PDF file to get information
SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-info/sample.pdf"


def main(args=None):
    getInfoFromUrl(SourceFileURL)


def getInfoFromUrl(uploadedFileUrl):
    """Get Information using PDF.co Web API"""

    # Prepare URL for 'PDF Info' API request
    url = "{}/pdf/info?url={}".format(
        BASE_URL,
        uploadedFileUrl
    )

    # Execute request and get response as JSON
    response = requests.get(url, headers={ "content-type": "application/octet-stream"})
    if (response.status_code == 200):
        json = response.json()

        if json["error"] == False:
            # Display information
            print(json["info"])
        else:
            # Show service reported error
            print(json["message"])
    else:
        print(f"Request error: {response.status_code} {response.reason}")

if __name__ == '__main__':
    main()