'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing.Drawing2D
Imports Bytescout.BarCode

Public Class Form1

	Dim PaperSize As SizeF = New SizeF(5.5F, 8.75F)	' 5.5 x 8.75 inches
	Const PrintingResolution As Integer = 300 ' 300 dots per inch

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Make the print preview dialog larger by default
		PrintPreviewDialog1.MinimumSize = New Size(800, 600)

	End Sub

	Private Sub buttonPrint_Click(sender As Object, e As EventArgs) Handles buttonPrint.Click

		' Show print setup dialog, then print preview
		If PrintDialog1.ShowDialog() = DialogResult.OK Then
			PrintPreviewDialog1.ShowDialog()
		End If

	End Sub

	Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

		' Draw page on the printer device context
		Dim pageBitmap = DrawPage()
		e.Graphics.DrawImage(pageBitmap, 0, 0)

	End Sub

	' Draw cards on a bitmap of custom size
	Private Function DrawPage() As Bitmap

		Dim cardSize As SizeF = New SizeF(PaperSize.Width / 4, PaperSize.Height / 4) ' 4 x 4 cards on a page

		' Prepare constant and variable labels
		Dim strBrand = "CJ SHOES"
		Dim strModel = "ARTHUR-1N"
		Dim strColor = "BLK"
		Dim shoeSizeStart As Single = 5.5F
		Dim shoeSizeStep As Single = 0.5F
		Dim barcodeStartValue As Long = 4611030000
		Dim barcodeValueStep As Integer = 1

		' Prepare fonts
		Dim font1 = New Font("Arial", 0.12F, GraphicsUnit.Inch)
		Dim font2 = New Font("Arial", 0.1F, GraphicsUnit.Inch)
		Dim font3 = New Font("Arial", 0.09F, GraphicsUnit.Inch)
		Dim font4 = New Font("Arial", 0.15F, GraphicsUnit.Inch)

		' Prepare barcode generator
		Dim barcode = New Barcode("demo", "demo")
		barcode.Symbology = SymbologyType.I2of5
		barcode.NarrowBarWidth = 2
		barcode.DrawCaption = False

		Dim cardIndex = 0

		' Create bitmap for the page
		Dim pageBitmap = New Bitmap(CType((PaperSize.Width * PrintingResolution), Integer), CType((PaperSize.Height * PrintingResolution), Integer))
		pageBitmap.SetResolution(PrintingResolution, PrintingResolution)

		Using pageCanvas As Graphics = Graphics.FromImage(pageBitmap)

			pageCanvas.InterpolationMode = InterpolationMode.HighQualityBicubic
			pageCanvas.CompositingQuality = CompositingQuality.HighQuality

			' Setup page units to inches
			pageCanvas.PageUnit = GraphicsUnit.Inch
			' Fill background with white color
			pageCanvas.Clear(Color.White)

			' Draw cards
			For row As Integer = 0 To 3
				For column As Integer = 0 To 3

					' Create bitmap for card
					Dim cardBitmap = New Bitmap(CType((cardSize.Width * PrintingResolution), Integer), CType((cardSize.Height * PrintingResolution), Integer))
					cardBitmap.SetResolution(PrintingResolution, PrintingResolution)

					Using cardCanvas As Graphics = Graphics.FromImage(cardBitmap)

						' Setup page units to inches
						cardCanvas.PageUnit = GraphicsUnit.Inch

						' Setup drawing quality
						cardCanvas.SmoothingMode = SmoothingMode.HighQuality
						cardCanvas.InterpolationMode = InterpolationMode.HighQualityBicubic
						cardCanvas.CompositingQuality = CompositingQuality.HighQuality

						Dim stringFormat = New StringFormat()
						stringFormat.Alignment = StringAlignment.Center

						' Draw static labels
						cardCanvas.DrawString(strBrand, font1, Brushes.Black, cardSize.Width / 2, 0.1F, stringFormat)
						cardCanvas.DrawString(strModel, font2, Brushes.Black, cardSize.Width / 2, 0.4F, stringFormat)
						cardCanvas.DrawString(strColor, font1, Brushes.Black, cardSize.Width / 2, 0.7F, stringFormat)

						' Generate barcode image
						barcode.Value = (barcodeStartValue + cardIndex * barcodeValueStep).ToString()
						barcode.PreserveMinReadableSize = False
						barcode.ResolutionX = PrintingResolution
						barcode.ResolutionY = PrintingResolution
						barcode.FitInto(cardSize.Width, 0.5F, UnitOfMeasure.Inch)
						Dim barcodeImage = barcode.GetImage()
						' Draw barcode
						cardCanvas.DrawImage(barcodeImage, 0, 1.0F)
						' Draw barcode label
						cardCanvas.DrawString(barcode.Value, font3, Brushes.Black, cardSize.Width / 2, 1.4F, stringFormat)

						' Draw shoe size label
						cardCanvas.DrawString((shoeSizeStart + cardIndex * shoeSizeStep).ToString(), font4, Brushes.Black, _
							cardSize.Width / 2, 1.7F, stringFormat)

					End Using

					' Draw card on the page
					pageCanvas.DrawImage(cardBitmap, column * cardSize.Width, row * cardSize.Height)

					cardIndex = cardIndex + 1
				Next
			Next

		End Using

		Return pageBitmap

	End Function

End Class
