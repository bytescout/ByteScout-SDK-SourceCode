'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.DocumentMerger object
Set merger = CreateObject("Bytescout.PDFExtractor.DocumentMerger")
merger.RegistrationName = "demo"
merger.RegistrationKey = "demo"

Dim inputFiles 
inputFiles = Array("..\..\sample1.pdf", "..\..\sample2.pdf", "..\..\sample3.pdf")

merger.Merge inputFiles, "result.pdf"
                
Set merger = Nothing
