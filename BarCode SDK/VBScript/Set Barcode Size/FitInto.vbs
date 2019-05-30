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


Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Display information about Code39 symbology

msgbox "Easiest way to specify barcode size is to use FitInto_3(width, height, unitOfMeasure) method." & vbCRLF & "Let's generate barcode of 500x300 pixels."

' Set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' Set barcode value to encode
bc.Value = "012345"

' Set barcode size by specifying dimensions the barcode will be fit into.
' 3rd parameter is the unit of measure: 0 - Pixel, 1 - Point (1/72 inch), 2 - Inch, 3 - document unit (1/300 inch), 4 - Millimeter, 5 - Centimeter, 6 - Twip(1/20 inch).
' We use 3rd parameter as 0 (Pixel).
bc.FitInto_3 500, 300, 0

msgbox "Generated barcode is saved into 'result.png' file"

bc.SaveImage "result.png"

Set bc = Nothing


' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.png", 1, false
Set shell = Nothing
