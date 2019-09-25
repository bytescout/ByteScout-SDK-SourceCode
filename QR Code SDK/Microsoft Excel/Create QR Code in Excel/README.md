## How to create QR code in excel in Microsoft Excel and ByteScout QR Code

### Step-by-step tutorial on how to create QR code in excel in Microsoft Excel

The sample source codes on this page shows how to create QR code in excel in Microsoft Excel. ByteScout QR Code: QR Code barcode generator SDK with tunnable quality and features like QR Code embedded logo or images. Supports batch generation and specialized features like encoding of vCard and other structures inside QR Code barcodes. It can create QR code in excel in Microsoft Excel.

Want to save time? You will save a lot of time on writing and testing code as you may just take the Microsoft Excel code from ByteScout QR Code for create QR code in excel below and use it in your application. This Microsoft Excel sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Check Microsoft Excel sample code samples to see if they respond to your needs and requirements for the project.

If you want to try other source code samples then the free trial version of ByteScout QR Code is available for download from our website. Just try other source code samples for Microsoft Excel.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20QR%20Code%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20QR%20Code%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=A5hB9ul3tX0](https://www.youtube.com/watch?v=A5hB9ul3tX0)




<!-- code block begin -->

##### ****QRCodeGeneration_VBA.txt:**
    
```
' IMPORTANT: This demo uses VBA so if you have it disabled please temporary enable
' by going to Tools - Macro - Security.. and changing the security mode to ""Medium""
' to Ask if you want enable macro or not. Then close and reopen this Excel document

' You should have evaluation version of the ByteScout QRCode SDK installed to get it working - get it from https://bytescout.com

'==============================================
'References used
'=================
'ByteScout QRCode SDK
'
' IMPORTANT:
' ==============================================================
'1) Add "ByteScout QRCode SDK" reference in Tools -> References
'2) Loop through the values from the Column A for which barcode has to be generated
'3) Parse the value to barcode object to generate the barcode.
'4) Save the generated barcode image.
'5) Insert the barcode image in the column B.
'6) Repeat the steps 3 to 5 till the last value in column A
'
'==================================================================

Option Explicit

' declare function to get temporary folder (where we could save barcode images temporary)
Declare Function GetTempPath _
Lib "kernel32" Alias "GetTempPathA" _
(ByVal nBufferLength As Long, _
ByVal lpBuffer As String) As Long
 
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


Sub Barcode_Click()

'Fetch the Worksheet
Dim mySheet As Worksheet
Set mySheet = Worksheets(1)                 'Barcode_Data Sheet

'temp path to save the Barcode images
Dim filePath As String
filePath = fncGetTempPath()            'Change the Path But should end with Backslash( \ )

'Prepare the ByteScout QRCode object
'====================================
Dim myBarcode As New Bytescout_BarCode_QRCode.QRCode
myBarcode.RegistrationName = "demo"         'Change the name for full version
myBarcode.RegistrationKey = "demo"          'Change the key for full version

myBarcode.DrawCaption = True                'Showing Barcode Captions in the Barcode Image

' first clean the B column from old images (if any)
Dim Sh As Shape
With mySheet
   For Each Sh In .Shapes
       If Not Application.Intersect(Sh.TopLeftCell, .Range("B1:B50")) Is Nothing Then
         If Sh.Type = msoPicture Then Sh.Delete
       End If
    Next Sh
End With

' now generate new barcodes and insert into cells in the column B
' Repeat the steps for each row from 2 to 6
Dim myVal As Integer

For myVal = 2 To 6                          'change the code to all rows with values
    'Parse the Value from the Column A to Bytescout Barcode Object
    myBarcode.Value = mySheet.Cells(myVal, 1).Text
    'Save the barcode image to a file in temporary folder
    myBarcode.SaveImage filePath & "myBarcode" & myVal & ".png"
    
    'Insert the Barcode image to the Column B and resize them to fit the cell.
    '==========================================================================
    With mySheet.Pictures.Insert(filePath & "myBarcode" & myVal & ".png")
        .ShapeRange.LockAspectRatio = True ' lock aspect ratio
        .Left = mySheet.Cells(myVal, 2).Left + 1 ' set left
        .Top = mySheet.Cells(myVal, 2).Top + 1 ' set right
        .PrintObject = True ' allow printing this object
        .Placement = xlMove ' set placement mode to move but do not resize with the cell
        .ShapeRange.ScaleHeight 1, True ' set height scale to 1 (no scale)
        .ShapeRange.ScaleWidth 1, True ' set width scale to 1 (no scale)
    End With
    
    
Next myVal ' move to next cell in the column

' Release the Barcode Object.
Set myBarcode = Nothing

End Sub

```

<!-- code block end -->