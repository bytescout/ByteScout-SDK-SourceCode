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

# Note: if you are looking for a more higher level API to extract data from invoices, reports, statements
# then please check Document Parser SDK and Web API at https://bytescout.com/products/developer/documentparsersdk/index.html
# and https://pdf.co for secure and scalable web api

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

        # Search each page for a keyword
        if ($Extractor.Find($i, "bombardment", $false) -eq $true) {

            # Extract page
            $Splitter = New-Object Bytescout.PDFExtractor.DocumentSplitter
            $Splitter.RegistrationName = "demo"
            $Splitter.RegistrationKey = "demo"

            $Splitter.OptimizeSplittedDocuments = $true

            # (!) page number in ExtractPage() is 1-based
            $PageNo = $i + 1
            # Construct output file name
            $OutputFileName = "page$PageNo.pdf"
            $Splitter.ExtractPage($InputFileName, $OutputFileName, $PageNo)
            
            Write-Host "Extracted page $PageNo to file $OutputFileName"

            $Splitter.Dispose()
        }
    }
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()