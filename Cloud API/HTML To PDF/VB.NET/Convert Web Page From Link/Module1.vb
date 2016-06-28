Imports System.Net
Imports System.Text

Module Module1

    ' The authentication key (API Key). 
    ' Get your own by registering at https://secure.bytescout.com/users/sign_up
    ReadOnly API_KEY = "********************************"

    Sub Main()

        Dim inputURL = "http://google.com"
        Dim outputFile = "result.pdf"

        Dim webClient = New WebClient()

        Try

            ' Prepare URL for HTML to PDF API: /api/v1/htmltopdf/convert
            Dim urlBuilder = New StringBuilder("https://bytescout.io//api/v1/htmltopdf/convert")
            urlBuilder.Append("?apiKey=").Append(API_KEY)
            urlBuilder.Append("&properties.title=GOOGLE.COM") ' set PDF document title (optional)
            urlBuilder.Append("&properties.orientation=landscape") ' set page orientation (portrait/landscape)
            urlBuilder.Append("&properties.headerHTML=<div style=""display: block; text-align: right;"">*** Header ***</div>") ' set header text for each PDF page (optional)
            urlBuilder.Append("&properties.footerHTML=*** Footer ***") ' set footer text for each PDF page (optional)
            urlBuilder.Append("&inputType=link") ' set input type to "link"
            urlBuilder.Append("&input=").Append(inputURL)
            urlBuilder.Append("&outputType=link") ' the result will contain download link to generated file

            ' Execute request
            Dim resultFileLink = webClient.DownloadString(urlBuilder.ToString())

            ' Download the result file
            webClient.DownloadFile(resultFileLink, outputFile)

            Console.WriteLine("Generated PDF document image is saved to ""{0}"" file", outputFile)

        Catch exception As Exception
            Console.WriteLine(exception)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub

End Module
