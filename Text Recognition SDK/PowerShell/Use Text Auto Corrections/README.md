## How to use text auto corrections in PowerShell with ByteScout Text Recognition SDK

### The tutorial below will demonstrate how to use text auto corrections in PowerShell

Learn how to use text auto corrections in PowerShell with this source code sample. ByteScout Text Recognition SDK is the SDK designed to help developers in quick implementation of high quality OCR text recognition from scanned images and pdf and you can use it to use text auto corrections with PowerShell.

The SDK samples like this one below explain how to quickly make your application do use text auto corrections in PowerShell with the help of ByteScout Text Recognition SDK. In order to implement the functionality, you should copy and paste this code for PowerShell below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in PowerShell.

ByteScout Text Recognition SDK free trial version is available on our website. PowerShell and other programming languages are supported.

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

##### ****AutoCorrections.ps1:**
    
```
# Add reference to ByteScout.TextRecognition.dll assembly
Add-Type -Path "c:\Program Files\ByteScout Text Recognition SDK\net40\ByteScout.TextRecognition.dll"

$InputDocument = "..\..\bad-quality.png"
$OutputDocument = ".\result.txt"

# Create and activate TextRecognizer instance
$textRecognizer = New-Object ByteScout.TextRecognition.TextRecognizer
$textRecognizer.RegistrationName = "demo"
$textRecognizer.RegistrationKey = "demo"

try {
    # Load document (image or PDF)
    $textRecognizer.LoadDocument($InputDocument)

    # Set the location of OCR language data files
    $textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_fast\"

    # Set OCR language.
    # "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
    # Find more language files at https://github.com/bytescout/ocrdata
    $textRecognizer.OCRLanguage = "eng"


    # Add error corrections that will be applied after the recognition.
    $textRecognizer.Corrections.Add("Tut ", "Test ")
    $textRecognizer.Corrections.Add("Recog\w{1,}on", "Recognition", $true) # regular expression (regex) replacement


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

powershell -NoProfile -ExecutionPolicy Bypass -Command "& .\AutoCorrections.ps1"
echo Script finished with errorlevel=%errorlevel%

pause
```

<!-- code block end -->