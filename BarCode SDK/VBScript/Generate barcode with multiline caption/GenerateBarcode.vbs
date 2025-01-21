'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
