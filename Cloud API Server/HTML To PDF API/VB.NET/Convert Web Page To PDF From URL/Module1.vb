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

 	' URL of web page to convert to PDF document.
	const SourceUrl as String = "http://en.wikipedia.org/wiki/Main_Page"
	' Destination PDF file name
	Const DestinationFile As String = ".\result.pdf"

	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Prepare URL for `Web Page to PDF` API call
		Dim query As String = Uri.EscapeUriString(String.Format(
			"https://localhost/pdf/convert/from/url?name={0}&url={1}",
			Path.GetFileName(DestinationFile),
			SourceUrl))

		Try
			' Execute request
			Dim response As String = webClient.DownloadString(query)

			' Parse JSON response
			Dim json As JObject = JObject.Parse(response)

			If json("error").ToObject(Of Boolean) = False Then

				' Get URL of generated PDF file
				Dim resultFileUrl As String = json("url").ToString()

				' Download PDF file
				webClient.DownloadFile(resultFileUrl, DestinationFile)

				Console.WriteLine("Generated PDF file saved as ""{0}"" file.", DestinationFile)

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
