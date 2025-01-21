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
    Const SourceFileUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-xml/sample.pdf"
    ' Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    Const Pages As String = ""
    ' PDF document password. Leave empty for unprotected documents.
    Const Password As String = ""
    ' Destination XML file name
    Const DestinationFile As String = ".\result.xml"

    ' Sample profile that sets advanced conversion options
    ' Advanced options are properties of XMLExtractor class from ByteScout XML Extractor SDK used in the back-end:
    ' https//cdn.bytescout.com/help/BytescoutPDFExtractorSDK/html/6f2b5e9c-ba15-f9fe-192b-c3e31ec4a0ee.htm
    ReadOnly Profiles = File.ReadAllText("profile.json")

    Sub Main()
        ' Create standard .NET web client instance
        Dim webClient As WebClient = New WebClient()

        ' Prepare URL for `PDF To XML` API call
        Dim query As String = Uri.EscapeUriString(String.Format(
            "https://localhost/pdf/convert/to/xml?name={0}&password={1}&pages={2}&url={3}&profiles={4}",
            Path.GetFileName(DestinationFile),
            Password,
            Pages,
            SourceFileUrl,
            Profiles))

        Try
            ' Execute request
            Dim response As String = webClient.DownloadString(query)

            ' Parse JSON response
            Dim json As JObject = JObject.Parse(response)

            If json("error").ToObject(Of Boolean) = False Then

                ' Get URL of generated XML file
                Dim resultFileUrl As String = json("url").ToString()

                ' Download XML file
                webClient.DownloadFile(resultFileUrl, DestinationFile)

                Console.WriteLine("Generated XML file saved as ""{0}"" file.", DestinationFile)

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
