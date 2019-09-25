## multiple conversions at once in VB.NET with ByteScout SWF To Video SDK

### How to code multiple conversions at once in VB.NET: How-To tutorial

On this page you will learn from code samples for programming in VB.NET. ByteScout SWF To Video SDK was made to help with multiple conversions at once in VB.NET. ByteScout SWF To Video SDK is the specialized software development kit for programmers who need to add SWF (Flash Macromedia) to video conversion into their app. Supports WMV and AVI video output with sound as can take input flash movies with variables, actionscripts, dynamic files as input. You can control output video size, framerate, video and audio quality.

Fast application programming interfaces of ByteScout SWF To Video SDK for VB.NET plus the instruction and the VB.NET code below will help you quickly learn multiple conversions at once. This VB.NET sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. VB.NET application implementation typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Free trial version of ByteScout SWF To Video SDK is available on our website. Get it to try other samples for VB.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20SWF%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20SWF%20To%20Video%20SDK%20Question) 

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

##### ****AssemblyInfo.vb:**
    
```
Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes

<Assembly: AssemblyTitle("Multiple Instances example")> 
<Assembly: AssemblyDescription("")> 
<Assembly: AssemblyCompany("Bytescout Software")> 
<Assembly: AssemblyProduct("SWF to Video SDK")> 
<Assembly: AssemblyCopyright("Copyright ©  2015")> 
<Assembly: AssemblyTrademark("")> 

<Assembly: ComVisible(False)> 

'The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("53c3c7b9-292b-4aac-bd74-bc5ec34613b1")> 

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:

<Assembly: AssemblyVersion("1.0.0.0")> 
<Assembly: AssemblyFileVersion("1.0.0.0")> 

```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleInstances.VS2005.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{6300B039-ED52-4219-AD44-8A8BCF67737E}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleInstances</RootNamespace>
    <AssemblyName>MultipleInstances</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutSWFToVideo">
      <Guid>{E76CD51E-7817-4D3E-8DD6-A71518D5AEC7}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Content Include="movie1.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="movie2.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="movie3.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleInstances.VS2008.vbproj:**
    
```
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{6300B039-ED52-4219-AD44-8A8BCF67737E}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ConversionProgress</RootNamespace>
    <AssemblyName>ConversionProgress</AssemblyName>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Linq" />
    <Reference Include="System" />
    <Reference Include="System.Core">
      <RequiredTargetFramework>3.5</RequiredTargetFramework>
    </Reference>
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="AssemblyInfo.vb" />
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutSWFToVideo">
      <Guid>{E76CD51E-7817-4D3E-8DD6-A71518D5AEC7}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Content Include="movie1.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="movie2.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="movie3.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <Folder Include="Properties\" />
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleInstances.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{6300B039-ED52-4219-AD44-8A8BCF67737E}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleInstances</RootNamespace>
    <AssemblyName>MultipleInstances</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="AssemblyInfo.vb" />
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutSWFToVideo">
      <Guid>{E76CD51E-7817-4D3E-8DD6-A71518D5AEC7}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
    <Folder Include="Properties\" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="movie1.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="movie2.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="movie3.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode.

Imports System.Diagnostics
Imports System.Threading
Imports BytescoutSWFToVideo

Class Program

    Shared _numBusy As Integer
    Shared _doneEvent As ManualResetEvent

    Public Shared Sub Main(ByVal args As String())

        _doneEvent = New ManualResetEvent(False)

        Console.WriteLine("Converting SWF movies to video in multiple threads, please wait...")

        _numBusy = 3

        ' Start 3 conversion threads
        ThreadPool.QueueUserWorkItem(AddressOf DoWork, 1)
        ThreadPool.QueueUserWorkItem(AddressOf DoWork, 2)
        ThreadPool.QueueUserWorkItem(AddressOf DoWork, 3)

        ' Wait for all threads finished
        _doneEvent.WaitOne()

        Console.WriteLine("All threads are finished. Press any key to continue..")
        Console.ReadKey()

    End Sub

    Public Shared Sub DoWork(ByVal data As Object)

        Dim index As Integer = CType(data, Integer)

        Try
            Console.WriteLine("Thread {0} started...", index)

            ' Create BytescoutImageToVideo.ImageToVideo object instance
            Dim converter As SWFToVideo = New SWFToVideo()

            ' Activate the component
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"

            converter.SWFConversionMode = SWFConversionModeType.SWFAnimation

            ' set input SWF file 
            converter.InputSWFFileName = String.Format("movie{0}.swf", index)

            ' Set output video file name
            converter.OutputVideoFileName = String.Format("result_{0}.wmv", index)

            ' set FPS 
            converter.FPS = 29.97F

            ' Set output video size
            converter.OutputWidth = 640
            converter.OutputHeight = 480

            ' Run the conversion
            converter.RunAndWait()

            ' Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)

            Console.WriteLine("Thread {0} finished.", index)

        Catch ex As Exception

            Console.WriteLine("Thread {0} failed: {1}", index, ex.Message)

        End Try

        If Interlocked.Decrement(_numBusy) = 0 Then _doneEvent.Set()

    End Sub

End Class

```

<!-- code block end -->