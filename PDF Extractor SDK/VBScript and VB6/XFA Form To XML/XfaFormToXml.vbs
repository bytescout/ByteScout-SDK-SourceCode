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


' Create Bytescout.PDFExtractor.XMLExtractor object
Set extractor = CreateObject("Bytescout.PDFExtractor.XFAFormExtractor")

extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Load sample PDF document
extractor.LoadDocumentFromFile "sample_xfa_form.pdf"

' Iterate through content types. See type descriptions below.
For i = 0 To 12 

    count = extractor.GetCount(i) ' Get count of files of given type

    For j = 0 To count - 1
        extractor.SaveToFile i, j, CStr(i) & "-" & CStr(j) & ".xml"
    Next
    
Next

WScript.Echo "XFA form data has been extracted to XML files."


' XFAFormContentType enumeration:
'
' 0 - "config" type;
' 1 - "connectionSet" type;
' 2 - "datasets" type;
' 3 - "form" type;
' 4 - "localeSet" type;
' 5 - "postamble" type;
' 6 - "preamble" type;
' 7 - "schema" type;
' 8 - "template" type;
' 9 - "xfdf" type;
' 10 - "xmpmeta" type;
' 11 - "<xdp:xdp>" opening tag type;
' 12 - "<xdp:xdp>" closing tag type.
