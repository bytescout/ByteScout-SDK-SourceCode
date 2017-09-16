'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


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
