## How to draw barcode to form hdc with barcode sdk in Visual Basic 6 with ByteScout Barcode Suite

### Step-by-step tutorial on how to draw barcode to form hdc with barcode sdk in Visual Basic 6

This sample source code below will display you how to draw barcode to form hdc with barcode sdk in Visual Basic 6. ByteScout Barcode Suite can draw barcode to form hdc with barcode sdk. It can be applied from Visual Basic 6. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

Want to save time? You will save a lot of time on writing and testing code as you may just take the Visual Basic 6 code from ByteScout Barcode Suite for draw barcode to form hdc with barcode sdk below and use it in your application. This Visual Basic 6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! If you want to use these Visual Basic 6 sample examples in one or many applications then they can be used easily.

You can download free trial version of ByteScout Barcode Suite from our website with this and other source code samples for Visual Basic 6.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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
   AutoRedraw      =   -1  'True
   Caption         =   "Form1"
   ClientHeight    =   4845
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9795
   LinkTopic       =   "Form1"
   ScaleHeight     =   4845
   ScaleWidth      =   9795
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

 ' IMPORTANT NOTE for this sample: click on Form1 in the Design mode and set "AutoRedraw" property to True to make all drawings visible
 
 Set bc = CreateObject("Bytescout.BarCode.Barcode")


 ' set symbology type
 bc.Symbology = 1 ' 1 = Code39

 ' set value to encode
 bc.Value = "012345"
  
 ' draw code 39 barcode to the form at (0,0)
 bc.DrawHDC hDC, 0, 0
  
 ' now drawing 2D Aztec barcode
 
 ' set symbology type
 bc.Symbology = 17 ' 17 = Aztec
 ' set value to encode
 bc.Value = "012345"

' draw 2D Aztec barcode to the form at (0,200)
 bc.DrawHDC hDC, 0, 200

 Set bc = Nothing

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