'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.UnsearchablePDFMaker object
Set unsearchablePDFMaker = CreateObject("Bytescout.PDFExtractor.UnsearchablePDFMaker")
unsearchablePDFMaker.RegistrationName = "demo"
unsearchablePDFMaker.RegistrationKey = "demo"

' Load sample PDF document
unsearchablePDFMaker.LoadDocumentFromFile("sample1.pdf")

' Set PDF rendering resolution to 150 DPI. Higher value - better quality, but larger output file.
unsearchablePDFMaker.RenderingResolution = 150
' Set embedded images format
unsearchablePDFMaker.ImageFormat = EmbeddedImageFormat.PNG

' Process the document
unsearchablePDFMaker.MakePDFUnsearchable("result.pdf")
