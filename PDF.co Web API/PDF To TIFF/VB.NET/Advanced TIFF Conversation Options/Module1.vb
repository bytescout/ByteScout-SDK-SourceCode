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
Imports System.Threading
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


' Cloud API asynchronous "PDF To TIFF" job example.
' Allows to avoid timeout errors when processing huge or scanned PDF documents.

' The following options are available through profiles:
' (JSON can be single/double-quoted and contain comments.)
' {
'     "profiles": [
'         {
'             "profile1": {
'                 "TextSmoothingMode": "HighQuality", // Valid values: "HighSpeed", "HighQuality"
'                 "VectorSmoothingMode": "HighQuality", // Valid values: "HighSpeed", "HighQuality"
'                 "ImageInterpolationMode": "HighQuality", // Valid values: "HighSpeed", "HighQuality"
'                 "RenderTextObjects": true, // Valid values: true, false
'                 "RenderVectorObjects": true, // Valid values: true, false
'                 "RenderImageObjects": true, // Valid values: true, false
'                 "RenderCurveVectorObjects": true, // Valid values: true, false
'                 "JPEGQuality": 85, // from 0 (lowest) to 100 (highest)
'                 "TIFFCompression": "LZW", // Valid values: "None", "LZW", "CCITT3", "CCITT4", "RLE"
'                 "RotateFlipType": "RotateNoneFlipNone", // RotateFlipType enum values from here: https://docs.microsoft.com/en-us/dotnet/api/system.drawing.rotatefliptype?view=netframework-2.0
'                 "ImageBitsPerPixel": "BPP24", // Valid values: "BPP1", "BPP8", "BPP24", "BPP32"
'                 "OneBitConversionAlgorithm": "OtsuThreshold", // Valid values: "OtsuThreshold", "BayerOrderedDithering"
'                 "FontHintingMode": "Default", // Valid values: "Default", "Stronger"
'                 "NightMode": false // Valid values: true, false
'             }
'         }
'     ]
' }


Module Module1

	' The authentication key (API Key).
	' Get your own by registering at https://app.pdf.co
	Const API_KEY As String = "***********************************"

	' Direct URL of source PDF file.
    ' You can also upload your own file into PDF.co and use it as url. Check "Upload File" samples for code snippets: https://github.com/bytescout/pdf-co-api-samples/tree/master/File%20Upload/   
	Const SourceFileUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf"
	' Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
	Const Pages As String = ""
	' PDF document password. Leave empty for unprotected documents.
	Const Password As String = ""
	' Destination TIFF file name
	Const DestinationFile As String = ".\result.tif"
	' (!) Make asynchronous job
	Const Async As Boolean = True
    ' Advanced options
    Const Profiles As String = "{ 'profiles': [ { 'profile1': { 'TIFFCompression': 'CCITT4' } } ] }"


	Sub Main()

		' Create standard .NET web client instance
		Dim webClient As WebClient = New WebClient()

		' Set API Key
		webClient.Headers.Add("x-api-key", API_KEY)

        ' Set JSON content type
        webClient.Headers.Add("Content-Type", "application/json")

		' Prepare URL for `PDF To TIFF` API call
		Dim url As String = "https://api.pdf.co/v1/pdf/convert/to/tiff"

        ' Prepare requests params as JSON
        ' See documentation: https : //apidocs.pdf.co
        Dim parameters As New Dictionary(Of String, Object)
		parameters.Add("name", Path.GetFileName(DestinationFile))
		parameters.Add("password", Password)
		parameters.Add("pages", Pages)
		parameters.Add("url", SourceFileUrl)
		parameters.Add("async", Async)
		parameters.Add("profiles", Profiles)

        ' Convert dictionary of params to JSON
        Dim jsonPayload As String = JsonConvert.SerializeObject(parameters)

		Try
			' Execute POST request with JSON payload
			Dim response As String = webClient.UploadString(url, jsonPayload)

			' Parse JSON response
			Dim json As JObject = JObject.Parse(response)

			If json("error").ToObject(Of Boolean) = False Then

				' Asynchronous job ID
				Dim jobId As String = json("jobId").ToString()
				' URL of generated TIFF file that will available after the job completion
				Dim resultFileUrl As String = json("url").ToString()

				' Check the job status in a loop. 
				' If you don't want to pause the main thread you can rework the code 
				' to use a separate thread for the status checking and completion.
				Do
					Dim status As String = CheckJobStatus(jobId) ' Possible statuses: "working", "failed", "aborted", "success".

					' Display timestamp and status (for demo purposes)
					Console.WriteLine(DateTime.Now.ToLongTimeString() + ": " + status)

					If status = "success" Then

						' Download TIFF file
						webClient.DownloadFile(resultFileUrl, DestinationFile)

						Console.WriteLine("Generated TIFF file saved as ""{0}"" file.", DestinationFile)
						Exit Do

					ElseIf status = "working" Then

						' Pause for a few seconds
						Thread.Sleep(3000)

					Else

						Console.WriteLine(status)
						Exit Do

					End If

				Loop

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

	Function CheckJobStatus(jobId As String) As String

		Using webClient As WebClient = New WebClient()

			' Set API Key
			webClient.Headers.Add("x-api-key", API_KEY)

			Dim url As String = "https://api.pdf.co/v1/job/check?jobid=" + jobId

			Dim response As String = webClient.DownloadString(url)
			Dim json As JObject = JObject.Parse(response)

			return Convert.ToString(json("status"))

		End Using

	End Function

End Module
