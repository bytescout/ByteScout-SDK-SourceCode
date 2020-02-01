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


Imports System.IO
Imports System.ServiceProcess
Imports System.Timers
Imports Bytescout.BarCode

Public Partial Class Service1
	Inherits ServiceBase
	Private _timer As Timer = Nothing

	Public Sub New()
		InitializeComponent()

		If Not System.Diagnostics.EventLog.SourceExists("MySource") Then
			System.Diagnostics.EventLog.CreateEventSource("MySource", "MyNewLog")
		End If

		eventLog1.Source = "MySource"
		eventLog1.Log = "MyNewLog"
	End Sub

	Protected Overrides Sub OnStart(args As String())
		eventLog1.WriteEntry("In OnStart")

		If _timer IsNot Nothing Then
			_timer.[Stop]()
			RemoveHandler _timer.Elapsed, AddressOf Timer_Elapsed
			_timer.Dispose()
		End If

		_timer = New Timer(5000)
		AddHandler _timer.Elapsed, AddressOf Timer_Elapsed
		_timer.Start()
	End Sub

	Protected Overrides Sub OnStop()
		eventLog1.WriteEntry("In OnStop.")

		If _timer IsNot Nothing Then
			_timer.[Stop]()
			RemoveHandler _timer.Elapsed, AddressOf Timer_Elapsed
			_timer.Dispose()
			_timer = Nothing
		End If
	End Sub

	Private Sub Timer_Elapsed(sender As Object, e As ElapsedEventArgs)
		Dim barcode As Barcode = Nothing

		Try
			' Generate sample barcode value by random number
			Dim random As New Random()
			Dim barcodeValue As String = "(00)" & random.[Next]().ToString("000000000000000000")

			' Create Bytescout.BarCode object and setup the barcode
			barcode = New Barcode("demo", "demo")
			barcode.Symbology = SymbologyType.GS1_128
			barcode.Value = barcodeValue

			Dim outputDirectory As String = "c:\barcodes"
			If Not Directory.Exists(outputDirectory) Then
				Directory.CreateDirectory(outputDirectory)
			End If

			Dim fileName As String = barcodeValue & ".pdf"
			Dim filePath As String = Path.Combine(outputDirectory, fileName)

			' Save barcode to new PDF file
			barcode.DrawToNewPDF(filePath, 500, 500, 50, 50)


				' Sending email message example:
				'
'				System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
'				message.To.Add("luckyperson@online.microsoft.com");
'				message.Subject = fileName;
'				message.From = new System.Net.Mail.MailAddress("From@online.microsoft.com");
'				message.Body = "This is the message body";
'				message.Attachments.Add(new System.Net.Mail.Attachment(filePath));
'				
'				System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("your_smtp_host");
'				smtp.Send(message);
'				

			eventLog1.WriteEntry("Generated " & fileName)
		Catch exception As Exception
			eventLog1.WriteEntry(exception.Message)
		Finally
			If barcode IsNot Nothing Then
				barcode.Dispose()
			End If
		End Try
	End Sub
End Class
