## How to batch read barcodes from files with barcode reader sdk in VBScript with ByteScout Barcode Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to batch read barcodes from files with barcode reader sdk in VBScript

An easy to understand sample source code to learn how to batch read barcodes from files with barcode reader sdk in VBScript ByteScout Barcode Suite can batch read barcodes from files with barcode reader sdk. It can be applied from VBScript. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

This prolific sample source code in VBScript for ByteScout Barcode Suite contains various functions and other necessary options you should do calling the API to batch read barcodes from files with barcode reader sdk. Follow the instructions from scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample codes in VBScript.

ByteScout Barcode Suite free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****BatchReadFromFiles.vbs:**
    
```
if WScript.Arguments.Count < 2 Then
 MsgBox "Run with the folder path as the argument" & vbCRLF & vbCRLF & "BatchReadFromFiles.vbs <InputFolder> <OutputFolder>"
 WScript.Quit 0
End If

Set objFSO = CreateObject("Scripting.FileSystemObject")

' define allowed input images extensions
inputImagesExtensions = "JPG,JPEG,PNG,BMP,PDF,TIF"

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

' Set barcode types for searching
reader.BarcodeTypesToFind.Code39 = True
reader.BarcodeTypesToFind.QRCode = True
reader.BarcodeTypesToFind.PDF417 = True
reader.BarcodeTypesToFind.EAN13 = True

Set objInputFolder = objFSO.GetFolder(WScript.Arguments(0))
Set objResultsFile = objFSO.CreateTextFile(WScript.Arguments(1), True)

Call ProcessFolder(objInputFolder)

WScript.Quit 0

Sub ProcessFolder(folder)

    Set objFolder = objFSO.GetFolder(folder.Path)
    Set colFiles = objFolder.Files
    
    For Each objFile in colFiles

        ' Check the file type
        If inStr(inputImagesExtensions, UCase(objFSO.GetExtensionName(objFile.Name))) > 0 Then

        ' Read barcode from file
        WScript.Echo "Reading from: " & objFile.Path
        reader.ReadFromFile objFile.Path 

        Dim csv 
        csv = reader.ExportFoundBarcodesToCSV_4
        objResultsFile.Write csv
        
        End If
    Next

    For Each subFolder in folder.SubFolders
        ProcessFolder subFolder
    Next
End Sub


```

<!-- code block end -->    

<!-- code block begin -->

##### ****run.bat:**
    
```
REM running from the command line
cscript.exe BatchReadFromFiles.vbs "input" "results.csv"
pause
```

<!-- code block end -->