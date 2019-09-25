## How to convert pdf to html (simple layout) with pdf to html sdk in Visual Basic 6 using ByteScout Premium Suite

### How to write a robust code in Visual Basic 6 to convert pdf to html (simple layout) with pdf to html sdk with this step-by-step tutorial

On this page you will learn from code samples for programming in Visual Basic 6.Writing of the code to convert pdf to html (simple layout) with pdf to html sdk in Visual Basic 6 can be executed by programmers of any level using ByteScout Premium Suite. Want to convert pdf to html (simple layout) with pdf to html sdk in your Visual Basic 6 app? ByteScout Premium Suite is designed for it. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

The SDK samples given below describe how to quickly make your application do convert pdf to html (simple layout) with pdf to html sdk in Visual Basic 6 with the help of ByteScout Premium Suite.  Simply copy and paste in your Visual Basic 6 project or application you and then run your app! Further improvement of the code will make it more robust.

If you want to try other source code samples then the free trial version of ByteScout Premium Suite is available for download from our website. Just try other source code samples for Visual Basic 6.

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
   Caption         =   "PDFtoHTMLSimpleLayout"
   ClientHeight    =   1380
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   5595
   LinkTopic       =   "Form1"
   ScaleHeight     =   1380
   ScaleWidth      =   5595
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_PdftoHTML_2ndPage 
      Caption         =   "PDF to HTML (2nd page)"
      CausesValidation=   0   'False
      Height          =   855
      Left            =   2880
      TabIndex        =   1
      Top             =   240
      Width           =   2055
   End
   Begin VB.CommandButton cmd_PDFtoHTMLSimpleLayout 
      Caption         =   "PDF to HTML"
      CausesValidation=   0   'False
      Height          =   855
      Left            =   480
      TabIndex        =   0
      Top             =   240
      Width           =   2055
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub cmd_PDFtoHTMLSimpleLayout_Click()

    ' Hanlde Error
    On Error GoTo ErrorHandler:
        
        ' Create Bytescout.PDF2HTML.HTMLExtractor object
        Set extractor = CreateObject("Bytescout.PDF2HTML.HTMLExtractor")
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Set plain HTML extraction mode
        extractor.ExtractionMode = 0

        ' Load sample PDF document
        extractor.LoadDocumentFromFile ("sample2.pdf")

        ' Save extracted HTML to file
        extractor.SaveHtmlToFile_2 "output.html"
        
        MsgBox "PDF file successfully saved as 'output.html'.", vbInformation, "Success"

        ' Open output file in default associated application
        CreateObject("WScript.Shell").Run "output.html", 1, False

        Set extractor = Nothing

        ' Close form
        Unload Me

ErrorHandler:
    If Err.Number <> 0 Then
        MsgBox Err.Description, vbInformation, "Error"
    End If

End Sub

Private Sub cmd_PdftoHTML_2ndPage_Click()

    ' Hanlde Error
    On Error GoTo ErrorHandler:
        
        ' Create Bytescout.PDF2HTML.HTMLExtractor object
        Set extractor = CreateObject("Bytescout.PDF2HTML.HTMLExtractor")
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Set plain HTML extraction mode
        extractor.ExtractionMode = 0

        ' Load sample PDF document
        extractor.LoadDocumentFromFile ("sample2.pdf")

        ' Convert 2-nd page to HTML and save it to file
        extractor.SaveHtmlPageToFile 1, "output.html"
        
        MsgBox "PDF file (2nd page) successfully saved as 'output.html'.", vbInformation, "Success"

        ' Open output file in default associated application
        CreateObject("WScript.Shell").Run "output.html", 1, False

        Set extractor = Nothing

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

##### ****PDFtoHTMLSimpleLayout.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\..\..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{3D7BFCBE-A112-4953-B4B0-83647F86C919}#9.1#0#..\..\..\..\..\..\..\..\..\WINDOWS\SYSWOW64\Bytescout.PDF2HTML.tlb#ByteScout PDF To HTML SDK [TRIAL]
Form=Form1.frm
Startup="Form1"
Command32=""
Name="PDFtoHTMLSimpleLayout"
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