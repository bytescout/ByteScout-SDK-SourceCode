## How to convert scanned pdf to text with pdf extractor sdk in VB6 and ByteScout PDF Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to convert scanned pdf to text with pdf extractor sdk in VB6

The code displayed below will guide you to install an VB6 app to convert scanned pdf to text with pdf extractor sdk. ByteScout PDF Suite can convert scanned pdf to text with pdf extractor sdk. It can be applied from VB6. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

The following code snippet for ByteScout PDF Suite works best when you need to quickly convert scanned pdf to text with pdf extractor sdk in your VB6 application. IF you want to implement the functionality, just copy and paste this code for VB6 below into your code editor with your app, compile and run your application. Further improvement of the code will make it more robust.

ByteScout PDF Suite free trial version is available on our website. VB6 and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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

##### ****Form1.frm:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Scanned_PDF_To_Text.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\..\..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{F1D62CEE-68AA-4F38-9DB0-8021C13255D8}#9.1#0#..\..\..\..\..\..\..\..\..\WINDOWS\SYSWOW64\Bytescout.PDFRenderer.tlb#ByteScout PDF Renderer SDK [TRIAL]
Form=Form1.frm
Startup="Form1"
Command32=""
Name="ScannedPDFToText"
HelpContextID="0"
CompatibleMode="0"
MajorVer=1
MinorVer=0
RevisionVer=0
AutoIncrementVer=0
ServerSupportFiles=0
VersionCompanyName="Hiren"
CompilationType=0
OptimizationType=0
FavorPentiumPro(tm)=0
CodeViewDebugInfo=0
NoAliasing=0
BoundsCheck=0
OverflowCheck=0
FlPointCheck=0
FDIVCheck=0
UnroundedFP=0
StartMode=0
Unattended=0
Retained=0
ThreadPerObject=0
MaxNumberOfThreads=1

```

<!-- code block end -->