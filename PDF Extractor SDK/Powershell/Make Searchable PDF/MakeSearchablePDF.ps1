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

# By default, "SearchablePDFMaker" uses one of the standard PDF fonts to apply 
# recognized text over the scanned document. Such fonts contain only basic characters 
# from ISO-8859-1 charset. 
# If you run OCR for one of the languages with characters that are not present in the default
# encoding, you should explicitly specify the font that contains the required characters
# using ".LabelingFont" property.
# If you run the application in Windows with a selected locale that matches OCR language, 
# it will be enough to specify the usual font "Arial". But if your app will run in an unknown
# environment (for example, in some virtual machine) you will need to install some full Unicode 
# font (e.g. "Arial Unicode MS") and then use it with SearchablePDFMaker:

# $SearchablePDFMaker.LabelingFont = "Arial Unicode MS"

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

# Create and activate Bytescout.PDFExtractor.SearchablePDFMaker instance
$SearchablePDFMaker = New-Object Bytescout.PDFExtractor.SearchablePDFMaker
$SearchablePDFMaker.RegistrationName = "demo"
$SearchablePDFMaker.RegistrationKey = "demo"

try {
    # Load sample PDF document
    $SearchablePDFMaker.LoadDocumentFromFile($InputFileName)

    # Set the location of language data files
    $SearchablePDFMaker.OCRLanguageDataFolder = "C:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

    # Set OCR language
    # "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
    $SearchablePDFMaker.OCRLanguage = "eng"

    # Set PDF document rendering resolution
    $SearchablePDFMaker.OCRResolution = 300

    # Process document
    $SearchablePDFMaker.MakePDFSearchable("output.pdf")

} catch {

    Write-Host $_.Exception.Message
}

# Cleanup
$SearchablePDFMaker.Dispose()