## How to extract CSV from PDF and fill database (sql server) with PDF extractor SDK in C# with ByteScout Premium Suite

### Learn to code in C# to extract CSV from PDF and fill database (sql server) with PDF extractor SDK with this step-by-step tutorial

On this page you will learn from code samples for programming in C#.Writing of the code to extract CSV from PDF and fill database (sql server) with PDF extractor SDK in C# can be executed by programmers of any level using ByteScout Premium Suite. What is ByteScout Premium Suite? It is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to extract CSV from PDF and fill database (sql server) with PDF extractor SDK in your C# application.

Want to save time? You will save a lot of time on writing and testing code as you may just take the C# code from ByteScout Premium Suite for extract CSV from PDF and fill database (sql server) with PDF extractor SDK below and use it in your application. This C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! If you want to use these C# sample examples in one or many applications then they can be used easily.

If you want to try other source code samples then the free trial version of ByteScout Premium Suite is available for download from our website. Just try other source code samples for C#.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****ExtractCsvAndFillDatabase.NETCore.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyInformationalVersionAttribute>false</GenerateAssemblyInformationalVersionAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyTrademarkAttribute>false</GenerateAssemblyTrademarkAttribute>
    <GenerateAssemblyCultureAttribute>false</GenerateAssemblyCultureAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <None Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="Scripts.sql">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\netcoreapp2.0\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\netcoreapp2.0\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ExtractCsvAndFillDatabase.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ExtractCsvAndFillDatabase</RootNamespace>
    <AssemblyName>ExtractCsvAndFillDatabase</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <Content Include="Scripts.sql" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using Bytescout.PDFExtractor;
using System;
using System.Data;
using System.Data.SqlClient; 

namespace ExtractCsvAndFillDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Step-1: Get Datatable
                var oDataTable = GetDataTableFromDocument("sample.pdf");

                // PLEASE NOTE: Please replace with your connection string, You need to have "PersonData" table into your database.
                // You can find that table from Scripts.sql file
                string connectionString = @"Data Source=REPLACE_WITH_YOUR_DATA_SOURCE;Initial Catalog=DATABASE_NAME;Persist Security Info=True;User ID=USERID;Password=PASSWORD";

                // Step-2: Insert into database
                InsertIntoSqlServerDatabase(oDataTable, connectionString);

                // Step-3: Fetch from database and display results
                DisplayDatabaseResults(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Inserts into Sql Server database
        /// </summary>
        /// <param name="oDataTable"></param>
        private static void InsertIntoSqlServerDatabase(DataTable oDataTable, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open connection
                con.Open();

                // Sql query to insert data
                string cmdInsert = "Insert into PersonData (id, first_name, last_name, email, gender, ip_address) values (@id, @first_name, @last_name, @email, @gender, @ip_address)";

                foreach (DataRow itmRow in oDataTable.Rows)
                {
                    // Prepare sql command
                    SqlCommand cmd = new SqlCommand(cmdInsert, con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add(new SqlParameter("@id", Convert.ToString(itmRow["id"])));
                    cmd.Parameters.Add(new SqlParameter("@first_name", Convert.ToString(itmRow["first_name"])));
                    cmd.Parameters.Add(new SqlParameter("@last_name", Convert.ToString(itmRow["last_name"])));
                    cmd.Parameters.Add(new SqlParameter("@email", Convert.ToString(itmRow["email"])));
                    cmd.Parameters.Add(new SqlParameter("@gender", Convert.ToString(itmRow["gender"])));
                    cmd.Parameters.Add(new SqlParameter("@ip_address", Convert.ToString(itmRow["ip_address"])));

                    // Execute sql command
                    cmd.ExecuteNonQuery();
                }

                // Close connection
                con.Close();
            }
        }

        /// <summary>
        /// Displays inserted database results
        /// </summary>
        private static void DisplayDatabaseResults(string connectionString)
        {
            // Person data holder
            DataTable personDataTable = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Sql query to fetch data
                string cmdInsert = "SELECT id, first_name, last_name, email, gender, ip_address FROM PersonData;";

                // Prepare sql command
                SqlCommand cmd = new SqlCommand(cmdInsert, con);
                cmd.CommandType = CommandType.Text;

                // Prepare DataAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                // Fill person dataTable
                dataAdapter.Fill(personDataTable);
            }

            // Display all person data if any
            if (personDataTable != null && personDataTable.Rows.Count > 0)
            {
                // Print all columns
                foreach (DataColumn column in personDataTable.Columns)
                {
                    Console.Write("{0} | ", column.ColumnName);
                }
                Console.WriteLine();

                // Print all data
                foreach (DataRow dataRow in personDataTable.Rows)
                {
                    foreach (DataColumn column in personDataTable.Columns)
                    {
                        Console.Write("{0} | ", dataRow[column.ColumnName]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No data retrieved..");
            }
        }


        /// <summary>
        /// Get DataTable from Document
        /// </summary>
        private static DataTable GetDataTableFromDocument(string fileName)
        {
            DataTable oDataTable = null;

            // Initialise table detector
            using (TableDetector tableDetector = new TableDetector("demo", "demo"))
            {
                using (CSVExtractor CSVExtractor = new CSVExtractor("demo", "demo"))
                {
                    // Set table detection mode to "bordered tables" - best for tables with closed solid borders.
                    tableDetector.ColumnDetectionMode = ColumnDetectionMode.BorderedTables;

                    // We should define what kind of tables we should detect.
                    // So we set min required number of columns to 2 ...
                    tableDetector.DetectionMinNumberOfColumns = 2;
                    // ... and we set min required number of rows to 2
                    tableDetector.DetectionMinNumberOfRows = 2;

                    // Load PDF document
                    tableDetector.LoadDocumentFromFile(fileName);
                    CSVExtractor.LoadDocumentFromFile(fileName);

                    // Get page count
                    int pageCount = tableDetector.GetPageCount();

                    if (tableDetector.FindTable(0))
                    {
                        // Set extraction area for CSV extractor to rectangle received from the table detector
                        CSVExtractor.SetExtractionArea(tableDetector.FoundTableLocation);

                        // Generate CSV data
                        var allCsvData = CSVExtractor.GetCSV();

                        // Generate Datatable
                        oDataTable = GetDataTableFromCSV(allCsvData);
                    }
                }
            }

            return oDataTable;
        }

        /// <summary>
        /// Get Datatable from CSV
        /// </summary>
        private static DataTable GetDataTableFromCSV(string allCsvData)
        {
            var oRetDataTable = new DataTable();
            oRetDataTable.Columns.Add("id");
            oRetDataTable.Columns.Add("first_name");
            oRetDataTable.Columns.Add("last_name");
            oRetDataTable.Columns.Add("email");
            oRetDataTable.Columns.Add("gender");
            oRetDataTable.Columns.Add("ip_address");

            var rows = allCsvData.Split('\n');

            // Ignore first column line
            for (int iRow = 1; iRow < rows.Length; iRow++)
            {
                // Get all column data
                var columns = rows[iRow].Split(',');

                if (columns.Length >= 5)
                {
                    // Prepare new row
                    var oRow = oRetDataTable.NewRow();
                    oRow["id"] = columns[0];
                    oRow["first_name"] = columns[1];
                    oRow["last_name"] = columns[2];
                    oRow["email"] = columns[3];
                    oRow["gender"] = columns[4];
                    oRow["ip_address"] = columns[5];

                    // Add row back to datatable
                    oRetDataTable.Rows.Add(oRow);
                }
            }

            // Return DataTable
            return oRetDataTable;
        }
    }
}

```

<!-- code block end -->