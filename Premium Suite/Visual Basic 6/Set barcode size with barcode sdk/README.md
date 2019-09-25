## How to set barcode size with barcode sdk in Visual Basic 6 and ByteScout Premium Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to set barcode size with barcode sdk in Visual Basic 6

These sample source codes on this page below are displaying how to set barcode size with barcode sdk in Visual Basic 6. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can set barcode size with barcode sdk in Visual Basic 6.

 These Visual Basic 6 code samples for Visual Basic 6 guide developers to speed up coding of the application when using ByteScout Premium Suite. IF you want to implement the functionality, just copy and paste this code for Visual Basic 6 below into your code editor with your app, compile and run your application. Check Visual Basic 6 sample code samples to see if they respond to your needs and requirements for the project.

You can download free trial version of ByteScout Premium Suite from our website to see and try many others source code samples for Visual Basic 6.

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

' this method prints a barcode via temporary EMF metafile allowing to set target physical size and DPI resolution quality

Const DPIQuality = 300 ' 300 DPI as printing resolution (DPI) quality
Const WidthInInches = 4 ' 4 inches as width for the barcode generated
Const HeightInInches = 1 ' 1 inches as height for the barcode generated

 ' create barcode object as ActiveX
 Dim BC
 Set BC = CreateObject("Bytescout.BarCode.Barcode")

 Printer.PrintQuality = DPIQuality ' set the printer quality to 300 dpi

 ' IMPORTANT: call Printer.Print Space(1) to initialize the Printer
 ' this is how Microsoft advises to do in their KB article (search for Printer.Print string): http://support.microsoft.com/kb/146022
 Printer.Print Space(1) ' initialize hDC of Printer object
 
 ' set the same DPI resolution (300 DPI) to generate barcode image
 BC.ResolutionX = DPIQuality
 BC.ResolutionY = DPIQuality
 
 ' set barcode symbology type
 BC.Symbology = 0 ' Code 39 = 0 (see the documentation for other barcode types)
 
 ' set barcode value
 BC.Value = "1234567890"
 
 
 ' use .FitInto_3 method to set the size in inches (you can also set in mm, cm, pixels - see the documentation for more)
 BC.FitInto_3 WidthInInches, HeightInInches, 2 ' fit into 3.5x0.875 inches (2 = inch)
  
' save barcode into temprorary EMF image

' create FileSystemObject to work with files
Dim FSO As Object
Set FSO = CreateObject("Scripting.filesystemobject")

' get temporary filename to save a temporary .EMF file
Dim tempEMFFileName
tempEMFFileName = FSO.GetTempName() & ".EMF"

' save EMF metafile into the temporary file
BC.SaveImage tempEMFFileName

' now we paint EMF file to Printer object
' default units for Printer in VB6 is Twips, which is 1440 per Inch
' so we calculate 3.5 inches as 3.5 * TwipsPerInch
Const TwipsPerInch = 1440
' now printing the picture at 0,0 with 3.5 inches X 0.875 inches
Printer.PaintPicture LoadPicture(tempEMFFileName), 0, 200, 3.5 * TwipsPerInch, 0.875 * TwipsPerInch

' now remove temporary EMF file
FSO.deletefile tempEMFFileName, True
Set FSO = Nothing
 
 ' finally send command to print the page
Printer.EndDoc
 
Set BC = Nothing



End Sub

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Project1.vbp:**
    
```
Type=Exe
Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#C:\WINDOWS\system32\stdole2.tlb#OLE Automation
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