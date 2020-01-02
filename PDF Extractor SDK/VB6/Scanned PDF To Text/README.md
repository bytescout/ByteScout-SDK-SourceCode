## scanned PDF to text in VB6 with ByteScout PDF Extractor SDK

### Make scanned PDF to text in VB6: ### Tutorial on how to do scanned PDF to text in VB6

The sample source codes on this page will demonstrate you how to make scanned PDF to text in VB6. ByteScout PDF Extractor SDK helps with scanned PDF to text in VB6. ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. This basic programming language sample code for VB6 will do the whole work for you in implementing scanned PDF to text in your app.

ByteScout PDF Extractor SDK free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




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