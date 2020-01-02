VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Scanned PDF to Text"
   ClientHeight    =   1095
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   3675
   LinkTopic       =   "Form1"
   ScaleHeight     =   1095
   ScaleWidth      =   3675
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_scanned_pdf_to_text 
      Caption         =   "Convert Scanned PDF to Text"
      Height          =   855
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmd_scanned_pdf_to_text_Click()
    
    ' Hanlde Error
    On Error GoTo ErrorHandler:
    
    ' Create Bytescout.PDFExtractor.TextExtractor object
    Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
    
    ' Set Registration name and key
    extractor.RegistrationName = "demo"
    extractor.RegistrationKey = "demo"
  
    ' Load sample PDF document
    extractor.LoadDocumentFromFile "sample.pdf"
    
    ' Enable Optical Character Recognition (OCR)
    extractor.OCRMode = 1 ' OCRMode.Auto = 1
    
    ' Set the location of OCR language data files
    extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best"
    
    ' Set OCR language
    ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder.
    extractor.OCRLanguage = "eng"
    ' Find more language files at https://github.com/bytescout/ocrdata
    
    ' Set PDF document rendering resolution
    extractor.OCRResolution = 300

    ' You can also apply various preprocessing filters to improve the recognition on low-quality scans.
    ' But they significantly hit the performance, so do not enable them by default.
    
    ' Automatically deskew skewed scans
    'extractor.OCRImagePreprocessingFilters.AddDeskew()
    
    ' Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
    'extractor.OCRImagePreprocessingFilters.AddVerticalLinesRemover()
    'extractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()
    
    ' Repair broken letters
    'extractor.OCRImagePreprocessingFilters.AddDilate()
    
    ' Remove noise
    'extractor.OCRImagePreprocessingFilters.AddMedian()
    
    ' Apply Gamma Correction
    'extractor.OCRImagePreprocessingFilters.AddGammaCorrection()
    
    ' Add Contrast
    ' extractor.OCRImagePreprocessingFilters.AddContrast(20)
    
    
    ' (!) You can use new OCRAnalyzer class to find an optimal set of image preprocessing
    ' filters for your specific document.
    ' See "OCR Analyser" example.

    
    ' Peform Save to Text file
    extractor.SaveTextToFile "output.txt"
    
    ' Show Success Message
    MsgBox "Extracted data from scanned PDF are saved to 'output.text' file.", vbInformation, "Success"
    
    ' Close form
    Unload Me
    
ErrorHandler:
If Err.Number <> 0 Then
    MsgBox Err.Description, vbInformation, "Error"
End If

End Sub
