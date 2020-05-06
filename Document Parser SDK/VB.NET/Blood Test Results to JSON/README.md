## blood test results to JSON in VB.NET using ByteScout Document Parser SDK ByteScout Document Parser SDK is the customizable data extraction platform for batch data extraction from documents. Relies on special templates that can be created with no special technical skills required. Supports millions of documents as input and designed to handle multiple threads. Can output data as JSON, CSV, XML or custom format.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Document%20Parser%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Document%20Parser%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=MG5FfTWWSVE](https://www.youtube.com/watch?v=MG5FfTWWSVE)




<!-- code block begin -->

##### **BloodTestResultsToJson.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "BloodTestResultsToJson", "BloodTestResultsToJson.vbproj", "{A5FA1293-C15B-4249-A771-ED4301658454}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A5FA1293-C15B-4249-A771-ED4301658454}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A5FA1293-C15B-4249-A771-ED4301658454}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {DCA85560-1523-40E0-917A-5BB3AA7E031F}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **BloodTestResultsToJson.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{A5FA1293-C15B-4249-A771-ED4301658454}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>BloodTestResultsToJson.Module1</StartupObject>
    <RootNamespace>BloodTestResultsToJson</RootNamespace>
    <AssemblyName>BloodTestResultsToJson</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>BloodTestResultsToJson.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>BloodTestResultsToJson.xml</DocumentationFile>
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
    <Reference Include="ByteScout.DocumentParser, Version=1.0.0.100, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\ByteScout Document Parser SDK\net40\ByteScout.DocumentParser.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
      <HintPath>packages\Newtonsoft.Json.12.0.3\lib\net40\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Module1.vb" />
  </ItemGroup>
  <ItemGroup>
    <None Include="..\..\SampleBloodReport.pdf">
      <Link>SampleBloodReport.pdf</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="..\..\_Sample Templates\SampleBloodReport.yml">
      <Link>Templates\SampleBloodReport.yml</Link>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="packages.config" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **Module1.vb:**
    
```
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
        Dim sampleTemplate As String = ".\Templates\SampleBloodReport.yml"

        ' Perform parsing with SDK
        ' ParseWithSDK(sampleDocument, sampleTemplate)

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