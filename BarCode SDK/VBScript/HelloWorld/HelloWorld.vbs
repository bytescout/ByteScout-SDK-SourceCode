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
msgbox "Encoding '012345' using Code39 symbology" & vbCRLF &  bc.GetValueRestrictions(0) ' 0 = Code39 symbology

' set symbology to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' set barcode value to encode
bc.Value = "012345" 

msgbox "Saving Code39 barcode to 'Code39.png'"

bc.SaveImage "Code39.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "code39.png", 1, false
Set shell = Nothing


msgbox "Encoding '012345' using Aztec symbology"

' set symbology to Aztec (2D)
bc.Symbology = 17 ' 17 = Aztec

' set barcode value to encode
bc.Value = "012345" 

' display information about Aztec symbology
msgbox "Encoding '012345' using Aztec  symbology" & vbCRLF & bc.GetValueRestrictions(17) ' 17 = Code39 symbology

bc.SaveImage "Aztec.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "aztec.png", 1, false
Set shell = Nothing


Set bc = Nothing

