import os
import requests # pip install requests

# The authentication key (API Key).
# Get your own by registering at https://app.pdf.co/documentation/api
API_KEY = "******************************************"

# Base URL for PDF.co Web API requests
BASE_URL = "https://api.pdf.co/v1"

# Direct URL of source PDF file.
SourceFileURL = "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf"
# PDF document password. Leave empty for unprotected documents.
Password = ""
# Destination PDF file name
DestinationFile = ".\\result.pdf"

def main(args = None):
    replaceStringFromPdf(SourceFileURL, DestinationFile)


def replaceStringFromPdf(uploadedFileUrl, destinationFile):
    """Replace Text from PDF using PDF.co Web API"""

    # Prepare requests params as JSON
    # See documentation: https://apidocs.pdf.co
    parameters = {}
    parameters["name"] = os.path.basename(destinationFile)
    parameters["password"] = Password
    parameters["url"] = uploadedFileUrl
    parameters["searchString"] = "Your Company Name"
    parameters["replaceString"] = "XYZ LLC"

    # Prepare URL for 'Replace Text from PDF' API request
    url = "{}/pdf/edit/replace-text".format(BASE_URL)

    # Execute request and get response as JSON
    response = requests.post(url, data=parameters, headers={ "x-api-key": API_KEY })

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