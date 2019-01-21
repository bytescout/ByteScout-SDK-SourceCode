# Add reference to ByteScout.TextRecognition.dll assembly
Add-Type -Path "c:\Program Files\ByteScout Text Recognition SDK\net40\ByteScout.TextRecognition.dll"

$InputDocument = "..\..\invoice-sample.png"
$OutputDocument = ".\result.txt"

# Create and activate TextRecognizer instance
$textRecognizer = New-Object ByteScout.TextRecognition.TextRecognizer
$textRecognizer.RegistrationName = "demo"
$textRecognizer.RegistrationKey = "demo"

try {
    # Load document (image or PDF)
    $textRecognizer.LoadDocument($InputDocument)

    # Set location of "tessdata" folder containing language data files
    $textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\tessdata\"

    # Set OCR language.
    # "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "tessdata" folder
    # Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00
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
