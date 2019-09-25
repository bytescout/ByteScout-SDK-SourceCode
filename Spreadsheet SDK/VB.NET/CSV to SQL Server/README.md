## CSV to SQL server in VB.NET with ByteScout Spreadsheet SDK

### How to code CSV to SQL server in VB.NET: How-To tutorial

The documentation is designed to help you to implement the features on your side. CSV to SQL server in VB.NET can be implemented with ByteScout Spreadsheet SDK. ByteScout Spreadsheet SDK is the SDK component for writing, reading, modifying and calculating Excel and CSV spreadsheets. Can calculate and reculculate formulas with Excel installed. You may import or export data to and from CSV, XML, JSON. Supports export to databases, arrays, streams.

VB.NET, code samples for VB.NET, developers help to speed up the application development and writing a code when using ByteScout Spreadsheet SDK. To do CSV to SQL server in your VB.NET project or application you may simply copy & paste the code and then run your app! Further enhancement of the code will make it more vigorous.

Free trial version of ByteScout Spreadsheet SDK is available on our website. Get it to try other samples for VB.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Spreadsheet%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Spreadsheet%20SDK%20Question) 

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

##### ****ExportToSQLServer.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "ExportToSQLServer", "ExportToSQLServer.vbproj", "{5157686C-6640-4960-A8E1-CCE4C18C46EF}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{5157686C-6640-4960-A8E1-CCE4C18C46EF}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{5157686C-6640-4960-A8E1-CCE4C18C46EF}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{5157686C-6640-4960-A8E1-CCE4C18C46EF}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{5157686C-6640-4960-A8E1-CCE4C18C46EF}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ExportToSQLServer.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{5157686C-6640-4960-A8E1-CCE4C18C46EF}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ExportToSQLServer</RootNamespace>
    <AssemblyName>ExportToSQLServer</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="Bytescout.Spreadsheet, Version=2.2.0.307, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Content Include="sample.csv">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports Bytescout.Spreadsheet
Imports System.Data.SqlClient

Class Program
    Friend Shared Sub Main(args As String())
        Try
            ' MODIFY THE CONNECTION STRING WITH YOUR CREDENTIALS!!!
            Dim connectionString As String = "Data Source=localhost;Initial Catalog=master;Integrated Security=true;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Drop test database if exists
                ExecuteQueryWithoutResult(connection, "IF DB_ID ('CsvTests') IS NOT NULL DROP DATABASE CsvTests")
                ' Create empty database
                ExecuteQueryWithoutResult(connection, "CREATE DATABASE CsvTests")
                ' Switch to created database
                ExecuteQueryWithoutResult(connection, "USE CsvTests")
                ' Create a table for CSV data
                ExecuteQueryWithoutResult(connection, "CREATE TABLE CsvTest (Name VARCHAR(40), FullName VARCHAR(255))")

                ' Load CSV document
                Using document As New Spreadsheet()
                    document.LoadFromFile("sample.csv", ";") ' ";" - delimiter
                    Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

                    For row As Integer = 0 To worksheet.UsedRangeRowMax
                        Dim insertCommand As [String] = String.Format("INSERT CsvTest VALUES('{0}','{1}')",
                                                                      worksheet.Cell(row, 0).Value,
                                                                      worksheet.Cell(row, 1).Value)
                        ExecuteQueryWithoutResult(connection, insertCommand)
                    Next
                End Using

                ' Check the data successfully exported
                Using command As New SqlCommand("SELECT * from CsvTest", connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader IsNot Nothing Then
                        Console.WriteLine()
                        Console.WriteLine("Exported CSV data:")
                        Console.WriteLine()

                        While reader.Read()
                            Console.WriteLine([String].Format("{0}  |  {1}", reader(0), reader(1)))
                        End While
                    End If
                End Using

                Console.WriteLine()
                Console.WriteLine("Press any key.")
                Console.ReadKey()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.ReadKey()
        End Try
    End Sub

    Private Shared Sub ExecuteQueryWithoutResult(connection As SqlConnection, query As String)
        Using command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class

```

<!-- code block end -->