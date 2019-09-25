## How to convert PDF to HTML (complex layout) in VB6 using ByteScout PDF To HTML SDK

### The tutorial below will demonstrate how to convert PDF to HTML (complex layout) in VB6

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout PDF To HTML SDK: the PDF to HTML converter with visual layout, positions, vectors, images and form fields. Generated HTML can be viewed using browser without PDF reader. It can convert PDF to HTML (complex layout) in VB6.

Fast application programming interfaces of ByteScout PDF To HTML SDK for VB6 plus the instruction and the code below will help you quickly learn how to convert PDF to HTML (complex layout). In order to implement the functionality, you should copy and paste this code for VB6 below into your code editor with your app, compile and run your application. You can use these VB6 sample examples in one or many applications.

Trial version of ByteScout PDF To HTML SDK is available for free. Source code samples are included to help you with your VB6 app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20To%20HTML%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20To%20HTML%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=kB2ELm_kCds](https://www.youtube.com/watch?v=kB2ELm_kCds)




<!-- code block begin -->

##### ****Form1.frm:**
    
```
VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "PDFtoHTMLWithLayout"
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

        ' Set HTML with CSS extraction mode
        extractor.ExtractionMode = 1

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

        ' Set HTML with CSS extraction mode
        extractor.ExtractionMode = 1

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

##### ****PDFtoHTMLWithLayout.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\..\..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{3D7BFCBE-A112-4953-B4B0-83647F86C919}#9.1#0#..\..\..\..\..\..\..\..\..\WINDOWS\SYSWOW64\Bytescout.PDF2HTML.tlb#ByteScout PDF To HTML SDK [TRIAL]
Form=Form1.frm
Startup="Form1"
Command32=""
Name="PDFtoHTMLWithLayout"
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