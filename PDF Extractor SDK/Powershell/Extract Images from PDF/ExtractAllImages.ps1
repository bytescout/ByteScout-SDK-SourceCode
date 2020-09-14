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

# Create and activate Bytescout.PDFExtractor.ImageExtractor instance
$Extractor = New-Object Bytescout.PDFExtractor.ImageExtractor
$Extractor.RegistrationName = "demo"
$Extractor.RegistrationKey = "demo"

try {
    # Load sample PDF document
    $Extractor.LoadDocumentFromFile($InputFileName)

    # Advance image enumeration
    if ($Extractor.GetFirstImage() -eq $true) {

        $i = 0
        do {
            # Construct output file name
            $OutputFileName = "image$i.png"
            # Save image to file
            $Extractor.SaveCurrentImageToFile($OutputFileName)
            $i++
        } while ($Extractor.GetNextImage() -eq $true) # Advance image enumeration
    }
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()