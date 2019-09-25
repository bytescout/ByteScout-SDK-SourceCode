## How to save barcode to EMF images in Visual Basic 6 and ByteScout Barcode SDK

### This code in Visual Basic 6 shows how to save barcode to EMF images with this how to tutorial

Save barcode to EMF images is easy to implement in Visual Basic 6 if you use these source codes below. ByteScout Barcode SDK: the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images. It can save barcode to EMF images in Visual Basic 6.

You will save a lot of time on writing and testing code as you may just take the Visual Basic 6 code from ByteScout Barcode SDK for save barcode to EMF images below and use it in your application. Follow the instructions from the scratch to work and copy the Visual Basic 6 code. Further enhancement of the code will make it more vigorous.

ByteScout Barcode SDK free trial version is available on our website. Visual Basic 6 and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




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