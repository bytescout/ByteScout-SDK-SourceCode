## How to convert txt to sql server with spreadsheet sdk in VB.NET using ByteScout Barcode Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to convert txt to sql server with spreadsheet sdk in VB.NET

Quickly learn how to convert txt to sql server with spreadsheet sdk in VB.NET with this sample source code. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can convert txt to sql server with spreadsheet sdk in VB.NET.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for VB.NET plus the guidelines and the code below will help you quickly learn how to convert txt to sql server with spreadsheet sdk. IF you want to implement the functionality, just copy and paste this code for VB.NET below into your code editor with your app, compile and run your application. This basic programming language sample code for VB.NET will do the whole work for you to convert txt to sql server with spreadsheet sdk.

You can download free trial version of ByteScout Barcode Suite from our website to see and try many others source code samples for VB.NET.

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

##### ****ExportToSQLServer.VS2005.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{32D4ACE8-2E55-40CB-97D5-2E3BFFD5B417}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ExportToSQLServer</RootNamespace>
    <AssemblyName>ExportToSQLServer</AssemblyName>
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
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
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
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Content Include="sample.txt">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ExportToSQLServer.VS2008.vbproj:**
    
```
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{32D4ACE8-2E55-40CB-97D5-2E3BFFD5B417}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ExportToSQLServer</RootNamespace>
    <AssemblyName>ExportToSQLServer</AssemblyName>
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
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
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
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Content Include="sample.txt">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ExportToSQLServer.VS2010.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{32D4ACE8-2E55-40CB-97D5-2E3BFFD5B417}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
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
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Content Include="sample.txt">
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
                ExecuteQueryWithoutResult(connection, "IF DB_ID ('TxtTests') IS NOT NULL DROP DATABASE TxtTests")
                ' Create empty database
                ExecuteQueryWithoutResult(connection, "CREATE DATABASE TxtTests")
                ' Switch to created database
                ExecuteQueryWithoutResult(connection, "USE TxtTests")
                ' Create a table for TXT data
                ExecuteQueryWithoutResult(connection, "CREATE TABLE TxtTest (Name VARCHAR(40), FullName VARCHAR(255))")

                ' Load TXT document
                Using document As New Spreadsheet()
                document.LoadFromFile("sample.txt", vbTab) ' vbTab - TAB delimiter
                    Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

                    For row As Integer = 0 To worksheet.UsedRangeRowMax
                        Dim insertCommand As [String] = String.Format("INSERT TxtTest VALUES('{0}','{1}')", worksheet.Cell(row, 0).Value, worksheet.Cell(row, 1).Value)
                        ExecuteQueryWithoutResult(connection, insertCommand)
                    Next
                End Using

                ' Check the data successfully exported
                Using command As New SqlCommand("SELECT * from TxtTest", connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    If reader IsNot Nothing Then
                        Console.WriteLine()
                        Console.WriteLine("Exported TXT data:")
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

<!-- code block begin -->

##### ****sample.txt:**
    
```
Homer	Homer Jay Simpson
Marjorie	Marjorie Marge Simpson (Bouvier)
Bartholomew	Bartholomew Jojo Bart Simpson
Lisa	Lisa Marie Simpson
Margaret	Margaret Maggie

```

<!-- code block end -->