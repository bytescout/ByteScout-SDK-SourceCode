'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


' Create Bytescout.PDFExtractor.CSVExtractor object
Set remover = CreateObject("Bytescout.PDFExtractor.Remover")
remover.RegistrationName = "demo"
remover.RegistrationKey = "demo"

' Load sample PDF document
remover.LoadDocumentFromFile "../../sample1.pdf"

' Remove text "LOREM IPSUM" and save edited document as "result1.pdf".
' NOTE: The removed text might be larger than the search string. Currently the Remover deletes 
' the whole PDF text object containing the search string.
remover.RemoveText 0, "LOREM IPSUM", True, "result.pdf"
        
WScript.Echo "Modified document saved as 'result.pdf' file."
