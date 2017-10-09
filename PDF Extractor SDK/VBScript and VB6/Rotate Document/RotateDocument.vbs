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


' Create Bytescout.PDFExtractor.DocumentRotator object
Set rotator = CreateObject("Bytescout.PDFExtractor.DocumentRotator")
rotator.RegistrationName = "demo"
rotator.RegistrationKey = "demo"

rotator.Rotate "..\..\sample1.pdf", "result.pdf", 0 ' 0 - rotate 90 deg, 1 - rotate 180 deg, 2 - rotate 270 deg
                
Set rotator = Nothing

WScript.Echo "Rotated document saved as 'result.pdf' file."
