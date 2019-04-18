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
