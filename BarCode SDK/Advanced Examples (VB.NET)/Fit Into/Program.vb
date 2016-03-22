'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

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
