## How to change PDF to HTML output page width in VB6 using ByteScout PDF To HTML SDK

### How to code in VB6 to change PDF to HTML output page width with this step-by-step tutorial

Source code documentation samples provide quick and easy way to add a required functionality into your application. What is ByteScout PDF To HTML SDK? It is the SDK for PDF to HTML conversin. Generates static HTML version of input PDF and reconstructs all visual layout, text positions, vector and raster drawings, images, and form elements. Generated HTML requires no special software and can be viewed in any Internet browser. It can help you to change PDF to HTML output page width in your VB6 application.

The SDK samples like this one below explain how to quickly make your application do change PDF to HTML output page width in VB6 with the help of ByteScout PDF To HTML SDK. Just copy and paste the code into your VB6 application’s code and follow the instruction. Use of ByteScout PDF To HTML SDK in VB6 is also explained in the documentation included along with the product.

You can download free trial version of ByteScout PDF To HTML SDK from our website to see and try many others source code samples for VB6.

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

##### ****ChangeOutputPageWidth.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\..\..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{3D7BFCBE-A112-4953-B4B0-83647F86C919}#9.1#0#..\..\..\..\..\..\..\..\..\WINDOWS\SYSWOW64\Bytescout.PDF2HTML.tlb#ByteScout PDF To HTML SDK [TRIAL]
Form=Form1.frm
Startup="Form1"
Command32=""
Name="ChangeOutputPageWidth"
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

<!-- code block begin -->

##### ****Form1.frm:**
    
```
VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "ChangeOutputPageWidth"
   ClientHeight    =   1320
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4440
   LinkTopic       =   "Form1"
   ScaleHeight     =   1320
   ScaleWidth      =   4440
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_change_output_pdf_width 
      Caption         =   "Change Output Page Width"
      Height          =   855
      Left            =   480
      TabIndex        =   0
      Top             =   240
      Width           =   3495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmd_change_output_pdf_width_Click()

    ' Hanlde Error
    On Error GoTo ErrorHandler:
        
        ' Create Bytescout.PDF2HTML.HTMLExtractor object
        Set extractor = CreateObject("Bytescout.PDF2HTML.HTMLExtractor")
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Set HTML with CSS extraction mode
        extractor.ExtractionMode = 1

        ' set output width to 200 pixels
        extractor.OutputPageWidth = 200
        
        ' Load sample PDF document
        extractor.LoadDocumentFromFile ("sample2.pdf")

        ' Save extracted HTML to file
        extractor.SaveHtmlToFile_2 "output.html"
        
        MsgBox "PDF file successfully saved as 'output.html'.", vbInformation, "Success"

        ' Open output file in default associated application
        CreateObject("WScript.Shell").Run "output.html", 1, False

        ' Close form
        Unload Me

ErrorHandler:
    If Err.Number <> 0 Then
        MsgBox Err.Description, vbInformation, "Error"
    End If

End Sub

```

<!-- code block end -->