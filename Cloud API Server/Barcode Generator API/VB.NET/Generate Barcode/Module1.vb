'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

' Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
' If it's not then please replace this with with your hosting url.
Module Module1

	' Result file name
	Const ResultFileName As String = ".\barcode.png"
	' Barcode type.
	Const BarcodeType As String = "Code128"
	' Barcode value
	Const BarcodeValue As String = "qweasd123456"

	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Prepare URL for `Barcode Generator` API call
		Dim query As String = Uri.EscapeUriString(string.Format(
			"https://localhost/barcode/generate?name={0}&type={1}&value={2}", 
			Path.GetFileName(ResultFileName), 
			BarcodeType, 
			BarcodeValue))

		Try
			' Execute request
			Dim response As String = webClient.DownloadString(query)

			' Parse JSON response
			Dim json As JObject = JObject.Parse(response)

			If json("error").ToObject(Of Boolean) = False Then
				
				' Get URL of generated barcode image file
				Dim resultFileURI As string = json("url").ToString()

				' Download the image file
				webClient.DownloadFile(resultFileURI, ResultFileName)

				Console.WriteLine("Generated barcode saved to ""{0}"" file.", ResultFileName)

			Else 
				Console.WriteLine(json("message").ToString())
			End If
			
		Catch ex As WebException
			Console.WriteLine(ex.ToString())
		End Try

		webClient.Dispose()

		Console.WriteLine()
		Console.WriteLine("Press any key...")
		Console.ReadKey()

	End Sub

End Module
