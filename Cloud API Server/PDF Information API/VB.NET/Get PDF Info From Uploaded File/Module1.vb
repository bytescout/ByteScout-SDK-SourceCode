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

 	' Source PDF file to get information
	const SourceFile as string = ".\sample.pdf"
	' Comma-separated list of barcode types to search. 
	' See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeReadFromUrlGet
	Const BarcodeTypes As String = "Code128,Code39,Interleaved2of5,EAN13"
	' Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
	Const Pages As String = ""

	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
		' * If you already have a direct file URL, skip to the step 3.

		' Prepare URL for `Get Presigned URL` API call
		Dim query As string = Uri.EscapeUriString(string.Format(
			"https://localhost/file/upload/get-presigned-url?contenttype=application/octet-stream&name={0}", 
			Path.GetFileName(SourceFile)))

		Try
			' Execute request
			Dim response As string = webClient.DownloadString(query)

			' Parse JSON response
			Dim json As JObject = JObject.Parse(response)

			If json("error").ToObject(Of Boolean) = False Then
				' Get URL to use for the file upload
				Dim uploadUrl As string = json("presignedUrl").ToString()
				' Get URL of uploaded file to use with later API calls
				Dim uploadedFileUrl As string = json("url").ToString()

				' 2. UPLOAD THE FILE TO CLOUD.

				webClient.Headers.Add("content-type", "application/octet-stream")
				webClient.UploadFile(uploadUrl, "PUT", SourceFile) ' You can use UploadData() instead if your file is byte array or Stream
				
				' 3. GET INFORMATION FROM UPLOADED FILE

				' Prepare URL for `PDF Info` API call
				query = Uri.EscapeUriString(String.Format(
					"https://localhost/pdf/info?url={0}",
					uploadedFileUrl))

				' Execute request
				response = webClient.DownloadString(query)

				' Parse JSON response
				json = JObject.Parse(response)

				If json("error").ToObject(Of Boolean) = False Then
				
					' Display PDF document information
					For Each token As JToken In json("info")
						Dim [property] as JProperty = token
						Console.WriteLine("{0}: {1}", [property].Name, [property].Value)
					Next

				Else 
					Console.WriteLine(json("message").ToString())
				End If

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
