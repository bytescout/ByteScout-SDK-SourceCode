## How to split pdf with pdf extractor sdk in Visual Basic 6 with ByteScout Premium Suite

### Learn to code in Visual Basic 6 to split pdf with pdf extractor sdk with this step-by-step tutorial

An easy to understand guide on how to split pdf with pdf extractor sdk in Visual Basic 6 with this source code sample. What is ByteScout Premium Suite? It is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to split pdf with pdf extractor sdk in your Visual Basic 6 application.

The following code snippet for ByteScout Premium Suite works best when you need to quickly split pdf with pdf extractor sdk in your Visual Basic 6 application. IF you want to implement the functionality, just copy and paste this code for Visual Basic 6 below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in Visual Basic 6.

Trial version of ByteScout Premium Suite is available for free. Source code samples are included to help you with your Visual Basic 6 app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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
   Caption         =   "Split PDF"
   ClientHeight    =   1095
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   3675
   LinkTopic       =   "Form1"
   ScaleHeight     =   1095
   ScaleWidth      =   3675
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_split_pdf 
      Caption         =   "Split PDF"
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
Private Sub cmd_split_pdf_Click()
    
    ' Hanlde Error
    On Error GoTo ErrorHandler:
    
    ' Create Bytescout.PDFExtractor.DocumentSplitter object
    Set splitter = CreateObject("Bytescout.PDFExtractor.DocumentSplitter")
    
    ' Set Registration name and key
    splitter.RegistrationName = "demo"
    splitter.RegistrationKey = "demo"
  
    ' Set input file
    inputFile = "sample.pdf"
    
    ' Enable splitting parts optimization (remove unused resources)
    splitter.OptimizeSplittedDocuments = True
    
    ' Extract a single page:
    ' ======================
    splitter.ExtractPage inputFile, "page3.pdf", 3 ' (!) Note: page number is 1-based.
    
    MsgBox "Extracted page #3 to file 'page3.pdf'.", vbInformation, "Success"


    ' Split in two parts:
    ' ===================
    
    splitter.Split inputFile, "part1.pdf", "part2.pdf", 3 ' (!) Note: page number is 1-based.
    
    MsgBox "Splitted at page #3 to files 'part1.pdf' and 'part2.pdf'.", vbInformation, "Success"
    
    
    ' Split by ranges:
    ' ================
    
    ' SplitCOM() returns array with file names. Files are saved to the system temporary directory.
    Dim outFiles
    outFiles = splitter.SplitCOM(inputFile, "1-3,4-") ' (!) Note: page numbers are 1-based; the ending "-" means "to the end".
    
    Dim fileNames
    For Each of In outFiles
        fileNames = fileNames & of & vbCrLf
    Next
    
    MsgBox "Splitted by ranges to files: " & vbCrLf & fileNames, vbInformation, "Success"
        
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

##### ****Split_PDF.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\..\..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{F1D62CEE-68AA-4F38-9DB0-8021C13255D8}#9.1#0#..\..\..\..\..\..\..\..\..\WINDOWS\SYSWOW64\Bytescout.PDFRenderer.tlb#ByteScout PDF Renderer SDK [TRIAL]
Form=Form1.frm
Startup="Form1"
Command32=""
Name="SplitPDF"
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