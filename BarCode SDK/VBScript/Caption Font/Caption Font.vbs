'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


' Create Barcode object
Set bc = CreateObject("Bytescout.BarCode.Barcode")

' Set barcode type to Code39
bc.Symbology = 1 ' 1 = Code39 symbology type

' Set barcode value 
bc.Value = "012345" 

' Change caption font
bc.SetCaptionFont "Times New Roman", 24

' Save barcode 
bc.SaveImage "Code39.png"

' Open the output file in default app
Set shell = CreateObject("WScript.Shell")
shell.Run "code39.png", 1, false

