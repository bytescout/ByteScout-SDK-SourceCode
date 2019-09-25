## How to get PDF page width and height in VB6 with ByteScout PDF To HTML SDK

### The tutorial below will demonstrate how to get PDF page width and height in VB6

The sample shows steps and algorithm of how to get PDF page width and height and how to make it work in your VB6 application. ByteScout PDF To HTML SDK: the SDK that can take PDF and generate HTML version of it with all the visual layout, positions, vectors, images and form fields preserved. Generated HTML requires no special software and can be viewed in any Internet browser. It can get PDF page width and height in VB6.

This rich sample source code in VB6 for ByteScout PDF To HTML SDK includes the number of functions and options you should do calling the API to get PDF page width and height. Just copy and paste the code into your VB6 application’s code and follow the instruction. You can use these VB6 sample examples in one or many applications.

Download free trial version of ByteScout PDF To HTML SDK from our website with this and other source code samples for VB6.

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
   Caption         =   "GetPageWidthAndHeight"
   ClientHeight    =   1320
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   4440
   LinkTopic       =   "Form1"
   ScaleHeight     =   1320
   ScaleWidth      =   4440
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_get_page_width_and_height 
      Caption         =   "Get Page Width And Height"
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
Private Sub cmd_get_page_width_and_height_Click()

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

		' read width and height of page #0 from PDF 
		' and show default output width and calculated page height
		MsgBox "Page #0" & vbCRLF & "Page height = " & CStr(extractor.GetPageHeight(0)) & vbCRLF & "Page width = " & CStr(extractor.GetPageWidth(0)) & vbCRLF & "Output width =" & CStr(extractor.OutputPageWidth) & vbCRLF & "Output Page Height = " & CStr(extractor.GetOutputHTMLPageHeight(0))
        
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

##### ****GetPageWidthAndHeight.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#..\..\..\..\..\..\..\..\..\Windows\SysWOW64\stdole2.tlb#OLE Automation
Reference=*\G{3D7BFCBE-A112-4953-B4B0-83647F86C919}#9.1#0#..\..\..\..\..\..\..\..\..\WINDOWS\SYSWOW64\Bytescout.PDF2HTML.tlb#ByteScout PDF To HTML SDK [TRIAL]
Form=Form1.frm
Startup="Form1"
Command32=""
Name="GetPageWidthAndHeight"
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