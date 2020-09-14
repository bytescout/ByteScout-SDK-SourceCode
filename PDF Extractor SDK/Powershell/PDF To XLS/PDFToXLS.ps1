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

# Create and activate Bytescout.PDFExtractor.XLSExtractor instance
$Extractor = New-Object Bytescout.PDFExtractor.XLSExtractor
$Extractor.RegistrationName = "demo"
$Extractor.RegistrationKey = "demo"

try {
    # Load sample PDF document
    $Extractor.LoadDocumentFromFile($InputFileName)

    # Construct output file name
    $OutputFileName = [System.IO.Path]::ChangeExtension($InputFileName, "xls")
    # Delete output file
    if ((Test-Path $OutputFileName) -eq $true) {
        Remove-Item $OutputFileName
    }
    # Set the output format to XLS
    $Extractor.OutputFormat = 0 # 0 = SpreadseetOutputFormat.XLS
    # Save the spreadsheet to file
    $Extractor.SaveToXLSFile($OutputFileName)
    Write-Host "Data has been extracted to $OutputFileName file."
} catch {

    Write-Host $_.Exception.Message
}

$Extractor.Dispose()