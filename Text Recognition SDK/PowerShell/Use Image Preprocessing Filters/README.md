## How to use image preprocessing filters in PowerShell with ByteScout Text Recognition SDK

### How to use image preprocessing filters in PowerShell

These source code samples are listed and grouped by their programming language and functions they use. ByteScout Text Recognition SDK is the text recognition SDK to help with extraction of text using OCR from scanned images and documents. Supports English and non-Latin languages, can take PDF as input and you can use it to use image preprocessing filters with PowerShell.

You will save a lot of time on writing and testing code as you may just take the PowerShell code from ByteScout Text Recognition SDK for use image preprocessing filters below and use it in your application. This PowerShell sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Code testing will allow the function to be tested and work properly with your data.

You can download free trial version of ByteScout Text Recognition SDK from our website to see and try many others source code samples for PowerShell.

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

##### ****ImagePreprocessingFilters.ps1:**
    
```
# Add reference to ByteScout.TextRecognition.dll assembly
Add-Type -Path "c:\Program Files\ByteScout Text Recognition SDK\net40\ByteScout.TextRecognition.dll"

$InputDocument = "..\..\skewed.png"
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


    # Add deskew filter that automatically rotates the image to make the text horizontal.
    # Note, it analyzes the left edge of scanned text. Any dark artifacts may prevent 
    # the correct angle detection.
    $textRecognizer.ImagePreprocessingFilters.AddDeskew()

    # Other filters that may be useful to improve recognition
    # (note, the filters are applied in the order they were added):

    # Improve image contrast.
    #$textRecognizer.ImagePreprocessingFilters.AddContrast()

    # Apply gamma correction.
    #$textRecognizer.ImagePreprocessingFilters.AddGammaCorrection()

    # Apply median filter. Helps to remove noise.
    #$textRecognizer.ImagePreprocessingFilters.AddMedian()

    # Apply dilate filter. Helps to cure symbols erosion.
    #$textRecognizer.ImagePreprocessingFilters.AddDilate()

    # Lines removers. Removing borders of some tables may improve the recognition.
    #$textRecognizer.ImagePreprocessingFilters.AddHorizontalLinesRemover()
    #$textRecognizer.ImagePreprocessingFilters.AddVerticalLinesRemover()


    # Recognize text from all pages and save it to file
    $textRecognizer.SaveText($OutputDocument)

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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\ImagePreprocessingFilters.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->