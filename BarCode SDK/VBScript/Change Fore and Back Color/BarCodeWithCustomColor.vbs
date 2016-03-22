'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************


Set bc = CreateObject("Bytescout.BarCode.Barcode")

' set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' set barcode value to encode
bc.Value = "012345" 

bc.SetForeColorRGB 255,255,0
bc.SetBackColorRGB 0,0,0

bc.SaveImage "CustomColor.png"

Set bc = Nothing

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "CustomColor.png", 1, false
Set shell = Nothing
