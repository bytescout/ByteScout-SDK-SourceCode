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
