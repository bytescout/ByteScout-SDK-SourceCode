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

# Create and activate Bytescout.PDFExtractor.CSVExtractor instance
$Extractor = New-Object Bytescout.PDFExtractor.CSVExtractor
$Extractor.RegistrationName = "demo"
$Extractor.RegistrationKey = "demo"
# you can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales
# $Extractor.CSVSeparatorSymbol = ","

try {
    # Load sample PDF document
    $Extractor.LoadDocumentFromFile($InputFileName)

    # Construct output file name
    $OutputFileName = [System.IO.Path]::ChangeExtension($InputFileName, "csv")
    # Save extracted CSV data
    $Extractor.SaveCSVToFile($OutputFileName)
    Write-Host "Data has been extracted to $OutputFileName file."
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()