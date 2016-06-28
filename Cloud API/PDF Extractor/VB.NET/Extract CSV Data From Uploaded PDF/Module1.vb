Imports System.Net
Imports System.Text

Module Module1

    ' The authentication key (API Key). 
    ' Get your own by registering at https://secure.bytescout.com/users/sign_up
    ReadOnly API_KEY = "********************************"

    Sub Main()

        Dim inputFile = "sample.pdf"
        Dim outputFile = "result.csv"
        Dim uploadedFileId = Nothing

        Dim webClient = New WebClient()

        Try

            ' 1. Upload PDF file

            Dim responseArray = webClient.UploadFile("https://bytescout.io/api/v1/file/upload?apiKey=" + API_KEY, inputFile)
            If responseArray IsNot Nothing Then
                uploadedFileId = Encoding.ASCII.GetString(responseArray)
            End If

            If uploadedFileId IsNot Nothing Then

                ' 2. Extract PDF document content to CSV format

                ' Prepare URL for CSV Extractor API
                Dim urlBuilder = New StringBuilder("https://bytescout.io/api/v1/pdfextractor/csvextractor/extract")
                urlBuilder.Append("?apiKey=").Append(API_KEY)
                urlBuilder.Append("&properties.csvSeparatorSymbol=;") ' set CSV separator char
                urlBuilder.Append("&properties.csvQuotaionSymbol=""") ' set CSV qutation char
                urlBuilder.Append("&properties.trimSpaces=true") ' trim spaces
                urlBuilder.Append("&inputType=fileId") ' input is uploaded file ID
                urlBuilder.Append("&input=").Append(uploadedFileId)
                urlBuilder.Append("&outputType=link") ' output is the download link of generated file

                ' Execute request
                Dim resultFileLink = webClient.DownloadString(urlBuilder.ToString())

                ' Download the result file
                webClient.DownloadFile(resultFileLink, outputFile)

                Console.WriteLine("Generated PDF document image is saved to ""{0}"" file", outputFile)

            End If

        Catch exception As Exception
            Console.WriteLine(exception)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub

End Module
