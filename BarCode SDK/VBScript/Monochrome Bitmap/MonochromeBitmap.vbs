'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Set bc = CreateObject("Bytescout.BarCode.Barcode")

' set barcode type (symbology)
bc.Symbology = 16 ' 16 = QR Code

' set monochrome output 
bc.ProduceMonochromeImages = True

' set barcode value to encode
bc.Value = "012345"

' save image to file
bc.SaveImage "result.bmp" 

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.bmp", 1, false
Set shell = Nothing
