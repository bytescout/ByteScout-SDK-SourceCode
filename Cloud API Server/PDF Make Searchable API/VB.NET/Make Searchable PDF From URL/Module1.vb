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

 	' Direct URL of source PDF file.
	Const SourceFileUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-make-searchable/sample.pdf"
	' Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
	const Pages as String = ""
	' PDF document password. Leave empty for unprotected documents.
	const Password As string = ""
	' OCR language. "eng", "fra", "deu", "spa"  supported currently. Let us know if you need more.
	const Language as String = "eng"
	' Destination PDF file name
	const DestinationFile as string = ".\result.pdf"

	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Prepare URL for `Make Searchable PDF` API call
		Dim query As String = Uri.EscapeUriString(String.Format(
			"https://localhost/pdf/makesearchable?name={0}&password={1}&pages={2}&lang={3}&url={4}",
			Path.GetFileName(DestinationFile),
			Password,
			Pages,
			Language,
			SourceFileUrl))

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
