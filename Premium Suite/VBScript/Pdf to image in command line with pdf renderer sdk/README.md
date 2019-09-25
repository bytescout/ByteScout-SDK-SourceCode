## pdf to image in command line with pdf renderer sdk in VBScript with ByteScout Premium Suite

### Build pdf to image in command line with pdf renderer sdk in VBScript: ### Step-by-step instructions on how to do pdf to image in command line with pdf renderer sdk in VBScript

ByteScout tutorials describe the stuff for programmers who use VBScript. ByteScout Premium Suite was made to help with pdf to image in command line with pdf renderer sdk in VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Save time on writing and testing code by using the code below and use it in your application.  Just copy and paste this VBScript sample code to your VBScript application's code editor, add a reference to ByteScout Premium Suite (if you haven't added yet) and you are ready to go! Enjoy writing a code with ready-to-use sample VBScript codes to implement pdf to image in command line with pdf renderer sdk using ByteScout Premium Suite.

Trial version along with the source code samples for VBScript can be downloaded from our website

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

##### ****PDF_to_Image.bat:**
    
```
@echo off
REM Run VBScript through the command line
REM The script convert first pages of all PDF documents in the outer folder containing sample files (..\..) 
REM   and puts generated images to "output" sub-folder.
cscript.exe "PDF_to_Image.vbs" ..\.. output

pause
```

<!-- code block end -->    

<!-- code block begin -->

##### ****PDF_to_Image.vbs:**
    
```
if WScript.Arguments.Length < 2 Then
  WScript.Echo "Usage: cscript PDF_to_Image.vbs <input_folder> <output_folder>"
  WScript.Quit
End If


' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")
renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

' Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
Dim outputImageFormat
outputImageFormat = 2

Dim pageIndex
pageIndex = 0


' Create File System object
Set FSO = CreateObject("Scripting.FileSystemObject")

' Get folder object (current folder)
Set inputFolder = FSO.GetFolder(WScript.Arguments.Item(0))

' Get file list
Set files = inputFolder.Files

' Prepare output folder
outputFolder = WScript.Arguments.Item(1)
If FSO.FolderExists(outputFolder) Then 
	FSO.DeleteFolder outputFolder, True
End If
FSO.CreateFolder outputFolder 

' Run barcode search for PDF and TIFF files
For Each file in files

	ext = UCase(FSO.GetExtensionName(file))	
	If ext = "PDF" Then
		
		WScript.Echo "Processing file " & FSO.GetFileName(file)
	
		renderer.LoadDocumentFromFile file
		
		fileName = FSO.BuildPath(WScript.Arguments.Item(1), FSO.GetFileName(file) & ".page0.png")
		renderer.Save fileName, outputImageFormat, pageIndex, renderingResolution
		
		WScript.Echo "  first page converted to " & fileName
		
    End If 
Next

WScript.Echo "Done."

Set renderer = Nothing
Set FSO = Nothing

```

<!-- code block end -->