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


Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<MTAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)

        ' Show barcode decoder dialog and get decoded barcode value
        Dim decodedBarcodeValue As String = WebCamBarcodeDecoder.DecodeBarcode()

        If decodedBarcodeValue IsNot Nothing Then
            MessageBox.Show("Found barcode: " & decodedBarcodeValue)
        Else
            MessageBox.Show("Decoding cancelled")
        End If

    End Sub
End Class
