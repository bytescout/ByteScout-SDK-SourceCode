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

# This example demonstrates various PDF document splitting scenarios:
# - extract a single page;
# - split in two parts;
# - split by ranges specified in text form: "1-5,6,7-10,11-".

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

# Create and activate Bytescout.PDFExtractor.DocumentSplitter instance
$Splitter = New-Object Bytescout.PDFExtractor.DocumentSplitter
$Splitter.RegistrationName = "demo"
$Splitter.RegistrationKey = "demo"
$Splitter.OptimizeSplittedDocuments = $true

try {

    # Extracting specific page
    $Splitter.ExtractPage($InputFileName, "page3.pdf", 3) # (!) Note: page number is 1-based.
    Write-Host "Extracted page 3 to file ""page3.pdf"""

    # Split in two parts
    $Splitter.Split($InputFileName, "part1.pdf", "part2.pdf", 3) # (!) Note: page number is 1-based.
    Write-Host "Splitted at page 3 to files ""part1.pdf"" and ""part2.pdf"""

    # Split by ranges
    $Files = $Splitter.Split($InputFileName, "1-3,4-6,7,8-") # (!) Note: page numbers are 1-based; ending "-" means "to the end"
    Write-Host "Splitted by ranges:"
    foreach ($OutputFileName in $Files) {

        Write-Host $OutputFileName
    }
} catch {

    Write-Host $_.Exception.Message
}

$Splitter.Dispose()