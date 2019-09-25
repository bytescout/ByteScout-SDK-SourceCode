## SWF to video in C# and ByteScout SWF To Video SDK

### Write code in C# to make SWF to video with this How-To tutorial

Here you may find thousands pre-made source code pieces for easy implementation in your own programming C# projects. ByteScout SWF To Video SDK was made to help with SWF to video in C#. ByteScout SWF To Video SDK is the library that can take SWF (Flash Macromedia) files and convert into WMV or AVI video with sound. Dynamic flash movie scenes, variables, actionscripts are supported and you also may adjust output video size, framerate and quality.

C#, code samples for C#, developers help to speed up the application development and writing a code when using ByteScout SWF To Video SDK. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Code testing will allow the function to be tested and work properly with your data.

Trial version can be obtained from our website for free. It includes this and other source code samples for C#.

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

##### ****Program.cs:**
    
```
// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode.

using System.Diagnostics;
using BytescoutSWFToVideo;

namespace Simple
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an instance of SWFToVideo ActiveX object

            SWFToVideo converter = new SWFToVideo();

			// Set debug log
			//converter.SetLogFile("log.txt");

			// Register SWFToVideo
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";

			// set input SWF file
			converter.InputSWFFileName = "SlideShowWithEffects.swf";

			// you may calculate output video duration using information about the the source swf movie
			// WARNING #1: this method to calculate the output video duration is not working for movies with dynamic scenes 
			// and interactive scripts as in these movies it is not possible to calculate the precise duration of the movie 
			// WARNING #2: you should set the input swf or flv filename (or url) before this calculation

			// So the movie duration is calculated as the following:
			// as swf frame count (number of frames in the swf) / movieFPS (frames per second defined in swf)
			// and then multiplied by 1000 (as we are setting the .ConverstionTimeout in milliseconds)
			// as the following (uncomment if you want to set the length of the output video to the same as the original swf)
			// or as the following source code (uncomment to enable):

			// converter.ConversionTimeout = 1000 * (converter.FrameCount / converter.MovieFPS)


	        	// set output WMV or AVI video filename
       			converter.OutputVideoFileName = "result.wmv";
			

			// Set output movie dimensions
			converter.OutputWidth = 640;
			converter.OutputHeight = 480;

			// Run conversion
			converter.RunAndWait();

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Open the result movie in default media player
			Process.Start("result.wmv");
		}
	}
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Simple.VS2005.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{BA12D771-F9F5-4917-8FC4-A5E3344AD343}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Simple</RootNamespace>
    <AssemblyName>Simple</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
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
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="SlideShowWithEffects.swf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
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