## How to read barcodes from folder in Microsoft Excel with ByteScout BarCode Reader SDK

### If you want to learn more then this tutorial will show how to read barcodes from folder in Microsoft Excel

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. What is ByteScout BarCode Reader SDK? It is the SDK for barcode decoding. Can read all popular types from Code 128, GS1, UPC and Code 39 to QR Code, Datamatrix, PDF417. Images, pdf, TIF images and live web camera are supported as input. Designed to handle documents with noise and defects. Includes optional splitter and merger for pdf and tiff based on barcodes. Batch mode is optimized for high performance with multiple threads. Decoded values can be exported to XML, JSON, CSV or into custom data format. It can help you to read barcodes from folder in your Microsoft Excel application.

The SDK samples given below describe how to quickly make your application do read barcodes from folder in Microsoft Excel with the help of ByteScout BarCode Reader SDK. Follow the instructions from scratch to work and copy the Microsoft Excel code. Complete and detailed tutorials and documentation are available along with installed ByteScout BarCode Reader SDK if you'd like to learn more about the topic and the details of the API.

If you want to try other source code samples then the free trial version of ByteScout BarCode Reader SDK is available for download from our website. Just try other source code samples for Microsoft Excel.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




<!-- code block begin -->

##### ****BarcodeReaderCode_VB.txt:**
    
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
'Bytescout Barcode Reader SDK
'
' IMPORTANT:
' ==============================================================
'1) Add the ActiveX reference in Tools -> References
'2) Enter path of folder containing barcode files's value into text box
'3) Get All files into that folder and iterage through it
'4) Read all barcodes into each file and write all values into cells
'==================================================================

Option Explicit


Sub Barcode_Click()

'Fetch the Worksheet
Dim mySheet As Worksheet
Set mySheet = Worksheets(1)     'Barcode_Data Sheet


' Set Initial Value
mySheet.Range("A2").Value = "Barcode Value"
mySheet.Range("B2").Value = "File Name"

Dim InputFolder As String

InputFolder = mySheet.OLEObjects("TextBox1").Object.Value

' Set cell index value
Dim CellIndex As Integer
CellIndex = 2

If InputFolder = "" Then
    MsgBox "Input Folder value is empty"
Else
    Call ProcessFolder(InputFolder, mySheet, CellIndex)
End If

End Sub

 
Sub ProcessFolder(ByVal folderPath As String, ByRef mySheet As Worksheet, ByRef CellIndex As Integer)
    
    Dim Reader As New Bytescout_BarCodeReader.Reader
    Set Reader = CreateObject("Bytescout.BarCodeReader.Reader")
    
    ' Set multiple barcode types for searching
    Reader.BarcodeTypesToFind.Code39 = True
    Reader.BarcodeTypesToFind.QRCode = True
    Reader.BarcodeTypesToFind.PDF417 = True
    Reader.BarcodeTypesToFind.EAN13 = True
    
    ' define allowed input images extensions
    Dim inputImagesExtensions As String
    inputImagesExtensions = "JPG,JPEG,PNG,BMP,PDF,TIF"

    Dim objFSO
    Set objFSO = CreateObject("Scripting.FileSystemObject")

    Dim objFolder
    Set objFolder = objFSO.GetFolder(folderPath)
    
    Dim colFiles
    Set colFiles = objFolder.Files
    
    If colFiles.Count = 0 Then
        MsgBox "Entered Folder contains no files"
    Else
    
        Dim objFile
        For Each objFile In colFiles
    
            ' Check the file type
            If InStr(inputImagesExtensions, UCase(objFSO.GetExtensionName(objFile.Name))) > 0 Then
                Reader.ReadFromFile objFile.Path
    
                Dim i
                For i = 0 To Reader.FoundCount - 1
                    ' Get cell value
                    CellIndex = (CellIndex + 1)
                    
                    mySheet.Range("A" + CStr(CellIndex)).Value = Reader.GetFoundBarcodeValue(i)
                    mySheet.Range("B" + CStr(CellIndex)).Value = objFile.Name
                Next
            End If
        Next
    
        Dim subFolder
        For Each subFolder In objFolder.SubFolders
            ProcessFolder subFolder, mySheet, CellIndex
        Next
    
    End If

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