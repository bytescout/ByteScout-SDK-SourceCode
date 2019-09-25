## How to extract text from areas in PowerShell with ByteScout Text Recognition SDK

### Write code in PowerShell to extract text from areas with this step-by-step tutorial

Learn how to extract text from areas in PowerShell with this source code sample. ByteScout Text Recognition SDK is the text recognition SDK to help with extraction of text using OCR from scanned images and documents. Supports English and non-Latin languages, can take PDF as input. It can be used to extract text from areas using PowerShell.

Fast application programming interfaces of ByteScout Text Recognition SDK for PowerShell plus the instruction and the code below will help you quickly learn how to extract text from areas. Follow the instructions from the scratch to work and copy the PowerShell code. Further enhancement of the code will make it more vigorous.

Download free trial version of ByteScout Text Recognition SDK from our website with this and other source code samples for PowerShell.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Text%20Recognition%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Text%20Recognition%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****ExtractFromAreas.ps1:**
    
```
# Add reference to ByteScout.TextRecognition.dll assembly
Add-Type -Path "c:\Program Files\ByteScout Text Recognition SDK\net40\ByteScout.TextRecognition.dll"

$InputDocument = "..\..\areas-sample.pdf"
$PageIndex = 0
$OutputDocument = ".\result.txt"

# Create and activate TextRecognizer instance
$textRecognizer = New-Object ByteScout.TextRecognition.TextRecognizer
$textRecognizer.RegistrationName = "demo"
$textRecognizer.RegistrationKey = "demo"

try {
    # Load document (image or PDF)
    $textRecognizer.LoadDocument($InputDocument)

    # Set the location of OCR language data files
    $textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\"

    # Set OCR language.
    # "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
    # Find more language files at https://github.com/bytescout/ocrdata
    $textRecognizer.OCRLanguage = "eng"


    # Get page size (in pixels). Size of PDF document is computed from PDF Points 
    # and the rendering resolution specified by `textRecognizer.PDFRenderingResolution` (default 300 DPI)
    $pageSize = $textRecognizer.GetPageSize($PageIndex)

    # Add area of interest as a rectangle at the top-right corner of the page
    $textRecognizer.RecognitionAreas.Add($pageSize.Width / 2, 0, $pageSize.Width / 2, 300)
    # Add area of interest as a rectangle at the bottom-left corner of the page,
    # and indicate it should be rotated at 90 deg
    $textRecognizer.RecognitionAreas.Add(0, $pageSize.Height / 2, 300, $pageSize.Height / 2, [ByteScout.TextRecognition.AreaRotation]::Rotate90FlipNone)

    # Now, you can get recognized text for further analysis as a list of objects 
    # containing coordinates, object kind, confidence.
    $ocrObjectList = $textRecognizer.GetOCRObjects($PageIndex)
    foreach ($ocrObject in $ocrObjectList) {
        Write-Host $($ocrObject.ToString())
    }

    # ... or you can save recognized text pieces to file
    $textRecognizer.KeepTextFormatting = $false # save without formatting
    $textRecognizer.SaveText($OutputDocument, $PageIndex, $PageIndex)

    # Open the result file in default associated application (for demo purposes)
    & $OutputDocument
}
catch {
    # Display exception
    Write-Host $_.Exception.Message
}

$textRecognizer.Dispose()

```

<!-- code block end -->    

<!-- code block begin -->

##### ****run.bat:**
    
```
@echo off

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ExtractFromAreas.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->