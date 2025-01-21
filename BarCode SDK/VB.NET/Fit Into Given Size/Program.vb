'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Diagnostics
Imports Bytescout.BarCode

Class Program
	Friend Shared Sub Main(args As String())
		' Create new barcode
		Dim barcode As New Barcode()

		' Set symbology
		barcode.Symbology = SymbologyType.Code39
		' Set value
		barcode.Value = "Sample"

		' Specify barcode size by bounds to fit into.
		' You can use any measure units.
		barcode.FitInto(5, 3, UnitOfMeasure.Inch)

		' Save barcode to image
		barcode.SaveImage("result.png")

		' Show image in default image viewer
		Process.Start("result.png")
	End Sub
End Class
