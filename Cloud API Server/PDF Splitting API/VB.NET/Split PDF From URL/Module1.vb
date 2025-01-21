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

 	' Source PDF file to split
	Const SourceFileUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf"
	' Comma-separated list of page numbers (or ranges) to process. Example: '1,3-5,7-'.
	const Pages as String = "1-2,3-"
	
	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Prepare URL for `Split PDF` API call
		Dim query As String = Uri.EscapeUriString(String.Format(
			"https://localhost/pdf/split?pages={0}&url={1}",
			Pages,
			SourceFileUrl))

		Try
			' Execute request
			Dim response As String = webClient.DownloadString(query)

			' Parse JSON response
			Dim json As JObject = JObject.Parse(response)

			If json("error").ToObject(Of Boolean) = False Then

				' Download generated PDF files
				Dim part As Integer = 1
				For Each token As JToken In json("urls")
					
					Dim resultFileUrl As string = token.ToString()
					Dim localFileName As String = String.Format(".\part{0}.pdf", part)

					webClient.DownloadFile(resultFileUrl, localFileName)

					Console.WriteLine("Downloaded ""{0}"".", localFileName)
					part = part + 1

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
