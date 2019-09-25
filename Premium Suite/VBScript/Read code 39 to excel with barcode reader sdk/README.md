## How to read code 39 to excel with barcode reader sdk in VBScript using ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to read code 39 to excel with barcode reader sdk in VBScript

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. ByteScout Premium Suite can read code 39 to excel with barcode reader sdk. It can be applied from VBScript. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for VBScript plus the guidelines and the code below will help you quickly learn how to read code 39 to excel with barcode reader sdk. Follow the instructions from scratch to work and copy the VBScript code. Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for VBScript and other programming languages.

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