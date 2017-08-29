Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Module Module1

	' (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY

	' The authentication key (API Key).
	' Get your own by registering at https://secure.bytescout.com/users/sign_up
	Const API_KEY As String = "***********************************"

	' Direct URL of source file to search barcodes in.
	Const SourceFileURL As String = "https://github.com/bytescout/ByteScout-SDK-SourceCode/raw/master/BarCode%20Reader%20SDK/C%23/Export%20Results%20to%20XML%2C%20CSV%2C%20TXT/barcodes.pdf"
	' Comma-separated list of barcode types to search. 
	' See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeReadFromUrlGet
	Const BarcodeTypes As String = "Code128,Code39,Interleaved2of5,EAN13"
	' Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
	Const Pages As String = ""

	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Set API Key
		webClient.Headers.Add("x-api-key", API_KEY)

		' Prepare URL for `Barcode Reader` API call
		Dim query As String = Uri.EscapeUriString(String.Format(
			"https://bytescout.io/v1/barcode/read/from/url?types={0}&pages={1}&url={2}",
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


		Console.WriteLine()
		Console.WriteLine("Press any key...")
		Console.ReadKey()

	End Sub

End Module
