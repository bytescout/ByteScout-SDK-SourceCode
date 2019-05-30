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
