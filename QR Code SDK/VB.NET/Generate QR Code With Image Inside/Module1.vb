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


Imports Bytescout.BarCode

Module Module1

	Sub Main()

		Dim decorationImageFile As String = ".\logo.png"
		Dim outputFile As String = ".\barcode.png"
		Dim barcodeValue As String = "1234567890 abcdefghijklmnopqrstuvwxyz 1234567890 abcdefghijklmnopqrstuvwxyz"

		' Create and activate QRCode instance
		Using barcode As New QRCode("demo", "demo")

			' Set high QR Code error correction level
			barcode.QROption_ErrorCorrectionLevel = QRErrorCorrectionLevel.High

			' Set barcode value
			barcode.Value = barcodeValue

			' Add decoration image and scale it to 15% of the barcode square
			barcode.AddDecorationImage(decorationImageFile, 15)

			' Save generated barcode
			barcode.SaveImage(outputFile)
			
		End Using

		' Open the result image in default image viewer (for demo purpose)
		Process.Start(outputFile)

	End Sub

End Module
