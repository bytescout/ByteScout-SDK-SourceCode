'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' Create Bytescout.PDFExtractor.DocumentRotator object
Set rotator = CreateObject("Bytescout.PDFExtractor.DocumentRotator")
rotator.RegistrationName = "demo"
rotator.RegistrationKey = "demo"

rotator.Rotate "sample1.pdf", "result.pdf", 0 ' 0 - rotate 90 deg, 1 - rotate 180 deg, 2 - rotate 270 deg
                
Set rotator = Nothing

WScript.Echo "Rotated document saved as 'result.pdf' file."
