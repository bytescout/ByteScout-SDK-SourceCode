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
    [string] $InputFolder = ""
)

#Add reference to Bytescout.PDFExtractor.dll assembly
Add-Type -Path "C:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll"

# Check input folder exists
if ((Test-Path $InputFolder) -eq $false) {

    Write-Host "Input folder does not exist." -ForegroundColor Red
    Exit 0
}

$IncludeSubFolder = $true
$OutputFileName = "result.pdf"

# Create and activate Bytescout.PDFExtractor.DocumentMerger instance
$Merger = New-Object Bytescout.PDFExtractor.DocumentMerger
$Merger.RegistrationName = "demo"
$Merger.RegistrationKey = "demo"

try {
    $Merger.MergeFolder($InputFolder, $OutputFileName, $IncludeSubFolder)
} catch {

    Write-Host $_.Exception.Message
}

$Merger.Dispose()