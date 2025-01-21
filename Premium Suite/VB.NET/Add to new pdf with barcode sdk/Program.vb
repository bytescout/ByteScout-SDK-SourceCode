'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


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
		barcode.DrawToNewPDF("barcode.pdf", 595,842, 500, 50)

		' Open output file in default PDF viewer
		System.Diagnostics.Process.Start("barcode.pdf")
	End Sub
End Class
