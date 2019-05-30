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
