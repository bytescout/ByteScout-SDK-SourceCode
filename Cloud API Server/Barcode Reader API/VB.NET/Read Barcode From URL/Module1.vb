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

	' Direct URL of source file to search barcodes in.
	Const SourceFileURL As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf"
	' Comma-separated list of barcode types to search. 
	Const BarcodeTypes As String = "Code128,Code39,Interleaved2of5,EAN13"
	' Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
	Const Pages As String = ""

	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Prepare URL for `Barcode Reader` API call
		Dim query As String = Uri.EscapeUriString(String.Format(
			"https://localhost/barcode/read/from/url?types={0}&pages={1}&url={2}",
			BarcodeTypes,
			Pages,
			SourceFileURL))

		Try
			' Execute request
			Dim response As String = webClient.DownloadString(query)

			' Parse JSON response
			Dim json As JObject = JObject.Parse(response)

			If json("error").ToObject(Of Boolean) = False Then
				
				' Display found barcodes in console
				For Each token As JToken In json("barcodes")
					Console.WriteLine("Found barcode:")
					Console.WriteLine("  Type: " + token("TypeName").ToString())
					Console.WriteLine("  Value: " + token("Value").ToString())
					Console.WriteLine("  Document Page Index: " + token("Page").ToString())
					Console.WriteLine("  Rectangle: " + token("Rect").ToString())
					Console.WriteLine("  Confidence: " + token("Confidence").ToString())
					Console.WriteLine()
				Next

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
