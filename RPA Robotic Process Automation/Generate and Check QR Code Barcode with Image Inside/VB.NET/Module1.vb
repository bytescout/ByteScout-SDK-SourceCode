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
Imports Bytescout.BarCodeReader

Module Module1

	Sub Main()

		' GENERATE QR CODE WITH DECOARATION IMAGE:

		Dim decorationImageFile As String = ".\logo.png"
		Dim outputFile As String = ".\barcode.png"
		Dim barcodeValue As String = "1234567890 abcdefghijklmnopqrstuvwxyz 1234567890 abcdefghijklmnopqrstuvwxyz"

		' Create and activate barcode generator instance
		Using barcode As New Barcode("demo", "demo")

			' Set barcode type
			barcode.Symbology = Bytescout.BarCode.SymbologyType.QRCode

			' Set high QR Code error correction level
			barcode.Options.QRErrorCorrectionLevel = QRErrorCorrectionLevel.High

			' Set barcode value
			barcode.Value = barcodeValue

			' Add decoration image and scale it to 15% of the barcode square
			barcode.AddDecorationImage(decorationImageFile, 15)

			' Save generated barcode
			barcode.SaveImage(outputFile)

			Console.WriteLine("Barcode saved to " + outputFile)


			' CHECK THE BARCODE IS DECODABLE:

			' Create and activate barcode reader instance
			Using reader As New Reader("demo", "demo")

				' Enable QR Code decoding
				reader.BarcodeTypesToFind.QRCode = True

				' Read barcode from generated image
				Dim foundBarcodes = reader.ReadFrom(outputFile)

				' Check result
				If foundBarcodes.Length > 0 And foundBarcodes(0).Type = Bytescout.BarCodeReader.SymbologyType.QRCode Then
					Console.WriteLine("Barcode is decodable.")
				Else
					Console.WriteLine("Barcode is not decodable!")
				End If

			End Using

			Console.WriteLine()
			Console.WriteLine("Press any key...")
			Console.ReadKey()

		End Using

	End Sub

End Module
