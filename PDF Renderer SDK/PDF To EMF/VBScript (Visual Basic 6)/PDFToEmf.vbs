'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.VectorRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' set rendering resolution to 96 dpi (default is 300 dpi)
' to get high quality output, change to 300 or 600 dpi
renderer.resolution = 96

' iterate through pages
For i=0 To renderer.GetPageCount()-1

 renderer.RenderPageToFile i, 0, "page" & CStr(i) & ".bmp" ' 0 = EMF format

Next

MsgBox CStr(renderer.GetPageCount()) & " pages were converted to emf"

