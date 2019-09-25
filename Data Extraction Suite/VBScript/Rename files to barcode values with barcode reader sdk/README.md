## How to rename files to barcode values with barcode reader sdk in VBScript using ByteScout Data Extraction Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to rename files to barcode values with barcode reader sdk in VBScript

The sample source codes on this page shows how to rename files to barcode values with barcode reader sdk in VBScript. Want to rename files to barcode values with barcode reader sdk in your VBScript app? ByteScout Data Extraction Suite is designed for it. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK.

This prolific sample source code in VBScript for ByteScout Data Extraction Suite contains various functions and other necessary options you should do calling the API to rename files to barcode values with barcode reader sdk. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Complete and detailed tutorials and documentation are available along with installed ByteScout Data Extraction Suite if you'd like to learn more about the topic and the details of the API.

You can download free trial version of ByteScout Data Extraction Suite from our website with this and other source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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

##### ****RenameFilesToBarcodeValues.vbs:**
    
```
if WScript.Arguments.Count < 2 Then
 MsgBox "Run with the folder path as the argument" & vbCRLF & vbCRLF & "RenameFiles.vbs InputFolder\ OutputFolder\"
 WScript.Quit 0
End If

Set objFSO = CreateObject("Scripting.FileSystemObject")

' define allowed input images extensions
inputImagesExtensions = "JPG,JPEG,PNG,BMP,PDF,TIF"

' make sure they all are upper cases
inputImagesExtensions = UCASE(inputImagesExtensions)


Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Set barcode types to find:
bc.BarcodeTypesToFind.Code39 = True
bc.BarcodeTypesToFind.QRCode = True
bc.BarcodeTypesToFind.PDF417 = True

Set objinputFolder = objFSO.GetFolder(WScript.Arguments(0))

' output folder
set objOutputFolder = objFSO.GetFolder(WScript.Arguments(1))

Call ShowSubfolders (objinputFolder)

WScript.Quit 0

Sub ShowSubFolders(fFolder)
    Set objFolder = objFSO.GetFolder(fFolder.Path)
    Set colFiles = objFolder.Files
    For Each objFile in colFiles
	' check if allowed extension
        If inStr(inputImagesExtensions, UCase(objFSO.GetExtensionName(objFile.name)))>0 Then

	    ' read barcode from filename
	    WScript.Echo "Reading from: " & objFile.Path 
            bc.ReadFromFile objFile.Path 

	    ' getting the sub folder path
	    outputSubFolder = Replace(objFile.Path, objinputFolder.Path, "")
	    outputSubFolder = Replace(outputSubFolder, objFile.Name, "")
		
            ' rename the file to the value of the very first barcode found on this image or pdf
	    newFileName = bc.GetFoundBarcodeValue(0) & "." & objFSO.GetExtensionName(objFile.name)

	    ' replace some special characters as they may not be allowed for use in filename
            newFileName = Replace(newFileName, "<", "_")
            newFileName = Replace(newFileName, ">", "_")

	    ' first check if output subfolder exists
 	    if Not objFSO.FolderExists (objOutputFolder.Path & outputSubFolder) Then
		objFSO.CreateFolder objOutputFolder.Path & outputSubFolder
	    End If

	    WScript.Echo "Copying and renaming " & objFile.path & " into " & objOutputFolder.Path & outputSubFolder & newFileName

	    ' copying the source file into output folder with new filename based on the barcode value
	    objFSO.CopyFile objFile.path, objOutputFolder.Path & outputSubFolder & newFileName



        End If
    Next

    For Each Subfolder in fFolder.SubFolders
        ShowSubFolders(Subfolder)
    Next
End Sub


```

<!-- code block end -->    

<!-- code block begin -->

##### ****RunRenaming.bat:**
    
```
REM running from the command line
cscript.exe RenameFilesToBarcodeValues.vbs "input" "output"
pause
```

<!-- code block end -->