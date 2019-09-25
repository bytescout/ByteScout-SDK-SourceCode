## barcodes to excel with barcode reader sdk in VBScript and ByteScout Barcode Suite

### Learn to code in VBScript to make barcodes to excel with barcode reader sdk with this simple How-To tutorial

ByteScout tutorials describe the stuff for programmers who use VBScript. Barcodes to excel with barcode reader sdk in VBScript can be applied with ByteScout Barcode Suite. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

 Want to speed up the application development? Then this VBScript, code samples for VBScript, developers help to speed up the application development and writing a code when using ByteScout Barcode Suite. To use barcodes to excel with barcode reader sdk in your VBScript project or application just copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample VBScript codes to implement barcodes to excel with barcode reader sdk using ByteScout Barcode Suite.

ByteScout Barcode Suite is available as a free trial. You may get it from our website along with all other source code samples for VBScript applications.

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

##### ****MultipleTypeBarcodeToExcel.vbs:**
    
```
if WScript.Arguments.Count < 1 Then
 MsgBox "Run with the folder path as the argument" & vbCRLF & vbCRLF & "MultipleTypeBarcodeToExcel.vbs <InputFolder>"
 WScript.Quit 0
End If

Set objFSO = CreateObject("Scripting.FileSystemObject")

' define allowed input images extensions
inputImagesExtensions = "JPG,JPEG,PNG,BMP,PDF,TIF"

Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

' Set multiple barcode types for searching
reader.BarcodeTypesToFind.Code39 = True
reader.BarcodeTypesToFind.QRCode = True
reader.BarcodeTypesToFind.PDF417 = True
reader.BarcodeTypesToFind.EAN13 = True

' Set excel document
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

' Set document keys
document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("BarCodes")

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
cscript.exe MultipleTypeBarcodeToExcel.vbs "InputFiles"
pause
```

<!-- code block end -->