## PDF invoices to google sheets in C# and ByteScout Robotic Process Automation ByteScout Robotic Process Automation is set of tools for rapid implementation of robotic process automation applications.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Robotic%20Process%20Automation%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Robotic%20Process%20Automation%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gEjuZ0zgtHo](https://www.youtube.com/watch?v=gEjuZ0zgtHo)




<!-- code block begin -->

##### **InvoicesToGoogleSheets.VS2015.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{BF74D299-912C-4259-A022-71628F76F2B9}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>InvoicesToGoogleSheets</RootNamespace>
    <AssemblyName>InvoicesToGoogleSheets</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <NuGetPackageImportStamp>
    </NuGetPackageImportStamp>
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
    <Reference Include="BouncyCastle.Crypto, Version=1.7.4137.9688, Culture=neutral, PublicKeyToken=a4292a325f69b123, processorArchitecture=MSIL">
      <HintPath>packages\BouncyCastle.1.7.0\lib\Net40-Client\BouncyCastle.Crypto.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor, Version=6.30.0.2431, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Google.Apis, Version=1.10.0.25332, Culture=neutral, PublicKeyToken=4b01fa6e34db77ab, processorArchitecture=MSIL">
      <HintPath>packages\Google.Apis.1.10.0\lib\net40\Google.Apis.dll</HintPath>
    </Reference>
    <Reference Include="Google.Apis.Auth, Version=1.10.0.25333, Culture=neutral, PublicKeyToken=4b01fa6e34db77ab, processorArchitecture=MSIL">
      <HintPath>packages\Google.Apis.Auth.1.10.0\lib\net40\Google.Apis.Auth.dll</HintPath>
    </Reference>
    <Reference Include="Google.Apis.Auth.PlatformServices, Version=1.10.0.25333, Culture=neutral, PublicKeyToken=4b01fa6e34db77ab, processorArchitecture=MSIL">
      <HintPath>packages\Google.Apis.Auth.1.10.0\lib\net40\Google.Apis.Auth.PlatformServices.dll</HintPath>
    </Reference>
    <Reference Include="Google.Apis.Core, Version=1.10.0.25331, Culture=neutral, PublicKeyToken=4b01fa6e34db77ab, processorArchitecture=MSIL">
      <HintPath>packages\Google.Apis.Core.1.10.0\lib\portable-net40+sl50+win+wpa81+wp80\Google.Apis.Core.dll</HintPath>
    </Reference>
    <Reference Include="Google.Apis.PlatformServices, Version=1.10.0.25332, Culture=neutral, PublicKeyToken=4b01fa6e34db77ab, processorArchitecture=MSIL">
      <HintPath>packages\Google.Apis.1.10.0\lib\net40\Google.Apis.PlatformServices.dll</HintPath>
    </Reference>
    <Reference Include="Google.Apis.Sheets.v4, Version=1.45.0.1930, Culture=neutral, PublicKeyToken=4b01fa6e34db77ab, processorArchitecture=MSIL">
      <HintPath>packages\Google.Apis.Sheets.v4.1.45.0.1930\lib\net40\Google.Apis.Sheets.v4.dll</HintPath>
    </Reference>
    <Reference Include="log4net, Version=1.2.13.0, Culture=neutral, PublicKeyToken=669e0ddf0bb1aa2a, processorArchitecture=MSIL">
      <HintPath>packages\log4net.2.0.3\lib\net40-full\log4net.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Threading.Tasks, Version=1.0.12.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Bcl.Async.1.0.168\lib\net40\Microsoft.Threading.Tasks.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Threading.Tasks.Extensions, Version=1.0.12.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Bcl.Async.1.0.168\lib\net40\Microsoft.Threading.Tasks.Extensions.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Threading.Tasks.Extensions.Desktop, Version=1.0.168.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Bcl.Async.1.0.168\lib\net40\Microsoft.Threading.Tasks.Extensions.Desktop.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json, Version=7.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
      <HintPath>packages\Newtonsoft.Json.7.0.1\lib\net40\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.IO, Version=2.6.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Bcl.1.1.10\lib\net40\System.IO.dll</HintPath>
    </Reference>
    <Reference Include="System.Net" />
    <Reference Include="System.Net.Http, Version=2.2.29.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Net.Http.2.2.29\lib\net40\System.Net.Http.dll</HintPath>
    </Reference>
    <Reference Include="System.Net.Http.Extensions, Version=2.2.29.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Net.Http.2.2.29\lib\net40\System.Net.Http.Extensions.dll</HintPath>
    </Reference>
    <Reference Include="System.Net.Http.Primitives, Version=2.2.29.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Net.Http.2.2.29\lib\net40\System.Net.Http.Primitives.dll</HintPath>
    </Reference>
    <Reference Include="System.Net.Http.WebRequest, Version=2.2.29.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Net.Http.2.2.29\lib\net40\System.Net.Http.WebRequest.dll</HintPath>
    </Reference>
    <Reference Include="System.Runtime, Version=2.6.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Bcl.1.1.10\lib\net40\System.Runtime.dll</HintPath>
    </Reference>
    <Reference Include="System.Threading.Tasks, Version=2.6.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.Bcl.1.1.10\lib\net40\System.Threading.Tasks.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Extensions" />
    <Reference Include="System.Xml" />
    <Reference Include="Zlib.Portable, Version=1.11.0.0, Culture=neutral, PublicKeyToken=431cba815f6a8b5b, processorArchitecture=MSIL">
      <HintPath>packages\Zlib.Portable.Signed.1.11.0\lib\portable-net4+sl5+wp8+win8+wpa81+MonoTouch+MonoAndroid\Zlib.Portable.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="app.config" />
    <None Include="credentials.json">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="packages.config" />
    <None Include="Sample_Files\InvoiceApr.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="Sample_Files\InvoiceMar.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
  <Import Project="packages\Microsoft.Bcl.Build.1.0.21\build\Microsoft.Bcl.Build.targets" Condition="Exists('packages\Microsoft.Bcl.Build.1.0.21\build\Microsoft.Bcl.Build.targets')" />
  <Target Name="EnsureNuGetPackageBuildImports" BeforeTargets="PrepareForBuild">
    <PropertyGroup>
      <ErrorText>This project references NuGet package(s) that are missing on this computer. Use NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=322105. The missing file is {0}.</ErrorText>
    </PropertyGroup>
    <Error Condition="!Exists('packages\Microsoft.Bcl.Build.1.0.21\build\Microsoft.Bcl.Build.targets')" Text="$([System.String]::Format('$(ErrorText)', 'packages\Microsoft.Bcl.Build.1.0.21\build\Microsoft.Bcl.Build.targets'))" />
  </Target>
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **InvoicesToGoogleSheets.VS2015.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.29001.49
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "InvoicesToGoogleSheets.VS2015", "InvoicesToGoogleSheets.VS2015.csproj", "{BF74D299-912C-4259-A022-71628F76F2B9}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{BF74D299-912C-4259-A022-71628F76F2B9}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{BF74D299-912C-4259-A022-71628F76F2B9}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{BF74D299-912C-4259-A022-71628F76F2B9}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{BF74D299-912C-4259-A022-71628F76F2B9}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {EDABDEE2-49E8-4139-9277-143673CEC8F3}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **Program.cs:**
    
```
using Bytescout.PDFExtractor;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;

namespace InvoicesToGoogleSheets
{
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = new string[] { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Google Sheets Demo";

        static void Main(string[] args)
        {
            var allInputFiles = new string[] { "Sample_Files\\InvoiceMar.pdf", "Sample_Files\\InvoiceApr.pdf" };

            // Google Sheet data to write
            var reqRowData = new List<RowData>();

            // Set page index
            var pageIndex = 0;

            // Loop through all input files
            foreach (var itmFile in allInputFiles)
            {
                var invName = Path.GetFileNameWithoutExtension(itmFile);

                // Create TextExtractor instance
                using (var tableExtractor = new StructuredExtractor("demo", "demo"))
                {
                    var tableExtractionArea = GetTableExtractionArea(itmFile);
                    if (tableExtractionArea.HasValue)
                    {
                        // Load document from file
                        tableExtractor.LoadDocumentFromFile(itmFile);

                        // Set extraction area
                        tableExtractor.SetExtractionArea(tableExtractionArea.Value);

                        // Prepare table structure
                        tableExtractor.PrepareStructure(pageIndex);

                        int rowCount = tableExtractor.GetRowCount(pageIndex);

                        // Ignoring first title row
                        for (int row = 1; row < rowCount; row++)
                        {
                            // Google Sheet RowData Input
                            var itmRowData = new RowData();

                            // Google Sheet CellData Input
                            var lstCellData = new List<CellData>();

                            int columnCount = tableExtractor.GetColumnCount(pageIndex, row);

                            // Add invName to CellData Collection
                            lstCellData.Add(new CellData { UserEnteredValue = new ExtendedValue() { StringValue = invName } });

                            for (int col = 0; col < columnCount; col++)
                            {
                                // Get table cell value
                                var tableCellValue = tableExtractor.GetCellValue(pageIndex, row, col);

                                // Google Sheet CellData Input
                                var itmCellData = new CellData { UserEnteredValue = new ExtendedValue() { StringValue = tableCellValue } };

                                // Add to CellData Collection
                                lstCellData.Add(itmCellData);
                            }

                            // Add to Google Sheet RowData Request
                            reqRowData.Add(new RowData { Values = lstCellData });
                        }
                    }
                }
            }

            // Proceed with writing to Google Sheets
            UserCredential credential;

            // Follow article "https://developers.google.com/sheets/api/quickstart/dotnet" to generate credentials.json
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completed for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;

                Console.WriteLine($"Credential file saved to : {credPath}");
            }

            // Create Google Sheets API Service
            var service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            // Fill following parameter with your google spreadsheet Id
            // Usually find at url of spreadsheet: https://docs.google.com/spreadsheets/d/...ThisIsSpreadsheetId.../edit
            var spreadsheetId = "xxxxxxSpreadsheetIdxxxxxxxxxx";

            // Get exising row counts
            var existingRowCount = service.Spreadsheets.Values.Get(spreadsheetId, range: "A1:D").Execute().Values.Count;

            var lstRequsts = new List<Request>();
            lstRequsts.Add(new Request
            {
                // New data to be written
                UpdateCells = new UpdateCellsRequest()
                {
                    Range = new GridRange { StartRowIndex = existingRowCount, StartColumnIndex = 0 },
                    Rows = reqRowData,
                    Fields = "*"
                }
            });

            // Prepare batch update spreadsheet request
            var batchUpdateSpreadsheetRequest = new BatchUpdateSpreadsheetRequest()
            {
                Requests = lstRequsts
            };
            var batchUpdateRequest = service.Spreadsheets.BatchUpdate(batchUpdateSpreadsheetRequest, spreadsheetId);

            // Perform google sheet updation
            batchUpdateRequest.Execute();

            Console.WriteLine("Google spreadsheet updated!");
            Console.ReadLine();
        }

        /// <summary>
        /// Gets table extraction area
        /// </summary>
        private static RectangleF? GetTableExtractionArea(string inputFile, int pageIndex = 0)
        {
            // Create Bytescout.PDFExtractor.TableDetector instance
            using (var tableDetector = new TableDetector("demo", "demo"))
            {
                // Set table detection mode to "bordered tables" - best for tables with closed solid borders.
                tableDetector.ColumnDetectionMode = ColumnDetectionMode.BorderedTables;

                // We should define what kind of tables we should detect.
                // So we set min required number of columns to 2 ...
                tableDetector.DetectionMinNumberOfColumns = 2;
                // ... and we set min required number of rows to 2
                tableDetector.DetectionMinNumberOfRows = 2;

                tableDetector.LoadDocumentFromFile(inputFile);

                if (!tableDetector.FindTable(pageIndex))
                {
                    return null;
                }

                // Getting first found table location
                return tableDetector.FoundTableLocation;
            }


        }

    }
}

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

##### **credentials.json:**
    
```
/*
=====================================================
Follow article https://developers.google.com/sheets/api/quickstart/dotnet to get credentials.json
=====================================================
*/
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