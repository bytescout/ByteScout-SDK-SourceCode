## How to extract CSV from PDF and fill database in SQL server in VB.NET and ByteScout PDF Extractor SDK

### The tutorial below will demonstrate how to extract CSV from PDF and fill database in SQL server in VB.NET

The documentation is designed to help you to implement the features on your side. ByteScout PDF Extractor SDK is the SDK is designed to help developers with pdf tables and pdf data extraction from unstructured documents like pdf, tiff, scans, images, scanned and electronic forms. The library is powered by OCR, computer vision and AI to provide unique functionality like table detection, automatic table structure extraction, data restoration, data restructuring and reconstruction. Supports PDF, TIFF, PNG, JPG images as input and can output CSV, XML, JSON formatted data. Includes full set of utilities like pdf splitter, pdf merger, searchable pdf maker and other utilities. It can extract CSV from PDF and fill database in SQL server in VB.NET.

This code snippet below for ByteScout PDF Extractor SDK works best when you need to quickly extract CSV from PDF and fill database in SQL server in your VB.NET application. This VB.NET sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! You can use these VB.NET sample examples in one or many applications.

Free trial version of ByteScout PDF Extractor SDK is available on our website. Documentation and source code samples are included.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Extractor%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Extractor%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=s28W3_KMraU](https://www.youtube.com/watch?v=s28W3_KMraU)




<!-- code block begin -->

##### ****ExtractCsvAndFillDatabase.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{1A9B710D-F645-41B2-8F9F-50A78416F161}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>ExtractCsvAndFillDatabase.Program</StartupObject>
    <RootNamespace>ExtractCsvAndFillDatabase</RootNamespace>
    <AssemblyName>ExtractCsvAndFillDatabase</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <None Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Data.SqlClient
Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try

            ' Step-1: Get Datatable
            Dim oDataTable = GetDataTableFromDocument("sample.pdf")

            ' PLEASE NOTE Please Replace With your connection String, You need to have "PersonData" table into your database.
            ' You can find that table from Scripts.sql file
            Dim connectionString As String = "Data Source=DESKTOP-92VMCQG\SQLEXPRESS;Initial Catalog=SampleDatabase;Persist Security Info=True;User ID=sa;Password=Hiren@009"

            ' Step-2: Insert into database
            InsertIntoSqlServerDatabase(oDataTable, connectionString)

            ' Step-3: Fetch from database and display results
            DisplayDatabaseResults(connectionString)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()
    End Sub

    ''' <summary>
    ''' Inserts into Sql Server database
    ''' </summary>
    Private Sub InsertIntoSqlServerDatabase(ByVal oDataTable As DataTable, ByVal connectionString As String)

        Using con As SqlConnection = New SqlConnection(connectionString)

            ' Open connection
            con.Open()

            ' Sql query to insert data
            Dim cmdInsert As String = "Insert into PersonData (id, first_name, last_name, email, gender, ip_address) values (@id, @first_name, @last_name, @email, @gender, @ip_address)"

            For Each itmRow As DataRow In oDataTable.Rows

                ' Prepare sql command
                Dim cmd As SqlCommand = New SqlCommand(cmdInsert, con)
                cmd.CommandType = CommandType.Text

                cmd.Parameters.Add(New SqlParameter("@id", Convert.ToString(itmRow("id"))))
                cmd.Parameters.Add(New SqlParameter("@first_name", Convert.ToString(itmRow("first_name"))))
                cmd.Parameters.Add(New SqlParameter("@last_name", Convert.ToString(itmRow("last_name"))))
                cmd.Parameters.Add(New SqlParameter("@email", Convert.ToString(itmRow("email"))))
                cmd.Parameters.Add(New SqlParameter("@gender", Convert.ToString(itmRow("gender"))))
                cmd.Parameters.Add(New SqlParameter("@ip_address", Convert.ToString(itmRow("ip_address"))))

                ' Execute sql command
                cmd.ExecuteNonQuery()
            Next

            ' Close connection
            con.Close()

        End Using

    End Sub

    ' Displays inserted database results
    Private Sub DisplayDatabaseResults(ByVal connectionString As String)

        ' Person data holder
        Dim personDataTable As DataTable = New DataTable()

        Using con As SqlConnection = New SqlConnection(connectionString)

            ' Sql query to fetch data
            Dim cmdInsert As String = "SELECT id, first_name, last_name, email, gender, ip_address FROM PersonData;"

            ' Prepare sql command
            Dim cmd As SqlCommand = New SqlCommand(cmdInsert, con)
            cmd.CommandType = CommandType.Text

            ' Prepare DataAdapter 
            Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter(cmd)

            ' Fill person dataTable
            dataAdapter.Fill(personDataTable)

        End Using

        ' Display all person data if any
        If personDataTable IsNot Nothing AndAlso personDataTable.Rows.Count > 0 Then

            ' Print all columns
            For Each column As DataColumn In personDataTable.Columns
                Console.Write("{0} | ", column.ColumnName)
            Next
            Console.WriteLine()

            ' Print all data
            For Each dataRow As DataRow In personDataTable.Rows

                For Each column As DataColumn In personDataTable.Columns
                    Console.Write("{0} | ", dataRow(column.ColumnName))
                Next

                Console.WriteLine()
            Next
        Else
            Console.WriteLine("No data retrieved..")
        End If
    End Sub

    ''' <summary>
    ''' Get DataTable from Document
    ''' </summary>
    Private Function GetDataTableFromDocument(ByVal fileName As String) As DataTable
        Dim oDataTable As DataTable = Nothing

        ' Initialise table detector
        Using tableDetector As TableDetector = New TableDetector("demo", "demo")

            Using CSVExtractor As CSVExtractor = New CSVExtractor("demo", "demo")

                ' Set table detection mode to "bordered tables" - best for tables with closed solid borders.
                tableDetector.ColumnDetectionMode = ColumnDetectionMode.BorderedTables

                ' We should define what kind of tables we should detect.
                ' So we set min required number of columns to 2 ...
                tableDetector.DetectionMinNumberOfColumns = 2
                ' ... and we set min required number of rows to 2
                tableDetector.DetectionMinNumberOfRows = 2

                ' Load PDF document
                tableDetector.LoadDocumentFromFile(fileName)
                CSVExtractor.LoadDocumentFromFile(fileName)

                ' Get page count
                Dim pageCount As Integer = tableDetector.GetPageCount()

                If tableDetector.FindTable(0) Then
                    ' Set extraction area for CSV extractor to rectangle received from the table detector
                    CSVExtractor.SetExtractionArea(tableDetector.FoundTableLocation)

                    ' Generate CSV data
                    Dim allCsvData = CSVExtractor.GetCSV()

                    ' Generate Datatable
                    oDataTable = GetDataTableFromCSV(allCsvData)
                End If
            End Using
        End Using

        Return oDataTable
    End Function

    ''' <summary>
    ''' Get Datatable from CSV
    ''' </summary>
    Private Function GetDataTableFromCSV(ByVal allCsvData As String) As DataTable

        Dim oRetDataTable = New DataTable()
        oRetDataTable.Columns.Add("id")
        oRetDataTable.Columns.Add("first_name")
        oRetDataTable.Columns.Add("last_name")
        oRetDataTable.Columns.Add("email")
        oRetDataTable.Columns.Add("gender")
        oRetDataTable.Columns.Add("ip_address")

        Dim rows = allCsvData.Split(vbLf)

        For iRow As Integer = 1 To rows.Length - 1

            ' Get all column data
            Dim columns = rows(iRow).Split(","c)

            If columns.Length >= 5 Then
                ' Prepare new row
                Dim oRow = oRetDataTable.NewRow()
                oRow("id") = columns(0)
                oRow("first_name") = columns(1)
                oRow("last_name") = columns(2)
                oRow("email") = columns(3)
                oRow("gender") = columns(4)
                oRow("ip_address") = columns(5)

                ' Add row back to datatable
                oRetDataTable.Rows.Add(oRow)
            End If
        Next

        ' Return DataTable
        Return oRetDataTable
    End Function

End Module

```

<!-- code block end -->