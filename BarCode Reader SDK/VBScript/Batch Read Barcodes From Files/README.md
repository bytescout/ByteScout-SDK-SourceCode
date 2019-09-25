## How to batch read barcodes from files in VBScript using ByteScout BarCode Reader SDK

### How to batch read barcodes from files in VBScript

The code below will help you to implement an VBScript app to batch read barcodes from files. What is ByteScout BarCode Reader SDK? It is the SDK for reading of barcodes from PDF, images and live camera or video. Almost every common type like Code 39, Code 128, GS1, UPC, QR Code, Datamatrix, PDF417 and many others are supported. Supports noisy and defective images and docs. Includes optional documents splitter and merger for pdf and tiff based on found barcodess. Batch mode is supported for superior performance using multiple threads. Decoded values are easily exported to JSON, CSV, XML and to custom format. It can help you to batch read barcodes from files in your VBScript application.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout BarCode Reader SDK for batch read barcodes from files below and use it in your application. Follow the instructions from the scratch to work and copy the VBScript code. Test VBScript sample code examples whether they respond your needs and requirements for the project.

You can download free trial version of ByteScout BarCode Reader SDK from our website to see and try many others source code samples for VBScript.

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