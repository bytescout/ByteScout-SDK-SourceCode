'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
