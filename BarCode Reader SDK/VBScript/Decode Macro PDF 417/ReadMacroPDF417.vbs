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


Dim ImageFiles
Dim Segments
Dim OutputValue

' Input Image files
ImageFiles = Array("MacroPDFBarcode-part1.png", "MacroPDFBarcode-part2.png", "MacroPDFBarcode-part3.png")


Set reader = CreateObject("Bytescout.BarCodeReader.Reader")

reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Set barcode type to find
reader.BarcodeTypesToFind.PDF417 = True
                    
OutputValue = ""                    
' Loop through input files to get value
For Each FileName In ImageFiles

		WScript.Echo "Reading barcode(s) from image '" & FileName & "'"
		
		' Read barcodes
		reader.ReadFromFile FileName

		For i = 0 To reader.FoundCount - 1 

			' Write to console
			WScript.Echo "Found value '" & reader.GetFoundBarcodeValue(i) & "'"
			
			Segments = Split(reader.GetFoundBarcodeValue(i), "\")
			For Each Segment In Segments
			
				OutputValue = OutputValue & " " & Segment
			Next
		Next
Next

WScript.Echo "Consolidated output value: " & OutputValue

' Cleanup
Set reader = Nothing


