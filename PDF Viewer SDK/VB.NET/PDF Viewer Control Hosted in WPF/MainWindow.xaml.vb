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


Class MainWindow

	Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

		' Load a sample document on startup
		pdfViewerControl1.InputFile = "sample.pdf"

	End Sub

	Private Sub menuItemOpen_Click(sender As Object, e As RoutedEventArgs)

		Dim dlg = New Microsoft.Win32.OpenFileDialog()
		dlg.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"

		Dim result As Boolean? = dlg.ShowDialog()

		If result = True Then
			pdfViewerControl1.InputFile = dlg.FileName
		End If

	End Sub
End Class
