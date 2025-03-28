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
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module Module1

    ' The authentication key (API Key).
    ' Get your own by registering at https://app.pdf.co/documentation/api
    Const API_KEY As String = "******************************"

    ' Source PDF file
    Const SourceFile As String = ".\sample-rotated.pdf"
    ' Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    Const Pages As String = ""
    ' PDF document password. Leave empty for unprotected documents.
    Const Password As String = ""
    ' Destination TXT file name
    Const DestinationFile As String = ".\result.txt"

    ' Some of advanced options available through profiles:
    ' (JSON can be single/double-quoted and contain comments.)
    ' {
    '     "profiles": [
    '         {
    '             "profile1": {                
    '                 "ExtractInvisibleText": true, // Invisible text extraction. Values: true / false
    '                 "ExtractShadowLikeText": true, // Shadow-like text extraction. Values: true / false
    '                 "ExtractAnnotations": true, // Whether to extract PDF annotations.
    '                 "CheckPermissions": true, // Ignore document permissions. Values: true / false
    '                 "DetectNewColumnBySpacesRatio": 1.2, // A ratio affecting number of spaces between words. 
    '             }
    '         }
    '     ]
    ' }

    ' Sample profile that sets advanced conversion options.
    ' Advanced options are properties of CSVExtractor class from ByteScout PDF Extractor SDK used in the back-end:
    ' https://cdn.bytescout.com/help/BytescoutPDFExtractorSDK/html/87ce5fa6-3143-167d-abbd-bc7b5e160fe5.htm

    'Valid RotationAngle values
    '0 - no rotation
    '1 - 90 degrees
    '2 - 180 degrees
    '3 - 270 degrees
    ReadOnly Profiles As String = File.ReadAllText("profile.json")

    Sub Main()

        ' Create standard .NET web client instance
        Dim webClient As WebClient = New WebClient()

        ' Set API Key
        webClient.Headers.Add("x-api-key", API_KEY)

        ' 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
        ' * If you already have a direct file URL, skip to the step 3.

        ' Prepare URL for `Get Presigned URL` API call
        Dim query As String = Uri.EscapeUriString(String.Format(
            "https://api.pdf.co/v1/file/upload/get-presigned-url?contenttype=application/octet-stream&name={0}",
            Path.GetFileName(SourceFile)))

        Try
            ' Execute request
            Dim response As String = webClient.DownloadString(query)

            ' Parse JSON response
            Dim json As JObject = JObject.Parse(response)

            If json("error").ToObject(Of Boolean) = False Then
                ' Get URL to use for the file upload
                Dim uploadUrl As String = json("presignedUrl").ToString()
                ' Get URL of uploaded file to use with later API calls
                Dim uploadedFileUrl As String = json("url").ToString()

                ' 2. UPLOAD THE FILE TO CLOUD.

                webClient.Headers.Add("content-type", "application/octet-stream")
                webClient.UploadFile(uploadUrl, "PUT", SourceFile) ' You can use UploadData() instead if your file is byte array or Stream

                ' Set JSON content type
                webClient.Headers.Add("Content-Type", "application/json")

                ' 3. CONVERT UPLOADED PDF FILE TO TXT

                ' Prepare URL for `PDF To TXT` API call
                Dim url As String = "https://api.pdf.co/v1/pdf/convert/to/text"

                ' Prepare requests params as JSON
                ' See documentation: https : //apidocs.pdf.co
                Dim parameters As New Dictionary(Of String, Object)
                parameters.Add("name", Path.GetFileName(DestinationFile))
                parameters.Add("password", Password)
                parameters.Add("pages", Pages)
                parameters.Add("url", uploadedFileUrl)
                parameters.Add("profiles", Profiles)

                ' Convert dictionary of params to JSON
                Dim jsonPayload As String = JsonConvert.SerializeObject(parameters)

                ' Execute POST request with JSON payload
                response = webClient.UploadString(url, jsonPayload)

                ' Parse JSON response
                json = JObject.Parse(response)

                If json("error").ToObject(Of Boolean) = False Then

                    ' Get URL of generated TXT file
                    Dim resultFileUrl As String = json("url").ToString()

                    ' Download TXT file
                    webClient.DownloadFile(resultFileUrl, DestinationFile)

                    Console.WriteLine("Generated TXT file saved as ""{0}"" file.", DestinationFile)

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
