## How to convert PDF to CSV (merge multiline text to table cell) in VB6 and ByteScout PDF Extractor SDK

### The tutorial shows how to convert PDF to CSV (merge multiline text to table cell) in VB6

Sample source code below will show you how to cope with a difficult task like convert PDF to CSV (merge multiline text to table cell) in VB6. ByteScout PDF Extractor SDK: the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities. It can convert PDF to CSV (merge multiline text to table cell) in VB6.

The SDK samples like this one below explain how to quickly make your application do convert PDF to CSV (merge multiline text to table cell) in VB6 with the help of ByteScout PDF Extractor SDK. In order to implement the functionality, you should copy and paste this code for VB6 below into your code editor with your app, compile and run your application. You can use these VB6 sample examples in one or many applications.

You can download free trial version of ByteScout PDF Extractor SDK from our website to see and try many others source code samples for VB6.

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
   Caption         =   "PDF to CSV"
   ClientHeight    =   1095
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   3675
   LinkTopic       =   "Form1"
   ScaleHeight     =   1095
   ScaleWidth      =   3675
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_pdf_to_csv 
      Caption         =   "Convert PDF to CSV (Merge multiline text to single cell)"
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

Private Sub cmd_pdf_to_csv_Click()
    
    ' Hanlde Error
    On Error GoTo ErrorHandler:
    
    ' Create Bytescout.PDFExtractor.CSVExtractor object
    Set extractor = CreateObject("Bytescout.PDFExtractor.CSVExtractor")
    
    ' Set Registration name and key
    extractor.RegistrationName = "demo"
    extractor.RegistrationKey = "demo"
  
    ' Load sample PDF document
    extractor.LoadDocumentFromFile "sample3_multiline.pdf"
    
    ' For multiline cell join extracted cell text into single line
    extractor.LineGroupingMode = 1 'LineGroupingMode.GroupByRows
    extractor.Unwrap = True
    
    ' Peform Save to CSV file
    extractor.SaveCSVToFile "output.csv"
    
    ' Show Success Message
    MsgBox "Extracted data saved to 'output.csv' file.", vbInformation, "Success"
    
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

##### ****PDF_To_CSV_MergeMultilineTextToCell.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\..\..\..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{F1D62CEE-68AA-4F38-9DB0-8021C13255D8}#9.1#0#..\..\..\..\..\..\..\..\..\WINDOWS\SYSWOW64\Bytescout.PDFRenderer.tlb#ByteScout PDF Renderer SDK [TRIAL]
Form=Form1.frm
Startup="Form1"
Command32=""
Name="PDFToCSV"
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