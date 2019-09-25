## How to convert pdf to xml with pdf extractor sdk in Visual Basic 6 using ByteScout Data Extraction Suite

### How to write a robust code in Visual Basic 6 to convert pdf to xml with pdf extractor sdk with this step-by-step tutorial

The documentation is designed for a specific purpose to help you to apply the features on your side. What is ByteScout Data Extraction Suite? It is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to convert pdf to xml with pdf extractor sdk in your Visual Basic 6 application.

Want to save time? You will save a lot of time on writing and testing code as you may just take the Visual Basic 6 code from ByteScout Data Extraction Suite for convert pdf to xml with pdf extractor sdk below and use it in your application. Follow the instructions from scratch to work and copy the Visual Basic 6 code. Further improvement of the code will make it more robust.

Trial version of ByteScout Data Extraction Suite is available for free. Source code samples are included to help you with your Visual Basic 6 app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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
   Caption         =   "PDF to XML"
   ClientHeight    =   1095
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   3675
   LinkTopic       =   "Form1"
   ScaleHeight     =   1095
   ScaleWidth      =   3675
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_pdf_to_xml 
      Caption         =   "Convert PDF to XML"
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
Private Sub cmd_pdf_to_xml_Click()
    
    ' Hanlde Error
    On Error GoTo ErrorHandler:
    
    ' Create Bytescout.PDFExtractor.XMLExtractor object
    Set extractor = CreateObject("Bytescout.PDFExtractor.XMLExtractor")
    
    ' Set Registration name and key
    extractor.RegistrationName = "demo"
    extractor.RegistrationKey = "demo"
  
    ' Load sample PDF document
    extractor.LoadDocumentFromFile "sample.pdf"
    
    ' Peform Save to XML file
    extractor.SaveXMLToFile "output.xml"
    
    ' Show Success Message
    MsgBox "Extracted data saved to 'output.xml' file.", vbInformation, "Success"
    
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

##### ****PDF_To_XML.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\..\..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{F1D62CEE-68AA-4F38-9DB0-8021C13255D8}#9.1#0#..\..\..\..\..\..\..\..\..\WINDOWS\SYSWOW64\Bytescout.PDFRenderer.tlb#ByteScout PDF Renderer SDK [TRIAL]
Form=Form1.frm
Startup="Form1"
Command32=""
Name="PDFToXML"
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