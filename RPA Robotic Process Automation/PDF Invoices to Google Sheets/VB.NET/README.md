## PDF invoices to google sheets in VB.NET with ByteScout Robotic Process Automation ByteScout Robotic Process Automation is set of tools for rapid implementation of robotic process automation applications.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Robotic%20Process%20Automation%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Robotic%20Process%20Automation%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nm_7I0PN1TY](https://www.youtube.com/watch?v=nm_7I0PN1TY)




<!-- code block begin -->

##### **InvoicesToGoogleSheets.VS2015.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.29001.49
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "InvoicesToGoogleSheets.VS2015", "InvoicesToGoogleSheets.VS2015.vbproj", "{3035D0B9-6453-4C07-9D4E-638B1052E70C}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{3035D0B9-6453-4C07-9D4E-638B1052E70C}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{3035D0B9-6453-4C07-9D4E-638B1052E70C}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{3035D0B9-6453-4C07-9D4E-638B1052E70C}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{3035D0B9-6453-4C07-9D4E-638B1052E70C}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {6F15AB4A-3A3B-44A6-9B5C-38447C2756CE}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **Module1.vb:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### **app.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="System.Runtime" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-2.6.10.0" newVersion="2.6.10.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Threading.Tasks" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-2.6.10.0" newVersion="2.6.10.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Net.Http" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-2.2.29.0" newVersion="2.2.29.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Net.Http.Primitives" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-2.2.29.0" newVersion="2.2.29.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
```

<!-- code block end -->    

<!-- code block begin -->

##### **packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="BouncyCastle" version="1.7.0" targetFramework="net40" />
  <package id="Google.Apis" version="1.10.0" targetFramework="net40" />
  <package id="Google.Apis.Auth" version="1.10.0" targetFramework="net40" />
  <package id="Google.Apis.Core" version="1.10.0" targetFramework="net40" />
  <package id="Google.Apis.Sheets.v4" version="1.45.0.1930" targetFramework="net40" />
  <package id="log4net" version="2.0.3" targetFramework="net40" />
  <package id="Microsoft.Bcl" version="1.1.10" targetFramework="net40" />
  <package id="Microsoft.Bcl.Async" version="1.0.168" targetFramework="net40" />
  <package id="Microsoft.Bcl.Build" version="1.0.21" targetFramework="net40" />
  <package id="Microsoft.Net.Http" version="2.2.29" targetFramework="net40" />
  <package id="Newtonsoft.Json" version="7.0.1" targetFramework="net40" />
  <package id="Zlib.Portable.Signed" version="1.11.0" targetFramework="net40" />
</packages>
```

<!-- code block end -->