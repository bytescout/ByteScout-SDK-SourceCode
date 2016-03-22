'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Set args = WScript.Arguments

if args.count < 1 Then
 MsgBox "Usage: PDFToPNG-CommandLine.vbs inputpdf.pdf"
 Wscript.Quit
End If

' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile args.item(0)

' set high quality resolution 600 dpi (600 dots per inch)
renderer.resolution = 600

' iterate through pages
For i=0 To renderer.GetPageCount()-1

 renderer.RenderPageToFile i, 2, "page" & CStr(i) & ".png" ' 2 = PNG format

Next

MsgBox CStr(renderer.GetPageCount()) & " pages were converted to png from " & args.item(0)

