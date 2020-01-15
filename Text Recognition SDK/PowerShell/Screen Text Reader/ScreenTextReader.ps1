# Add reference to ByteScout.TextRecognition.dll assembly
Add-Type -Path "c:\Program Files\ByteScout Text Recognition SDK\net40\ByteScout.TextRecognition.dll"

$OutputDocument = ".\result.txt"

# Create and activate TextRecognizer instance
$textRecognizer = New-Object ByteScout.TextRecognition.TextRecognizer
$textRecognizer.RegistrationName = "demo"
$textRecognizer.RegistrationKey = "demo"

try {
    # Create ScreenshotMaker instance
    $screenshotMaker = New-Object ByteScout.TextRecognition.ScreenshotMaker
    # Set rectangle to take screenshot from
    $screenshotMaker.SetScreenshotArea(0, 0, 200, 200)

    # Load screenshot
    $textRecognizer.LoadDocument($screenshotMaker)

    # Set the location of OCR language data files
    $textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\"

    # Set OCR language.
    # "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
    # Find more language files at https://github.com/bytescout/ocrdata
    $textRecognizer.OCRLanguage = "eng"

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
