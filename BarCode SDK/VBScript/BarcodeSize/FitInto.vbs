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


Set bc = CreateObject("Bytescout.BarCode.Barcode")

' display information about Code39 symbology

msgbox "Easiest way to specify barcode size is to use FitInto_3(width, height, unitOfMeasure) method." & vbCRLF & "Let's generate barcode of 500x300 pixels."

' set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' set barcode value to encode
bc.Value = "012345"

' set barcode size by specifying a square the barcode will be fitted into size in pixels
' 3rd parameter is the unit of measure: 0 - Pixel, 1 - point (1/72 inch), 2 - Inch, 3 - document unit (1/300 inch), 4 - Millimeter, 5 - Centimeter, 6 - Twip(1/20 inch)
' we use 3rd parameter as 0 (Pixel)
bc.FitInto_3 500, 300, 0

msgbox "Generated barcode is saved into 'result.png' file"

bc.SaveImage "result.png"

Set bc = Nothing


' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing
