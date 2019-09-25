## How to save barcode to emf images with barcode sdk in Visual Basic 6 with ByteScout Barcode Suite

### How to write a robust code in Visual Basic 6 to save barcode to emf images with barcode sdk with this step-by-step tutorial

The sample shows instructions and algorithm of how to save barcode to emf images with barcode sdk and how to make it run in your Visual Basic 6 application. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK) and you can use it to save barcode to emf images with barcode sdk with Visual Basic 6.

 These Visual Basic 6 code samples for Visual Basic 6 guide developers to speed up coding of the application when using ByteScout Barcode Suite.  Simply copy and paste in your Visual Basic 6 project or application you and then run your app! Check Visual Basic 6 sample code samples to see if they respond to your needs and requirements for the project.

ByteScout provides the free trial version of ByteScout Barcode Suite along with the documentation and source code samples.

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

 MsgBox "Saving Code39 barcode to 'Code39.emf'"

 bc.SaveImage "Code39.emf" ' change to "c:\Code39.emf" if you can not locate the file. The default directory is the folder where Project1.exe is located

 MsgBox "Encoding '012345' using Aztec symbology"

 ' set symbology type
 bc.Symbology = 17 ' 17 = Aztec
' set value to encode
 bc.Value = "012345"

 ' display information about Aztec symbology
 MsgBox "Encoding '012345' using Aztec  symbology" & vbCrLf & bc.GetValueRestrictions(17) ' 17 = Code39 symbology

 bc.SaveImage "Aztec.emf" ' change to "c:\Aztec.emf" if you can not locate the file. The default directory is the folder where Project1.exe is located

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