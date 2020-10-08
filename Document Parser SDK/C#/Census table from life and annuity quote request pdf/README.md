## census table from life and annuity quote request pdf in C# using ByteScout Document Parser SDK What is ByteScout Document Parser SDK? It is the template based data extraction engine can process thousands and millions of documents per day based on templates. Can work online and offline for privacy focused tasks. Templates can be supported and updated without any programming or technical knowledge required. Output is generated in JSON, CSV, XML and custom format if required.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Document%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Document%20Parser%20SDK%20Question) 

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

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### **LifeAndAnnuityQuoteRequest.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A73776C6-D2B2-4E37-B852-06C6454D1B5B}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>LifeAndAnnuityQuoteRequest</RootNamespace>
    <AssemblyName>LifeAndAnnuityQuoteRequest</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
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
    <Reference Include="ByteScout.DocumentParser, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Document Parser SDK\net40\ByteScout.DocumentParser.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
      <HintPath>packages\Newtonsoft.Json.12.0.3\lib\net40\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="SampleGroupDisabilityForm.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="SampleGroupDisabilityForm.yml">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="packages.config" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **LifeAndAnnuityQuoteRequest.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2018
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "LifeAndAnnuityQuoteRequest", "LifeAndAnnuityQuoteRequest.csproj", "{A73776C6-D2B2-4E37-B852-06C6454D1B5B}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A73776C6-D2B2-4E37-B852-06C6454D1B5B}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A73776C6-D2B2-4E37-B852-06C6454D1B5B}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A73776C6-D2B2-4E37-B852-06C6454D1B5B}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A73776C6-D2B2-4E37-B852-06C6454D1B5B}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {7E6DAA79-020B-421A-844A-5FE05EFC9B15}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **Program.cs:**
    
```
using ByteScout.DocumentParser;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LifeAndAnnuityQuoteRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample document containing life and annuity quote request form
            string sampleDocument = @".\SampleGroupDisabilityForm.pdf";

            // Sample template
            string sampleTemplate = @".\SampleGroupDisabilityForm.yml";

            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                // Add sample template
                documentParser.AddTemplate(sampleTemplate);

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON);

                // Parse to Json Fields
                var oRet = ParseJsonFields(jsonString);

                // Display some of data to console
                Console.WriteLine("Parsing Details:\n------------------------");

                Console.WriteLine($"Contact Person: {oRet.ContactPerson}");
                Console.WriteLine($"Business Name: {oRet.BusinessName}");
                Console.WriteLine($"Business Address: {oRet.BusinessAddress}");
                Console.WriteLine($"Business Type: {oRet.BusinessType}");
                Console.WriteLine($"Phone: {oRet.Phone}");
                Console.WriteLine($"Email: {oRet.Email}");

                // Export list of census to csv format
                var csvOutputFile = "result.csv";

                var csvString = ConvertToCsv(oRet.lstCensusTable);
                File.WriteAllText(csvOutputFile, csvString);

                Console.WriteLine($"\n{csvOutputFile} generated successfully!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Parser Json Fields
        /// </summary>
        public static FormVM ParseJsonFields(string jsonInput)
        {
            JObject jsonObj = JObject.Parse(jsonInput);

            var oRet = new FormVM();
            oRet.ContactPerson = Convert.ToString(jsonObj["fields"]["contactPerson"]["value"]);
            oRet.BusinessName = Convert.ToString(jsonObj["fields"]["businessName"]["value"]);
            oRet.BusinessAddress = Convert.ToString(jsonObj["fields"]["businessAddress"]["value"]);
            oRet.BusinessType = Convert.ToString(jsonObj["fields"]["businessType"]["value"]);
            oRet.Phone = Convert.ToString(jsonObj["fields"]["phone"]["value"]);
            oRet.Email = Convert.ToString(jsonObj["fields"]["email"]["value"]);

            var censusTable = jsonObj["tables"].Where(x => x.Value<string>("name") == "CencusTable");

            if(censusTable != null)
            {
                var rows = censusTable.Values("rows").First();

                if(rows != null && rows.Count() > 1)
                {

                    for (int i = 1; i < rows.Count(); i++)
                    {
                        var oCensus = new CensusTableVm();
                        
                        // Parser individual data
                        oCensus.SrNo = rows.ElementAt(i).ElementAt(0).ElementAt(0).Value<string>("value");
                        oCensus.DOB = rows.ElementAt(i).ElementAt(1).ElementAt(0).Value<string>("value");
                        oCensus.Gender = rows.ElementAt(i).ElementAt(2).ElementAt(0).Value<string>("value");
                        oCensus.Occupation = rows.ElementAt(i).ElementAt(3).ElementAt(0).Value<string>("value");
                        oCensus.Salary = rows.ElementAt(i).ElementAt(4).ElementAt(0).Value<string>("value");
                        oCensus.IsShortTermDisability = rows.ElementAt(i).ElementAt(5).ElementAt(0).Value<string>("value");
                        oCensus.IsLongTernDisability = rows.ElementAt(i).ElementAt(6).ElementAt(0).Value<string>("value");
                        oCensus.LifeInsuCoverAmt = rows.ElementAt(i).ElementAt(7).ElementAt(0).Value<string>("value");

                        oRet.lstCensusTable.Add(oCensus);
                    }
                }
            }

            return oRet;
        }

        /// <summary>
        /// Convert to Csv Format
        /// </summary>
        public static string ConvertToCsv(List<CensusTableVm> lstCensusTable)
        {
            var oRet = new StringBuilder(string.Empty);

            // Get Header Row
            oRet.AppendLine(CensusTableVm.getCsvTitleRow());

            // Put Child Rows
            foreach (var item in lstCensusTable)
            {
                oRet.AppendLine(item.ToString());
            }

            return oRet.ToString();
        }

    }

    class FormVM
    {
        public string ContactPerson { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<CensusTableVm> lstCensusTable { get; set; } = new List<CensusTableVm>();
    }

    class CensusTableVm
    {
        public string SrNo { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Salary { get; set; }
        public string IsShortTermDisability { get; set; }
        public string IsLongTernDisability { get; set; }
        public string LifeInsuCoverAmt { get; set; }

        public override string ToString()
        {
            return $"{SrNo},{DOB},{Gender},{Occupation},{Salary},{IsShortTermDisability},{IsLongTernDisability},{LifeInsuCoverAmt}";
        }

        public static string getCsvTitleRow()
        {
            return $"SrNo,DOB,Gender,Occupation,Salary,IsShortTermDisability,IsLongTermDisability,LifeInsuCoverAmt";
        }

    }

}

```

<!-- code block end -->    

<!-- code block begin -->

##### **SampleGroupDisabilityForm.yml:**
    
```
templateName: Untitled document kind
templateVersion: 4
templatePriority: 0
detectionRules:
  keywords: []
objects:
- name: CencusTable
  objectType: table
  tableProperties:
    start:
      y: 324.75
      pageIndex: 0
    end:
      y: 683.25
      pageIndex: 0
    left: 27
    right: 581.25
    rowMergingRule: byBorders
- name: ContactPerson
  objectType: field
  fieldProperties:
    fieldType: rectangle
    regex: true
    rectangle:
    - 178.5
    - 111
    - 76.5
    - 15
    pageIndex: 0
- name: BusinessName
  objectType: field
  fieldProperties:
    fieldType: rectangle
    regex: true
    rectangle:
    - 177.75
    - 126
    - 105
    - 17.25
    pageIndex: 0
- name: BusinessAddress
  objectType: field
  fieldProperties:
    fieldType: rectangle
    regex: true
    rectangle:
    - 183
    - 144.75
    - 187.5
    - 24
    pageIndex: 0
- name: BusinessType
  objectType: field
  fieldProperties:
    fieldType: rectangle
    regex: true
    rectangle:
    - 183.75
    - 206.25
    - 77.25
    - 19.5
    pageIndex: 0
- name: Phone
  objectType: field
  fieldProperties:
    fieldType: rectangle
    regex: true
    rectangle:
    - 181.5
    - 236.25
    - 86.25
    - 15
    pageIndex: 0
- name: Email
  objectType: field
  fieldProperties:
    fieldType: rectangle
    regex: true
    rectangle:
    - 182.25
    - 250.5
    - 112.5
    - 17.25
    pageIndex: 0


```

<!-- code block end -->    

<!-- code block begin -->

##### **packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Newtonsoft.Json" version="12.0.3" targetFramework="net40" />
</packages>
```

<!-- code block end -->