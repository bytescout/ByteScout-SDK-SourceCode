'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.Diagnostics
Imports System.Text
Imports Bytescout.BarCode

Class Program
	Friend Shared Sub Main(args As String())
		' Create Barcode component instance
		Using barcode As New Barcode()
			barcode.RegistrationName = "demo"
			barcode.RegistrationKey = "demo"

			' Set barcode type
            barcode.Symbology = SymbologyType.PDF417
			' Force binary mode
            barcode.Options.PDF417CompactionMode = PDF417CompactionMode.Binary

			' Sample byte array to use as value  
            Dim byteArray As Byte() = New Byte() {0, 10, 11, 12, 13, 14, 15, &HFF}

			' Set value by converting byte array to string  
            barcode.Value = Encoding.Default.GetString(byteArray)

			' Save barcode image
			barcode.SaveImage("result.png")

			' Open output image in default associated application
			Process.Start("result.png")
		End Using
	End Sub
End Class
