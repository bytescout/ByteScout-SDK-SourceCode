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


' Create Bytescout.PDFRenderer.VectorRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.VectorRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' iterate through pages
For i = 0 To renderer.GetPageCount() - 1

	' Render document page to EMF image file
    renderer.Save "image" & i & ".emf", i, 300

Next


