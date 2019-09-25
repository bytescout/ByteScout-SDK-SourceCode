## How to save barcode to png images with barcode sdk in Visual Basic 6 using ByteScout Barcode Suite

### Learn to save barcode to png images with barcode sdk in Visual Basic 6

This sample source code below will display you how to save barcode to png images with barcode sdk in Visual Basic 6. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can be applied to save barcode to png images with barcode sdk using Visual Basic 6.

This prolific sample source code in Visual Basic 6 for ByteScout Barcode Suite contains various functions and other necessary options you should do calling the API to save barcode to png images with barcode sdk. This Visual Basic 6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Our website gives trial version of ByteScout Barcode Suite for free. It also includes documentation and source code samples.

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
   Caption         =   "Form1"
   ClientHeight    =   2400
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   3750
   LinkTopic       =   "Form1"
   ScaleHeight     =   2400
   ScaleWidth      =   3750
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()


 Set bc = CreateObject("Bytescout.BarCode.Barcode")

 ' display information about Code39 symbology
 MsgBox "Encoding '012345' using Code39 symbology" & vbCrLf & bc.GetValueRestrictions(0)  ' 0 = Code39 symbology

 ' set symbology type
 bc.Symbology = 1 ' 1 = Code39

 ' set value to encode
 bc.Value = "012345"

 MsgBox "Saving Code39 barcode to 'Code39.png'"

 bc.SaveImage "Code39.png" ' change to "c:\Code39.png" if you can not locate the file. The default directory is the folder where Project1.exe is located

 MsgBox "Encoding '012345' using Aztec symbology"

 ' set symbology type
 bc.Symbology = 17 ' 17 = Aztec
' set value to encode
 bc.Value = "012345"

 ' display information about Aztec symbology
 MsgBox "Encoding '012345' using Aztec  symbology" & vbCrLf & bc.GetValueRestrictions(17) ' 17 = Code39 symbology

 bc.SaveImage "Aztec.png" ' change to "c:\Aztec.png" if you can not locate the file. The default directory is the folder where Project1.exe is located

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