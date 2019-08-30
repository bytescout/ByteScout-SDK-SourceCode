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


' This example demonstrates the use of profiles. Profiles are set of properties 
' allowing to apply them to Reader in any combination quickly. You can use 
' predefined profiles or create you own in JSON format like in this example.

' Create Bytescout.PDFExtractor.TextExtractor object
Set reader1 = CreateObject("Bytescout.BarCodeReader.Reader")
reader1.RegistrationName = "demo"
reader1.RegistrationKey = "demo"

' Apply predefined profiles:
' enable Code39;
' enable EAN-13;
' render PDF at 150 DPI resoultion.
reader1.Profiles = "code39, ean13, pdf150dpi"

' Decode and show barcodes from sample1.pdf
reader1.ReadFromFile "sample1.pdf"
For i = 0 To reader1.FoundCount - 1
    WScript.Echo "Found type " & reader1.GetFoundBarcodeType(i) & " barcode with value " & reader1.GetFoundBarcodeValue(i) & """"
Next


Set reader2 = CreateObject("Bytescout.BarCodeReader.Reader")
reader2.RegistrationName = "demo"
reader2.RegistrationKey = "demo"

' Load and apply custom profiles
reader2.LoadProfiles "profiles.json"
reader2.Profiles = "negative-distorted-datamatrix"

' Decode and show barcodes from sample2.png
reader2.ReadFromFile "sample2.png"
For i = 0 To reader2.FoundCount - 1
    WScript.Echo "Found type " & reader2.GetFoundBarcodeType(i) & " barcode with value " & reader2.GetFoundBarcodeValue(i) & """"
Next
