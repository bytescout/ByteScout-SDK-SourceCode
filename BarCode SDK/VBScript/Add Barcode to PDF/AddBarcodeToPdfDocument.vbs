'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


' Create barcode object and register it
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' set symbology to DataMatrix
barcode.Symbology = 15 ' 15 = DataMatrix symbology type

' set barcode value to encode
barcode.Value = "Sample barcode" 

' Place barcode at top-left corner of every document page
barcode.DrawToPDF "..\wikipedia.pdf", -1, 10, 10, "result.pdf"

' Open the output file in default PDF viewer.
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
Set shell = Nothing

Set barcode = Nothing

