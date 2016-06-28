Imports System.Net
Imports System.Text

Module Module1

    ' The authentication key (API Key). 
    ' Get your own by registering at https://secure.bytescout.com/users/sign_up
    ReadOnly API_KEY = "********************************"

    Sub Main()

        Dim inputFile = "QRCode.jpg"
        Dim uploadedFileId = Nothing

        Dim webClient = New WebClient()

        Try

            ' 1. Upload PDF file

            Dim responseArray = webClient.UploadFile("https://bytescout.io/api/v1/file/upload?apiKey=" + API_KEY, inputFile)
            If (responseArray IsNot Nothing) Then
                uploadedFileId = Encoding.ASCII.GetString(responseArray)
            End If

            If (uploadedFileId IsNot Nothing) Then

                ' 2. Read barcode

                ' Prepare URL for Barcode Reader API: /api/v1/barcodereader/read
                Dim urlBuilder = New StringBuilder("https://bytescout.io/api/v1/barcodereader/read")
                urlBuilder.Append("?apiKey=").Append(API_KEY)
                urlBuilder.Append("&properties.barcodeTypesToFind.qrCode=true") ' enable QR Code decoding
                urlBuilder.Append("&inputType=fileId") ' input is uploaded file ID
                urlBuilder.Append("&input=").Append(uploadedFileId) ' set "input" parameter to the file ID we've got on the previous step
                urlBuilder.Append("&outputType=content") ' output is JSON or XML string containing decoding results

                ' Set the result format to JSON. Change to "application/xml" if you prefer XML.
                webClient.Headers.Add("Accept", "application/json")

                'Execute request
                Dim decodingResults = webClient.DownloadString(urlBuilder.ToString())

                Console.WriteLine("Decoding results:")
                Console.WriteLine()
                Console.WriteLine(decodingResults)
                
            End If

        Catch exception As Exception
            Console.WriteLine(exception)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub

End Module
