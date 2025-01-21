'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing
Imports System.IO
Imports System.Threading
Imports Bytescout.PDFExtractor

Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Google.Apis.Util.Store


Module Module1

    Sub Main()
        ' If modifying these scopes, delete your previously saved credentials
        ' at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        Dim Scopes As String() = {SheetsService.Scope.Spreadsheets}
        Dim ApplicationName As String = "Google Sheets Demo"

        Dim allInputFiles As String() = {"Sample_Files\InvoiceMar.pdf", "Sample_Files\InvoiceApr.pdf"}

        ' Google Sheet data to write
        Dim reqRowData As New List(Of RowData)

        ' Set page index
        Dim pageIndex = 0

        ' Loop through all input files
        For Each itmFile In allInputFiles

            Dim invName = Path.GetFileNameWithoutExtension(itmFile)

            ' Create TextExtractor instance
            Using tableExtractor As New StructuredExtractor("demo", "demo")

                Dim tableExtractionArea = GetTableExtractionArea(itmFile, pageIndex)
                If tableExtractionArea.HasValue Then

                    ' Load document from file
                    tableExtractor.LoadDocumentFromFile(itmFile)

                    ' Set extraction area
                    tableExtractor.SetExtractionArea(tableExtractionArea)

                    ' Prepare table structure
                    tableExtractor.PrepareStructure(pageIndex)

                    Dim rowCount As Int32 = tableExtractor.GetRowCount(pageIndex)

                    ' Ignoring first title row
                    For row As Int32 = 1 To rowCount - 1

                        ' Google Sheet RowData Input
                        Dim itmRowData As New RowData()

                        ' Google Sheet CellData Input
                        Dim lstCellData As New List(Of CellData)

                        ' Add invName to CellData Collection
                        lstCellData.Add(New CellData With {.UserEnteredValue = New ExtendedValue With {.StringValue = invName}})

                        Dim columnCount As Int32 = tableExtractor.GetColumnCount(pageIndex, row)

                        ' Write Invoice Data
                        For column As Int32 = 0 To columnCount - 1

                            ' Get table cell value
                            Dim tableCellValue = tableExtractor.GetCellValue(pageIndex, row, column)

                            ' Google Sheet CellData Input
                            Dim itmCellData As New CellData With {.UserEnteredValue = New ExtendedValue With {.StringValue = tableCellValue}}

                            ' Add to CellData Collection
                            lstCellData.Add(itmCellData)

                        Next

                        ' Add to Google Sheet RowData Request
                        reqRowData.Add(New RowData With {.Values = lstCellData})

                    Next

                End If

            End Using

        Next

        ' Proceed with writing to Google Sheets
        Dim credential As UserCredential

        ' Follow article "https://developers.google.com/sheets/api/quickstart/dotnet" to generate credentials.json
        Using stream As New FileStream("credentials.json", FileMode.Open, FileAccess.Read)
            ' The file token.json stores the user's access and refresh tokens, and is created
            ' automatically when the authorization flow completed for the first time.
            Dim credPath As String = "token.json"
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    New FileDataStore(credPath, True)).Result

            Console.WriteLine($"Credential file saved to : {credPath}")
        End Using

        ' Create Google Sheets API Service
        Dim service As New SheetsService(
            New Google.Apis.Services.BaseClientService.Initializer With
            {
                .HttpClientInitializer = credential,
                .ApplicationName = ApplicationName
            })

        ' Fill following parameter with your google spreadsheet Id
        ' Usually find at url of spreadsheet: https : //docs.google.com/spreadsheets/d/...ThisIsSpreadsheetId.../edit
        Dim spreadsheetId As String = "xxxxxxSpreadsheetIdxxxxxxxxxx"

        ' Get exising row counts
        Dim existingRowCount As Int32 = service.Spreadsheets.Values.Get(spreadsheetId, "A1:D").Execute().Values.Count

        Dim lstRequests As New List(Of Request)
        lstRequests.Add(New Request With
                       {
                           .UpdateCells = New UpdateCellsRequest With
                           {
                            .Range = New GridRange With
                                {
                                    .StartRowIndex = existingRowCount,
                                    .StartColumnIndex = 0
                                },
                           .Rows = reqRowData,
                           .Fields = "*"
                           }
                       })

        ' Prepare batch update spreadsheet request
        Dim batchUpdateSpreadsheetRequest As New BatchUpdateSpreadsheetRequest With
            {
                .Requests = lstRequests
            }

        Dim batchUpdateRequest = service.Spreadsheets.BatchUpdate(batchUpdateSpreadsheetRequest, spreadsheetId)

        ' Perform google sheet updation
        batchUpdateRequest.Execute()

        Console.WriteLine("Google spreadsheet updated!")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Gets table extraction area
    ''' </summary>
    Private Function GetTableExtractionArea(ByVal inputFile As String, ByVal Optional pageIndex As Int32 = 0) As Nullable(Of RectangleF)

        ' Create Bytescout.PDFExtractor.TableDetector instance
        Using tableDetector As New TableDetector("demo", "demo")

            ' Set table detection mode to "bordered tables" - best for tables with closed solid borders.
            tableDetector.ColumnDetectionMode = ColumnDetectionMode.BorderedTables

            ' We should define what kind of tables we should detect.
            ' So we set min required number of columns to 2 ...
            tableDetector.DetectionMinNumberOfColumns = 2
            ' ... And we set min required number of rows to 2
            tableDetector.DetectionMinNumberOfRows = 2

            tableDetector.LoadDocumentFromFile(inputFile)

            If Not tableDetector.FindTable(pageIndex) Then
                Return Nothing
            End If

            ' Getting first found table location
            Return tableDetector.FoundTableLocation

        End Using

    End Function

End Module
