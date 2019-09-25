## multiple videos at once in VB.NET using ByteScout Image To Video SDK

### multiple videos at once in VB.NET

These source code samples are listed and grouped by their programming language and functions they use. ByteScout Image To Video SDK was made to help with multiple videos at once in VB.NET. ByteScout Image To Video SDK is the SDK that is designed to generate video slideshow with 100+ 2d and 3D transition effects. Can generate WMV, AVI, WEBM video file with adjustable quality, framerate, output video size.

VB.NET, code samples for VB.NET, developers help to speed up the application development and writing a code when using ByteScout Image To Video SDK. This VB.NET sample code should be copied and pasted into your application’s code editor. Then just compile and run it to see how it works. Use of ByteScout Image To Video SDK in VB.NET is also explained in the documentation included along with the product.

Visit our website provides for free trial version of ByteScout Image To Video SDK. Free trial includes lots of source code samples to help you with your VB.NET project.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Image%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Image%20To%20Video%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=FzPgeGFL8YA](https://www.youtube.com/watch?v=FzPgeGFL8YA)




<!-- code block begin -->

##### ****MultipleInstances.VS2005.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{8F94C8EC-5BE0-4161-9A29-BE21625F4FF0}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleInstances</RootNamespace>
    <AssemblyName>MultipleInstances</AssemblyName>
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
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutImageToVideo">
      <Guid>{5212739C-A95B-4CDA-B116-F540A549B648}</Guid>
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
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleInstances.VS2008.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{8F94C8EC-5BE0-4161-9A29-BE21625F4FF0}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleInstances</RootNamespace>
    <AssemblyName>MultipleInstances</AssemblyName>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
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
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutImageToVideo">
      <Guid>{5212739C-A95B-4CDA-B116-F540A549B648}</Guid>
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
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleInstances.VS2010.vbproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{8F94C8EC-5BE0-4161-9A29-BE21625F4FF0}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleInstances</RootNamespace>
    <AssemblyName>MultipleInstances</AssemblyName>
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
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutImageToVideo">
      <Guid>{5212739C-A95B-4CDA-B116-F540A549B648}</Guid>
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
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Threading
Imports BytescoutImageToVideo

Class Program

    Private Shared numBusy As Integer
    Private Shared doneEvent As ManualResetEvent

    Friend Shared Sub Main(ByVal args As String())

        doneEvent = New ManualResetEvent(False)

        Console.WriteLine("Converting JPG slides to video in multiple threads, please wait...")

        numBusy = 10 ' 10 threads to start

        ' starting threads one by one
        For i As Integer = 1 To numBusy
            ThreadPool.QueueUserWorkItem(AddressOf DoWork, i)
        Next

        ' wait for all threads finished
        doneEvent.WaitOne()

        Console.WriteLine("All threads are finished. Press any key to continue..")
        Console.ReadKey()

    End Sub



    Private Shared Function GetRandomEffect() As TransitionEffectType
        Dim rr As New Random
        GetRandomEffect = rr.Next(CType(TransitionEffectType.teZoomOut, Integer), CType(TransitionEffectType.teBlinds3DHorz, Integer))
    End Function

    Private Shared Sub DoWork(ByVal data As Object)

        Dim index As Integer = CInt(Data)

        Try
            Console.WriteLine("Thread {0} started...", index)

            ' Create BytescoutImageToVideoLib.ImageToVideo object instance
            Dim converter As New ImageToVideo()

            ' Activate the component
            converter.RegistrationName = "demo"
            converter.RegistrationKey = "demo"

            ' Add images and set the duration for every slide
            Dim slide As Slide
            slide = DirectCast(converter.AddImageFromFileName("..\..\..\..\slide1.jpg"), Slide)
            slide.Duration = 3000  ' 3000ms = 3s
            slide.InEffect = GetRandomEffect()
            slide.OutEffect = GetRandomEffect()


            slide = DirectCast(converter.AddImageFromFileName("..\..\..\..\slide2.jpg"), Slide)
            slide.Duration = 3000
            slide.InEffect = GetRandomEffect()
            slide.OutEffect = GetRandomEffect()

            slide = DirectCast(converter.AddImageFromFileName("..\..\..\..\slide3.jpg"), Slide)
            slide.Duration = 3000
            slide.InEffect = GetRandomEffect()
            slide.OutEffect = GetRandomEffect()

            ' Set output video size
            converter.OutputWidth = 640
            converter.OutputHeight = 480

            ' Set output video file name
            converter.OutputVideoFileName = String.Format("result_{0}.wmv", index)

            ' Run the conversion
            converter.RunAndWait()

            ' Release resources
            System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)

            Console.WriteLine("Thread {0} finished.", index)

        Catch ex As Exception
            Console.WriteLine("Thread {0} failed: {1}", index, ex.Message)
        End Try

        If Interlocked.Decrement(numBusy) = 0 Then
            doneEvent.Set()
        End If

    End Sub
End Class

```

<!-- code block end -->