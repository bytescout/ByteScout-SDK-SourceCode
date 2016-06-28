Imports System.Net
Imports System.Text

Module Module1

    ' The authentication key (API Key). 
    ' Get your own by registering at https://secure.bytescout.com/users/sign_up
    ReadOnly API_KEY = "********************************"

    Sub Main()

        Dim outputFile As String = "barcode.png"

        Dim webClient = New WebClient()

        Try

            ' Prepare URL for Barcode Generator API: /api/v1/barcode/generate
            Dim urlBuilder As StringBuilder = New StringBuilder("https://bytescout.io/api/v1/barcode/generate")
            urlBuilder.Append("?apiKey=").Append(API_KEY)
            urlBuilder.Append("&properties.symbology=qrCode") ' set barcode type
            urlBuilder.Append("&properties.outputFileType=png") ' set output image format
            urlBuilder.Append("&outputType=link") ' the result will contain download link to generated file
            urlBuilder.Append("&input=123456abcdef") ' set barcode value

            ' Execute request
            Dim resultFileLink = webClient.DownloadString(urlBuilder.ToString())

            ' Download the result file
            webClient.DownloadFile(resultFileLink, outputFile)

            Console.WriteLine("Generated barcode image is saved to ""{0}"" file", outputFile)

        Catch exception As Exception
            Console.WriteLine(exception)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub

End Module
