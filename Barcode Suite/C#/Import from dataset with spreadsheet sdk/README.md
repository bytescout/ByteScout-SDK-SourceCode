## How to import from dataset with spreadsheet sdk in C# using ByteScout Barcode Suite

### Step-by-step tutorial on how to import from dataset with spreadsheet sdk in C#

The sample source codes on this page shows how to import from dataset with spreadsheet sdk in C#. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can be applied to import from dataset with spreadsheet sdk using C#.

Want to save time? You will save a lot of time on writing and testing code as you may just take the C# code from ByteScout Barcode Suite for import from dataset with spreadsheet sdk below and use it in your application. This C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! This basic programming language sample code for C# will do the whole work for you to import from dataset with spreadsheet sdk.

You can download free trial version of ByteScout Barcode Suite from our website to see and try many others source code samples for C#.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****ImportFromDataSet.VS2005.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{E5EA0752-F7F7-437F-B6D0-16B0F7AA4E6D}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataSet</RootNamespace>
    <AssemblyName>Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataSet</AssemblyName>
    <TargetFrameworkProfile>
    </TargetFrameworkProfile>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
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

##### ****ImportFromDataSet.VS2008.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{E5EA0752-F7F7-437F-B6D0-16B0F7AA4E6D}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataSet</RootNamespace>
    <AssemblyName>Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataSet</AssemblyName>
    <TargetFrameworkProfile>
    </TargetFrameworkProfile>
    <FileAlignment>512</FileAlignment>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
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

##### ****ImportFromDataSet.VS2010.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{E5EA0752-F7F7-437F-B6D0-16B0F7AA4E6D}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataSet</RootNamespace>
    <AssemblyName>Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataSet</AssemblyName>
    <TargetFrameworkProfile>
    </TargetFrameworkProfile>
    <FileAlignment>512</FileAlignment>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.Spreadsheet, Version=2.3.0.750, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\Bytescout.Spreadsheet.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
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

##### ****Program.cs:**
    
```
using System.Data;
using System.Diagnostics;
using System.IO;

namespace Bytescout.Spreadsheet.Demo.Csharp.ImportFromDataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "CSharpImportFromDataSet.xls";

            // Create a new spreadsheet
            Spreadsheet spreadsheet = new Spreadsheet();

            // Get the data from the dataset that we wish to import
            DataSet periodicTableAndScientists = GetDataSet();

            // Import data into spreadheet
            spreadsheet.ImportFromDataSet(periodicTableAndScientists);

			// Insert row with column captions
			for (int i = 0; i < periodicTableAndScientists.Tables.Count; i++)
			{
				DataTable dataTable = periodicTableAndScientists.Tables[i];
				Worksheet worksheet = spreadsheet.Worksheets[i];

				worksheet.Rows.Insert(0);

				for (int colIndex = 0; colIndex < dataTable.Columns.Count; colIndex++)
				{
					worksheet.Cell(0, colIndex).Value = dataTable.Columns[colIndex].Caption;
				}
			}

            // Save the spreadsheet
            if (File.Exists(fileName)) File.Delete(fileName);
            spreadsheet.SaveAs(fileName);

            // Close spreadsheet
            spreadsheet.Close();

            // Open the spreadsheet
            Process.Start(fileName);
        }

        /// <summary>
        /// Creates a data set of the periodic table of elements and some famous scientists
        /// </summary>
        /// <returns>A data set of the periodic table of elements and some scientists</returns>
        private static DataSet GetDataSet()
        {
            DataTable periodicTable = GetDataTableOfElements();
            DataTable scientists = GetDataTableOfScientists();

            DataSet dataset = new DataSet();
            dataset.Tables.Add(periodicTable);
            dataset.Tables.Add(scientists);
            
            return dataset;
        }


        /// <summary>
        /// Creates a data table of the periodic table of elements
        /// </summary>
        /// <returns>A data table of the periodic table of elements</returns>
        private static DataTable GetDataTableOfElements()
        {
            DataTable periodicTable = new DataTable("PeriodicTable");

            periodicTable.Columns.Add("Name", typeof(string));
            periodicTable.Columns.Add("Symbol", typeof(string));
            periodicTable.Columns.Add("AtomicNumber", typeof(int));

            DataRow dr = periodicTable.Rows.Add();
            dr[0] = "Hydrogen";
            dr[1] = "H";
            dr[2] = "1";

            dr = periodicTable.Rows.Add();
            dr[0] = "Helium";
            dr[1] = "He";
            dr[2] = "2";

            dr = periodicTable.Rows.Add();
            dr[0] = "Lithium";
            dr[1] = "Li";
            dr[2] = "3";

            dr = periodicTable.Rows.Add();
            dr[0] = "Beryllium";
            dr[1] = "Be";
            dr[2] = "4";

            dr = periodicTable.Rows.Add();
            dr[0] = "Boron";
            dr[1] = "B";
            dr[2] = "5";

            dr = periodicTable.Rows.Add();
            dr[0] = "Carbon";
            dr[1] = "C";
            dr[2] = "6";

            return periodicTable;
        }

        /// <summary>
        /// Creates a data table of scientists
        /// </summary>
        /// <returns>A data table of scientists</returns>
        private static DataTable GetDataTableOfScientists()
        {
            DataTable scientistsTable = new DataTable("Scientists");

            scientistsTable.Columns.Add("Name", typeof(string));

            DataRow dr = scientistsTable.Rows.Add();
            dr[0] = "Antoine Lavoisier";

            dr = scientistsTable.Rows.Add();
            dr[0] = "Julius Lothar Meyer ";

            dr = scientistsTable.Rows.Add();
            dr[0] = "Dmitri Ivanovich Mendeleev";

            return scientistsTable;
        }
    }
}

```

<!-- code block end -->