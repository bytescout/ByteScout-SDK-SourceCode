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


' Create Bytescout.PDFRenderer.DocumentPrinter object
Set documentPrinter = CreateObject("Bytescout.PDFRenderer.DocumentPrinter")
documentPrinter.RegistrationName = "demo"
documentPrinter.RegistrationKey = "demo"

' Load sample PDF document
documentPrinter.LoadDocumentFromFile "../../multipage.pdf"

' Change some printing options for demo purposes 
' (note, some options might be not supported by the printer):

' Change paper orientation
documentPrinter.Landscape = True
' Set number of copies
documentPrinter.Copies = 2
' Set collation
documentPrinter.Collate = True
' Force black and white printing
documentPrinter.Color = false

' Print all document pages to "Microsoft Print to PDF"
documentPrinter.PrintDocument "Microsoft Print to PDF"

' To print specific pages use other procedures with parameters allowing to define pages to print:
' documentPrinter.PrintDocument_2 "Microsoft Print to PDF", "1,3-5,7-"
' documentPrinter.PrintDocument_3 "Microsoft Print to PDF", 2, 4
