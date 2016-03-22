'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.BarCode

Class Program
	Friend Shared Sub Main()
		' Create new barcode and register it.
		Dim barcode As New Barcode()
		barcode.RegistrationName = "demo"
		barcode.RegistrationKey = "demo"

		' Set symbology
		barcode.Symbology = SymbologyType.DataMatrix
		' Set value
		barcode.Value = "Sample barcode"

		' Place barcode at top-right corner of document page
		barcode.DrawToNewPDF("barcode.pdf", 595,842, 500, 50);

		' Open output file in default PDF viewer
		System.Diagnostics.Process.Start("barcode.pdf")
	End Sub
End Class
