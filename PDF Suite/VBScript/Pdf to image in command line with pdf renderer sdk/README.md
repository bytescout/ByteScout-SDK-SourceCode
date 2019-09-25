## pdf to image in command line with pdf renderer sdk in VBScript and ByteScout PDF Suite

### Learn pdf to image in command line with pdf renderer sdk in VBScript

An easy to understand guide to learn how to pdf to image in command line with pdf renderer sdk in VBScript. ByteScout PDF Suite was made to help with pdf to image in command line with pdf renderer sdk in VBScript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

VBScript code snippet like this for ByteScout PDF Suite works best when you need to quickly implement pdf to image in command line with pdf renderer sdk in your VBScript application.  Just copy and paste this VBScript sample code to your VBScript application's code editor, add a reference to ByteScout PDF Suite (if you haven't added yet) and you are ready to go! VBScript application implementation mostly involves various stages of the software development so even if the functionality works please check it with your data and the production environment.

Trial version can be downloaded from our website for free. It contains this and other source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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