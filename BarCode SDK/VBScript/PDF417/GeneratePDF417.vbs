'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Set bc = CreateObject("Bytescout.BarCode.Barcode")

' set symbology to PDF417
bc.Symbology = 13 ' 13 = PDF417 barcode type

' set barcode value to encode
bc.Value = "12345678901234567890abcdefghijk"

bc.SaveImage "result.png"

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing
