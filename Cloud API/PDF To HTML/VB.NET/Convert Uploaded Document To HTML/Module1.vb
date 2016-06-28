Imports System.IO
Imports System.Net
Imports System.Text

Module Module1

    ' The authentication key (API Key). 
    ' Get your own by registering at https://secure.bytescout.com/users/sign_up
    ReadOnly API_KEY = "********************************"

    Sub Main()

        Dim inputFile = "sample.pdf"
        Dim uploadedFileId = Nothing

        Dim webClient = New WebClient()

        Try

            ' 1. Upload PDF file

            Dim responseArray = webClient.UploadFile("https://bytescout.io/api/v1/file/upload?apiKey=" + API_KEY, inputFile)
            If responseArray IsNot Nothing Then
                uploadedFileId = Encoding.ASCII.GetString(responseArray)
            End If

            If uploadedFileId IsNot Nothing Then

                ' 2. Convert uploaded file to HTML

                ' Prepare URL for PDF To HTML API: /api/v1/pdftohtml/htmlextractor/extract
                Dim urlBuilder = New StringBuilder("https://bytescout.io/api/v1/pdftohtml/htmlextractor/extract")
                urlBuilder.Append("?apiKey=").Append(API_KEY)
                urlBuilder.Append("&properties.extractInvisibleText=false")
                urlBuilder.Append("&properties.trimSpaces=true") ' trim spaces
                urlBuilder.Append("&properties.outputImageFormat=png") ' set PNG format for images extracted from PDF document 
                urlBuilder.Append("&properties.outputPageWidth=1200") ' set output HTML page width in pixels
                urlBuilder.Append("&inputType=fileId") ' input is uploaded file ID
                urlBuilder.Append("&input=").Append(uploadedFileId) ' set "input" parameter to the file ID we've got on the previous step
                urlBuilder.Append("&outputType=link") ' output is the download link to generated file

                ' Execute request
                Dim resultFileLink = webClient.DownloadString(urlBuilder.ToString())

                ' Download the result file
                Dim fileName = Path.GetFileName(resultFileLink)
                webClient.DownloadFile(resultFileLink, fileName)

                Console.WriteLine("Generated HTML document is saved to ""{0}"" file", fileName)

            End If

        Catch exception As Exception
            Console.WriteLine(exception)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub

End Module
