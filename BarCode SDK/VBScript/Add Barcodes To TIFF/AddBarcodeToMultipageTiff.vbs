'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' Create barcode object and register it
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"

' set symbology to PDF417
barcode.Symbology = 13 ' 13 = PDF417 symbology type

' set barcode value to encode
barcode.Value = "Sample barcode" 

' Place barcode at bottom-right corner of the the first TIFF page
barcode.DrawToImage "..\wikipedia.tif", 0, 550, 1100, "result.tif"

' Open the output file in default image viewer.
Set shell = CreateObject("WScript.Shell")
shell.Run "result.tif", 1, false
Set shell = Nothing

Set barcode = Nothing

