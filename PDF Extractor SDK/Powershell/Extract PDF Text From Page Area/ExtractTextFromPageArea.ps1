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

Write-Host "Load System.Drawing"
[Reflection.Assembly]::LoadWithPartialName("System.Drawing") | Out-Null

# Check input file exists
if ((Test-Path $InputFileName) -eq $false) {

    Write-Host "Input file does not exist." -ForegroundColor Red
    Exit 0
}

# Create and activate Bytescout.PDFExtractor.TextExtractor instance
$Extractor = New-Object Bytescout.PDFExtractor.TextExtractor
$Extractor.RegistrationName = "demo"
$Extractor.RegistrationKey = "demo"

try {
    # Load sample PDF document
    $Extractor.LoadDocumentFromFile($InputFileName)

    # Get page count
    $PageCount = $Extractor.GetPageCount()
    Write-Host "Pages: $PageCount"
    
    # Iterate through pages
    for ($i = 0; $i -lt $PageCount; $i++) {

        # Define rectangle location to extract from
        $Location = New-Object Drawing.Rectangle 0, 0, 200, 300
        
        # Set extraction area
        $Extractor.SetExtractionArea($Location)

        # Extract text from the extraction area
        $Text = $Extractor.GetTextFromPage($i);

        $PageNo = $i + 1
        Write-Host "Extracted from page $PageNo"
        Write-Host $Text

        # Reset the extraction area
        $Extractor.ResetExtractionArea()
    }
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()