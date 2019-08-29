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
Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how to digitally sign PDF document.
''' </summary>
Class Program

	Shared Sub Main()

		' Create new document
		Dim pdfDocument = New Document()
		pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
		' Add page
		Dim page = New Page(PaperFormat.A4)
		pdfDocument.Pages.Add(page)

		' Add sample page content
		Dim brush = New Bytescout.PDF.SolidBrush()
		Dim font = New Bytescout.PDF.Font("Arial", 16)
		Dim rect = New RectangleF(0, 50, page.Width, 100)
		Dim stringFormat = New Bytescout.PDF.StringFormat()
		stringFormat.HorizontalAlign = HorizontalAlign.Center
		page.Canvas.DrawString("Signature Test", font, brush, rect, stringFormat)

		' Signing parameters
		Dim certficateFile = ".\demo_certificate.pfx"
		Dim certficatePassword = "123"
		' Optional parameters
		Dim signingReason = "Approval"
		Dim contactName = "John Smith"
		Dim location = "Corporate HQ"

		' Invisible signature
		'pdfDocument.Sign(certficateFile, certficatePassword)

		' Visible signature
		Dim signatureRect = New RectangleF(400, 50, 150, 100)
		pdfDocument.Sign(certficateFile, certficatePassword, signatureRect, signingReason, contactName, location)

		' Save document to file
		pdfDocument.Save("result.pdf")

		' Cleanup 
		pdfDocument.Dispose()

		' Open document in default PDF viewer application
		Process.Start("result.pdf")

	End Sub

End Class
