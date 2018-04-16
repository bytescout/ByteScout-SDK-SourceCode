'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


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
