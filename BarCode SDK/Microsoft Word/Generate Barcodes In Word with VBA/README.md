## How to generate barcodes in word with VBA in Microsoft Word using ByteScout Barcode SDK

### Write code in Microsoft Word to generate barcodes in word with VBA with this step-by-step tutorial

Learn how to generate barcodes in word with VBA in Microsoft Word with this source code sample. ByteScout Barcode SDK is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images and you can use it to generate barcodes in word with VBA with Microsoft Word.

You will save a lot of time on writing and testing code as you may just take the Microsoft Word code from ByteScout Barcode SDK for generate barcodes in word with VBA below and use it in your application. In your Microsoft Word project or application you may simply copy & paste the code and then run your app! This basic programming language sample code for Microsoft Word will do the whole work for you to generate barcodes in word with VBA.

Download free trial version of ByteScout Barcode SDK from our website with this and other source code samples for Microsoft Word.

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

##### ****BytescoutBarCodeSDK_VBA.vb:**
    
```
' IMPORTANT: This demo uses VBA so if you have it disabled please temporary enable
' by going to Tools - Macro - Security.. and changing the security mode to ""Medium""
' to Ask if you want enable macro or not. Then close and reopen this Excel document

' You should have evaluation version of the ByteScout SDK installed to get it working - get it from https://bytescout.com

' If you are getting error message like
' "File or assembly named Bytescout SDK, or one of its dependencies, was not found"
' then please try the following:
'
' - Close Excel
' - (for Office 2003 only) download and install this hotfix from Microsoft:
' http://www.microsoft.com/downloads/details.aspx?FamilyId=1B0BFB35-C252-43CC-8A2A-6A64D6AC4670&displaylang=en
'
' and then try again!
'
' If you have any questions please contact us at http://bytescout.com/support/ or at support@bytescout.com
                            


'==============================================
'References used
'=================
'Bytescout Barcode SDK
'
' IMPORTANT:
' ==============================================================
'1) Add the ActiveX reference in Tools -> References
'2) Loop through the values from the first Column for which barcode has to be generated
'3) Parse the value to Bytescout Barcode Object to generate the barcode using QR Code barcode type.
'4) Save the generated Barcode Image
'5) Insert the Barcode Image in the second Column
'6) Repeat the steps 3 to 5 till the last Value in the first Column
'
'==================================================================
Option Explicit

' declare function to get temporary folder (where we could save barcode images temporary)
Declare Function GetTempPath _
Lib "kernel32" Alias "GetTempPathA" _
(ByVal nBufferLength As Long, _
ByVal lpBuffer As String) As Long
 
Dim myTable As Table
Dim myRow As Integer
Dim myCell As Range
 
' function to return path to temporary folder
Public Function fncGetTempPath() As String
    Dim PathLen As Long
    Dim WinTempDir As String
    Dim BufferLength As Long
    BufferLength = 260
    WinTempDir = Space(BufferLength)
    PathLen = GetTempPath(BufferLength, WinTempDir)
    If Not PathLen = 0 Then
        fncGetTempPath = Left(WinTempDir, PathLen)
    Else
        fncGetTempPath = CurDir()
    End If
End Function

Sub Generate_Barcode()
'temp path to save the Barcode images
Dim filePath As String
filePath = fncGetTempPath()            'Change the Path But should end with Backslash( \ )

Set myTable = ActiveDocument.Tables.Item(1)

'Prepare the Bytescout Barcode Object
'====================================
Dim myBarcode As New Bytescout_BarCode.Barcode

myBarcode.RegistrationName = "demo"         'Change the name for full version
myBarcode.RegistrationKey = "demo"          'Change the key for full version

'Barcode Settings
myBarcode.Symbology = SymbologyType_QRCode  ' QR Code barcode, you may change to other barcode types like Code 39, Code 128 etc

' set barcode image quality resolution
myBarcode.ResolutionX = 300                 'Resolution higher than 250 is good for printing
myBarcode.ResolutionY = 300                 'Resolution higher than 250 is good for printing

myBarcode.DrawCaption = True                'Showing Barcode Captions in the Barcode Image
myBarcode.DrawCaptionFor2DBarcodes = True   ' show captions for 2D barcodes like QR Code

'Remove the Old Barcode images (if any)
Clear_Barcode

' now generate new barcodes and insert into cells in the second column
' Repeat the steps for each row from 2 to 6

For myRow = 2 To 6
    Set myCell = myTable.Cell(myRow, 1).Range
    'Parse the Value from the first Column to Bytescout Barcode Object
    myBarcode.Value = myCell.Text
    'Fit the barcode into 60X25 mm rectangle
    myBarcode.FitInto_3 60, 25, 4           '4 refers to units of measurement as millimeter
    'Save the barcode image to a file in temporary folder
    myBarcode.SaveImage filePath & "myBarcode" & myRow - 1 & ".png"

    'Insert the Barcode image to the second Column
    Set myCell = myTable.Cell(myRow, 2).Range
    myCell.InlineShapes.AddPicture filePath & "myBarcode" & myRow - 1 & ".png"
Next myRow


End Sub

' clears barcodes images (if any) from the column
Sub Clear_Barcode()
Set myTable = ActiveDocument.Tables.Item(1)

'Remove the Old Barcode images (if any)
For myRow = 2 To 6
    Set myCell = myTable.Cell(myRow, 2).Range
    If myCell.InlineShapes.Count = 1 Then myCell.InlineShapes.Item(1).Delete
Next myRow


End Sub


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Reference Error - README.txt:**
    
```
' IMPORTANT: This demo uses VBA so if you have it disabled please temporary enable
' by going to Tools - Macro - Security.. and changing the security mode to ""Medium""
' to Ask if you want enable macro or not. Then close and reopen this Excel document

' You should have evaluation version of the ByteScout SDK installed to get it working - get it from https://bytescout.com

' If you are getting error message like
' "File or assembly named Bytescout SDK, or one of its dependencies, was not found"
' then please try the following:
'
' - Close Excel
' - (for Office 2003 only) download and install this hotfix from Microsoft:
' http://www.microsoft.com/downloads/details.aspx?FamilyId=1B0BFB35-C252-43CC-8A2A-6A64D6AC4670&displaylang=en
'
' and then try again!
'
' If you have any questions please contact us at http://bytescout.com/support/ or at support@bytescout.com
                            



```

<!-- code block end -->