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