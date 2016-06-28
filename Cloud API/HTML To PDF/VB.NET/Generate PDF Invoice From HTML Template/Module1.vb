Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Module Module1

    ' The authentication key (API Key). 
    ' Get your own by registering at https://secure.bytescout.com/users/sign_up
    ReadOnly API_KEY = "********************************"

    Sub Main()

        Dim template = File.ReadAllText("invoice_template.html")
        Dim templateData = File.ReadAllText("invoice_data.json")
        Dim outputFile = "result.pdf"

        Dim webClient = New WebClient()

        Try

            ' Prepare URL for HTML to PDF API: /api/v1/htmltopdf/convert
            Dim url = "https://bytescout.io//api/v1/htmltopdf/convert?apiKey=" + API_KEY

            ' Prepare request data in JSON format
            Dim jsonObject = New JObject(
                New JProperty("properties", New JObject(
                    New JProperty("templateData", templateData))),
                New JProperty("inputType", "value"),
                New JProperty("input", template),
                New JProperty("outputType", "link"))

            webClient.Headers.Add("Content-Type", "application/json")

            ' Execute request
            Dim resultFileLink = webClient.UploadString(url, jsonObject.ToString())

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
