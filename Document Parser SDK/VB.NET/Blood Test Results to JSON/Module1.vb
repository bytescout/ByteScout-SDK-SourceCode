'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Collections.Specialized
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Threading
Imports ByteScout.DocumentParser
Imports Newtonsoft.Json.Linq

Module Module1

    Sub Main()

        ' Sample document containing blood test report
        ' Report consists of sample patient information such as patinet name, DOB, patientID
        ' Report information such as report type, collection date And time
        ' Test components such as complete blood count, Hemoglobin, White Blood Cell (WBC), Red Blood Cell (RBC), etc.
        Dim sampleDocument As String = ".\SampleBloodReport.pdf"

        ' Sample template which primarily extracts patient name, report date And test result table.
        Dim sampleTemplate As String = ".\SampleBloodReport.yml"

        ' Perform parsing with SDK
        ParseWithSDK(sampleDocument, sampleTemplate)

        ' Perform parsing with PDF.co api
        ' ParseWithPDFCoApi(sampleDocument, sampleTemplate)

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Parse with Document Parser SDK
    ''' </summary>
    Sub ParseWithSDK(ByVal sampleDocument As String, ByVal sampleTemplate As String)

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Add sample template
            documentParser.AddTemplate(sampleTemplate)

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON)

            Dim resultFile = "result.json"

            ' Write output file
            File.WriteAllText(resultFile, jsonString)

            Console.WriteLine($"Generated JSON file saved as {resultFile} file")

        End Using

    End Sub


    ''' <summary>
    ''' Parse with PDF.co API
    ''' </summary>
    Sub ParseWithPDFCoApi(ByVal sampleDocument As String, ByVal sampleTemplate As String)

        ' The authentication key (API Key).
        ' Get your own by registering at https://app.pdf.co/documentation/api
        Const API_KEY As String = "***********************************"

        ' PDF document password. Leave empty for unprotected documents.
        Const Password As String = ""

        ' Destination TXT file name
        Const DestinationFile As String = ".\result.json"

        ' (!) Make asynchronous job
        Const Async As Boolean = True

        ' Template text. Use Document Parser SDK (https//bytescout.com/products/developer/documentparsersdk/index.html)
        ' to create templates.
        ' Read template from file
        Dim templateText As String = File.ReadAllText(sampleTemplate)

        ' Create standard .NET web client instance
        Dim webClient As WebClient = New WebClient()

        ' Set API Key
        webClient.Headers.Add("x-api-key", API_KEY)

        ' 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
        ' * If you already have a direct file URL, skip to the step 3.

        ' Prepare URL for `Get Presigned URL` API call
        Dim query As String = Uri.EscapeUriString(String.Format(
            "https://api.pdf.co/v1/file/upload/get-presigned-url?contenttype=application/octet-stream&name={0}",
            Path.GetFileName(sampleDocument)))

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
                webClient.UploadFile(uploadUrl, "PUT", sampleDocument) ' You can use UploadData() instead if your file is byte array or Stream

                ' 3. PARSE UPLOADED PDF DOCUMENT

                ' URL for `Document Parser` API call
                query = Uri.EscapeUriString(
                    String.Format("https://api.pdf.co/v1/pdf/documentparser?url={0}&async={1}", uploadedFileUrl, Async)
                    )

                Dim requestBody As New NameValueCollection()
                requestBody.Add("template", templateText)

                ' Execute request
                Dim responseBytes As Byte() = webClient.UploadValues(query, "POST", requestBody)
                response = Encoding.UTF8.GetString(responseBytes)

                ' Parse JSON response
                json = JObject.Parse(response)

                If json("error").ToObject(Of Boolean) = False Then

                    ' Asynchronous job ID
                    Dim jobId As String = json("jobId").ToString()
                    ' URL of generated PDF file that will available after the job completion
                    Dim resultFileUrl As String = json("url").ToString()

                    ' Check the job status in a loop. 
                    ' If you don't want to pause the main thread you can rework the code 
                    ' to use a separate thread for the status checking and completion.
                    Do
                        Dim status As String = CheckJobStatus(webClient, jobId) ' Possible statuses: "working", "failed", "aborted", "success".

                        ' Display timestamp and status (for demo purposes)
                        Console.WriteLine(DateTime.Now.ToLongTimeString() + ": " + status)

                        If status = "success" Then

                            ' Download PDF file
                            webClient.DownloadFile(resultFileUrl, DestinationFile)

                            Console.WriteLine("Generated JSON file saved as ""{0}"" file.", DestinationFile)
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

            End If

        Catch ex As WebException
            Console.WriteLine(ex.ToString())
        End Try

        webClient.Dispose()

    End Sub

    ''' <summary>
    ''' Check PDF.co job status
    ''' </summary>
    Function CheckJobStatus(ByVal webClient As WebClient, ByVal jobId As String) As String

        Dim url As String = "https://api.pdf.co/v1/job/check?jobid=" + jobId

        Dim response As String = webClient.DownloadString(url)
        Dim json As JObject = JObject.Parse(response)

        Return Convert.ToString(json("status"))

    End Function


End Module
