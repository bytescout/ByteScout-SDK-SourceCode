'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

if WScript.Arguments.Length < 2 Then
  WScript.Echo "Usage: cscript PDF_to_Image.vbs <input_folder> <output_folder>"
  WScript.Quit
End If


' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")
renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"
' Set rendering resolution to 96 DPI (default is 300 DPI)
' To get higher quality output, set 300 or more
renderer.resolution = 96


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
		renderer.RenderPageToFile 0, 2, fileName ' 2 means PNG format
		
		WScript.Echo "  first page converted to " & fileName
		
    End If 
Next

WScript.Echo "Done."

Set renderer = Nothing
Set FSO = Nothing
