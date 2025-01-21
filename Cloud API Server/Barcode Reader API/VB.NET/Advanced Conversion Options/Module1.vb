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

    Const Pages As String = ""

    ' Sample profile that sets advanced conversion options
    ' Advanced options are properties of Reader class from Bytescout BarCodeReader used in the back-end:
    ' https//cdn.bytescout.com/help/BytescoutBarCodeReaderSDK/html/ba101d21-3db7-eb54-d112-39cadc023d02.htm
    ReadOnly Profiles = File.ReadAllText("profile.json")

    Sub Main()

        ' Create standard .NET web client instance
        Dim webClient As WebClient = New WebClient()

        ' Prepare URL for `Barcode Reader` API call
        Dim query As String = Uri.EscapeUriString(String.Format(
            "https://localhost/barcode/read/from/url?pages={0}&url={1}&profiles={2}",
            Pages,
            SourceFileURL,
            Profiles))

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
