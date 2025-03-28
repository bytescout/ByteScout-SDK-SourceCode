import os
import requests
import json
import time
import datetime

# The authentication key (API Key).
API_KEY = "*****************************************************"

# Base URL for PDF.co Web API requests
BASE_URL = "https://api.pdf.co/v1"

# Direct URL of source PDF file.
SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf"

# Destination PDF file name
DestinationFile = ".//result.pdf"

# Text annotation params
TextType = "annotation"
TextX = 400
TextY = 60
Text = "APPROVED"
FontName = "Times New Roman"
FontSize = 24
Color = "FF0000"

# Image params
ImageType = "image"
ImageX = 400
ImageY = 20
ImageWidth = 119
ImageHeight = 32
ImageUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png"


def main(args=None):
    addToExistingPDF(DestinationFile)


def addToExistingPDF(destinationFile):
    """Add Text and Image using PDF.co Web API"""
    
    # Prepare requests params as JSON
    payload = json.dumps({
        "name": os.path.basename(destinationFile),
        "password": "",
        "url": SourceFileUrl,
        "annotations": [{
            "text": Text,
            "x": TextX,
            "y": TextY,
            "fontname": FontName,
            "size": FontSize,
            "color": Color,
            "pages": ""
        }],
        "images": [{
            "url": ImageUrl,
            "x": ImageX,
            "y": ImageY,
            "width": ImageWidth,
            "height": ImageHeight,
            "pages": ""
        }],
        "async": True  # Enable asynchronous processing
    })

    # Prepare URL for 'PDF Edit' API request
    url = f"{BASE_URL}/pdf/edit/add"
    
    # Execute request and get response as JSON
    response = requests.post(url, data=payload, headers={"x-api-key": API_KEY})
    if response.status_code == 200:
        json_response = response.json()

        # If there are no errors, proceed to poll for job status
        if not json_response.get("error", False):
            # Extract the jobId from the response
            jobId = json_response.get("jobId")
            if jobId:
                print(f"Job ID: {jobId}")  # Output job ID

                # Poll the job status
                while True:
                    status = checkJobStatus(jobId)
                    print(datetime.datetime.now().strftime("%H:%M.%S") + ": " + status)

                    if status == "success":
                        # Extract the result URL to the final PDF
                        resultJsonUrl = json_response["url"]
                        print(f"Result JSON URL: {resultJsonUrl}")  # Debug print to check the result URL
                        
                        # Fetch the result JSON to get the PDF URL
                        fetchAndDownloadPdf(resultJsonUrl, destinationFile)
                        break
                    elif status == "working":
                        # Pause for a few seconds before polling again
                        time.sleep(3)
                    else:
                        print(status)
                        break
        else:
            print(f"Error: {json_response.get('message', 'Unknown error')}")
    else:
        print(f"Request error: {response.status_code} {response.reason}")


def fetchAndDownloadPdf(resultJsonUrl, destinationFile):
    """Fetch result JSON to get the final PDF URL and download the PDF"""
    # Fetch the result JSON file that contains the final PDF URL
    result_json_response = requests.get(resultJsonUrl, headers={"x-api-key": API_KEY})
    
    if result_json_response.status_code == 200:
        result_json = result_json_response.json()
        
        # Extract the actual PDF URL from the JSON response
        finalPdfUrl = result_json["url"]
        print(f"Final PDF URL: {finalPdfUrl}")  # Debug print to check the final PDF URL
        
        # Download the actual PDF
        pdf_response = requests.get(finalPdfUrl, headers={"x-api-key": API_KEY}, stream=True)
        if pdf_response.status_code == 200:
            with open(destinationFile, 'wb') as file:
                for chunk in pdf_response.iter_content(chunk_size=8192):
                    file.write(chunk)
            print(f"Result PDF saved as \"{destinationFile}\".")  # Final result
        else:
            print(f"Error downloading PDF: {pdf_response.status_code} {pdf_response.reason}")
    else:
        print(f"Error fetching result JSON: {result_json_response.status_code} {result_json_response.reason}")


def checkJobStatus(jobId):
    """Checks server job status"""
    url = f"{BASE_URL}/job/check?jobid={jobId}"

    response = requests.get(url, headers={"x-api-key": API_KEY})
    if response.status_code == 200:
        json_response = response.json()
        return json_response["status"]
    else:
        print(f"Request error: {response.status_code} {response.reason}")

    return None


if __name__ == '__main__':
    main()
