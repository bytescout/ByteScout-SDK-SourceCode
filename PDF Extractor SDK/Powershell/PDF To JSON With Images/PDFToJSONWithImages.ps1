#*******************************************************************************************#
#                                                                                           #
# Download Free Evaluation Version From: https://bytescout.com/download/web-installer       #
#                                                                                           #
# Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               #
#                                                                                           #
# Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                #
# https://www.bytescout.com                                                                 #
# https://pdf.co                                                                            #
#                                                                                           #
#*******************************************************************************************#

Param (
    [Parameter(Mandatory = $true)]
    [string] $InputFileName = ""
)

#Add reference to Bytescout.PDFExtractor.dll assembly
Add-Type -Path "C:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll"

# Check input file exists
if ((Test-Path $InputFileName) -eq $false) {

    Write-Host "Input file does not exist." -ForegroundColor Red
    Exit 0
}

# Create and activate Bytescout.PDFExtractor.JSONExtractor instance
$Extractor = New-Object Bytescout.PDFExtractor.JSONExtractor
$Extractor.RegistrationName = "demo"
$Extractor.RegistrationKey = "demo"
# Uncomment this line to get rid of empty nodes in JSON
# $Extractor.PreserveFormattingOnTextExtraction = $false
try {
    # Load sample PDF document
    $Extractor.LoadDocumentFromFile($InputFileName)

    # Set output image format
    # 0 = PNG; 1 = JPEG; 2 = GIF; 3 = BMP
    $Extractor.ImageFormat = 0

    # Save images to external files
    $Extractor.SaveImages = 1 # 1 = ImageHandling.OuterFile
    # Folder for external images
    $Extractor.ImageFolder = "images"
    $Extractor.SaveJSONToFile("result_with_external_images.json")

    # Embed images into JSON as Base64 encoded string
    # Save images to external files
    $Extractor.SaveImages = 2 # 2 = ImageHandling.Embed
    $Extractor.SaveJSONToFile("result_with_embedded_images.json")
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()