## How to create spreadsheet with spreadsheet sdk in Visual Basic 6 using ByteScout Data Extraction Suite

### If you want to learn more then this tutorial will show how to create spreadsheet with spreadsheet sdk in Visual Basic 6

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. What is ByteScout Data Extraction Suite? It is the set that includes 3 SDK products for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to create spreadsheet with spreadsheet sdk in your Visual Basic 6 application.

This prolific sample source code in Visual Basic 6 for ByteScout Data Extraction Suite contains various functions and other necessary options you should do calling the API to create spreadsheet with spreadsheet sdk. IF you want to implement the functionality, just copy and paste this code for Visual Basic 6 below into your code editor with your app, compile and run your application. Use of ByteScout Data Extraction Suite in Visual Basic 6 is also described in the documentation included along with the product.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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
   Caption         =   "Form1"
   ClientHeight    =   2400
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   3750
   LinkTopic       =   "Form1"
   ScaleHeight     =   2400
   ScaleWidth      =   3750
   StartUpPosition =   3  'Windows Default
   Begin VB.Label Label1 
      Caption         =   "See the Output.xls file in the same folder"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Left            =   360
      TabIndex        =   0
      Top             =   360
      Width           =   3015
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' get cell value
Set cell = worksheet.Item(0, 0) ' you can also use worksheet.Cell("A1") as well

' set cell value
cell.Value = "Hello, World!"

' delete output file if exists already
Set fso = CreateObject("Scripting.FileSystemObject")
If (fso.FileExists("Output.xls")) Then fso.DeleteFile ("Output.xls")
Set fso = Nothing

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing

End Sub

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Project1.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#C:\WINXP\system32\stdole2.tlb#OLE Automation
Form=Form1.frm
Startup="Form1"
ExeName32="Project1.exe"
Command32=""
Name="Project1"
HelpContextID="0"
CompatibleMode="0"
MajorVer=1
MinorVer=0
RevisionVer=0
AutoIncrementVer=0
ServerSupportFiles=0
VersionCompanyName="000"
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

[MS Transaction Server]
AutoRefresh=1

```

<!-- code block end -->