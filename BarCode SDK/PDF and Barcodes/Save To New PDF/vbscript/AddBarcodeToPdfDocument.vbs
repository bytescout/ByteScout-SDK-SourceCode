'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create barcode object and register it
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' set symbology to DataMatrix
barcode.Symbology = 15 ' 15 = DataMatrix symbology type

' set barcode value to encode
barcode.Value = "Sample barcode" 

' Place barcode at top-right corner of every document page
barcode.DrawToNewPDF "barcode.pdf", 595,842, 500, 50

' Open the output file in default PDF viewer.
Set shell = CreateObject("WScript.Shell")
shell.Run "barcode.pdf", 1, false
Set shell = Nothing

Set barcode = Nothing

