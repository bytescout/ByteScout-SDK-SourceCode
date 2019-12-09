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


Set BC = CreateObject("Bytescout.BarCode.Barcode")

' Set barcode value to encode
BC.Value = "(01)07046261398572(17)130331(10)TEST5632(21)19067811811"

' set symbology to GS1-Datamatrix
BC.Symbology = 37

' Set additional caption and it's position
BC.AdditionalCaption = "(01)07046261398572" & Chr(10) & "(17)130331" & Chr(10) & "(10)TEST5632" & Chr(10) & "(21)19067811811"
BC.AdditionalCaptionPosition = 3

' Set path and save output image
Path = "result.png"
BC.SaveImage (Path)

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run (Path), 1, false
Set shell = Nothing

Set bc = Nothing
