'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing
Imports System.Windows.Forms
Imports Bytescout.BarCode

' This application demonstrates two ways how you can show the barcode on a form: 
' 1. using PictureBox control;
' 2. painting it on a Panel control.
Public Partial Class Form1
	Inherits Form
	Private _barcode As Barcode = Nothing

	Public Sub New()
		InitializeComponent()

		' Create Barcode Generator instance
		_barcode = New Barcode()
		_barcode.RegistrationName = "demo"
		_barcode.RegistrationKey = "demo"

		' Setup barcode
		_barcode.Symbology = SymbologyType.QRCode
		_barcode.Value = "Testing Testing Testing Testing Testing Testing Testing Testing Testing Testing Testing Testing Testing"

		' Put the barcode image to PictureBox
		pictureBox1.Image = _barcode.GetImage()
	End Sub

	' Paint the barcode image on a Panel control
	Private Sub panel1_Paint(sender As Object, e As PaintEventArgs)
		Dim barcodeImage As Image = _barcode.GetImage()

		e.Graphics.DrawImage(barcodeImage, 0, 0)
	End Sub
End Class
