'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFExtractor.DocumentRotator object
Set rotator = CreateObject("Bytescout.PDFExtractor.DocumentRotator")
rotator.RegistrationName = "demo"
rotator.RegistrationKey = "demo"

rotator.Rotate "..\..\sample1.pdf", "result.pdf", 0 ' 0 - rotate 90 deg, 1 - rotate 180 deg, 2 - rotate 270 deg
                
Set rotator = Nothing
