Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Module Module1

	' (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY

	' The authentication key (API Key).
	' Get your own by registering at https://secure.bytescout.com/users/sign_up
	Const API_KEY As String = "***********************************"

	' Source image files
	Dim ImageFiles() As String = New String() {".\image1.png", ".\image2.jpg"}
	' Destination PDF file name
	Const DestinationFile As String = ".\result.pdf"

	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Set API Key
		webClient.Headers.Add("x-api-key", API_KEY)

		' 1. UPLOAD FILES TO CLOUD

		Dim uploadedFiles As List(Of String) = New List(Of String)()

		Try
			For Each imageFile As String In ImageFiles

				' 1a. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.

				' Prepare URL for `Get Presigned URL` API call
				Dim query As String = Uri.EscapeUriString(String.Format(
					"https://bytescout.io/v1/file/upload/get-presigned-url?contenttype=binary/octet-stream&name={0}",
					Path.GetFileName(imageFile)))

				' Execute request
				Dim response As String = webClient.DownloadString(query)

				' Parse JSON response
				Dim json As JObject = JObject.Parse(response)

				If json("error").ToObject(Of Boolean) = False Then

					' Get URL to use for the file upload
					Dim uploadUrl As String = json("presignedUrl").ToString()
					' Get URL of uploaded file to use with later API calls
					Dim uploadedFileUrl As String = json("url").ToString()

					' 1b. UPLOAD THE FILE TO CLOUD.

					webClient.Headers.Add("content-type", "binary/octet-stream")
					webClient.UploadFile(uploadUrl, "PUT", imageFile) ' You can use UploadData() instead if your file is byte[] or Stream

					uploadedFiles.Add(uploadedFileUrl)
				Else
					Console.WriteLine(json("message").ToString())
				End If

			Next

			If uploadedFiles.Count > 0 Then

				' 2. CREATE PDF DOCUMENT FROM UPLOADED IMAGE FILES

				' Prepare URL for `Image To PDF` API call
				Dim query As String = Uri.EscapeUriString(String.Format(
					"https://bytescout.io/v1/pdf/convert/from/image?name={0}&url={1}",
					Path.GetFileName(DestinationFile),
					String.Join(",", uploadedFiles)))

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

			End If

		Catch ex As WebException
			Console.WriteLine(ex.ToString())
		End Try


		Console.WriteLine()
		Console.WriteLine("Press any key...")
		Console.ReadKey()

	End Sub

End Module
