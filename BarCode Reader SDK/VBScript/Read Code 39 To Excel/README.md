## How to read code 39 to excel in VBScript and ByteScout BarCode Reader SDK

### How to code in VBScript to read code 39 to excel with this step-by-step tutorial

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout BarCode Reader SDK can read code 39 to excel. It can be used from VBScript. ByteScout BarCode Reader SDK is the SDK for reading of barcodes from PDF, images and live camera or video. Almost every common type like Code 39, Code 128, GS1, UPC, QR Code, Datamatrix, PDF417 and many others are supported. Supports noisy and defective images and docs. Includes optional documents splitter and merger for pdf and tiff based on found barcodess. Batch mode is supported for superior performance using multiple threads. Decoded values are easily exported to JSON, CSV, XML and to custom format.

Fast application programming interfaces of ByteScout BarCode Reader SDK for VBScript plus the instruction and the code below will help you quickly learn how to read code 39 to excel. Follow the instructions from the scratch to work and copy the VBScript code. This basic programming language sample code for VBScript will do the whole work for you to read code 39 to excel.

Download free trial version of ByteScout BarCode Reader SDK from our website with this and other source code samples for VBScript.

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

##### ****Code39BarcodeToExcel.vbs:**
    
```
if WScript.Arguments.Count < 1 Then
 MsgBox "Run with the folder path as the argument" & vbCRLF & vbCRLF & "Code39BarcodeToExcel.vbs <InputFolder>"
 WScript.Quit 0
End If

Set objFSO = CreateObject("Scripting.FileSystemObject")

' define allowed input images extensions
inputImagesExtensions = "JPG,JPEG,PNG,BMP,PDF,TIF"

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

' Set Code39 barcode types for searching
reader.BarcodeTypesToFind.Code39 = True

' Set excel document
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

' Set document keys
document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("Code39")

' Set cell index value
Dim CellIndex
CellIndex = 0

' Set Initial Value
CellIndex = (CellIndex + 1) 
Set cell_value = worksheet.Cell_2("A" + Cstr(CellIndex))
Set cell_filename = worksheet.Cell_2("B" + Cstr(CellIndex))
cell_value.Value = "Barcode Value"
cell_filename.Value = "File Name"

Set objInputFolder = objFSO.GetFolder(WScript.Arguments(0))
Call ProcessFolder(objInputFolder)

' delete output file if exists already
Set fso = CreateObject("Scripting.FileSystemObject")
If (fso.FileExists("output.xls")) Then fso.DeleteFile("output.xls")
Set fso = nothing

' save document
document.SaveAs "output.xls"
WScript.Echo "successfully created 'output.xls' file!"

' close Spreadsheet
Set document = Nothing

WScript.Quit 0

Sub ProcessFolder(folder)

    Set objFolder = objFSO.GetFolder(folder.Path)
    Set colFiles = objFolder.Files
    
    For Each objFile in colFiles

        ' Check the file type
        If inStr(inputImagesExtensions, UCase(objFSO.GetExtensionName(objFile.Name))) > 0 Then
			reader.ReadFromFile objFile.Path

			For i = 0 To reader.FoundCount - 1
				' Get cell value
				CellIndex = (CellIndex + 1) 
				Set cell_value = worksheet.Cell_2("A" + Cstr(CellIndex))
				Set cell_filename = worksheet.Cell_2("B" + Cstr(CellIndex))

				' set cell value
				cell_value.Value = reader.GetFoundBarcodeValue(i)
				cell_filename.Value = objFile.Name
				
				' Write to console
				WScript.Echo "Extracted barcode '" & reader.GetFoundBarcodeValue(i) & "' from '"& objFile.Name &"' file"
			Next
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
cscript.exe Code39BarcodeToExcel.vbs "InputFiles"
pause
```

<!-- code block end -->