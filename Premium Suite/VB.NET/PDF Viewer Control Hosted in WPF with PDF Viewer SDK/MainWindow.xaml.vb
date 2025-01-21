'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
