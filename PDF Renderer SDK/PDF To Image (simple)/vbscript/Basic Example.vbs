'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")
renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load PDF document.
renderer.LoadDocumentFromFile "..\..\multipage.pdf"

' Render first page of the document to PNG image file.
renderer.RenderPageToFile 0, 2, "result.png" ' 2 - PNG image format

' Open the output file in default image viewer.
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing

Set extractor = Nothing

