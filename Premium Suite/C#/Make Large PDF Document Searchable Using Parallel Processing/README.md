## How to make large PDF document searchable using parallel processing in C# and ByteScout Premium Suite

### If you want to learn more then this tutorial will show how to make large PDF document searchable using parallel processing in C#

This sample source code below will display you how to make large PDF document searchable using parallel processing in C#. ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can make large PDF document searchable using parallel processing in C#.

The following code snippet for ByteScout Premium Suite works best when you need to quickly make large PDF document searchable using parallel processing in your C# application. IF you want to implement the functionality, just copy and paste this code for C# below into your code editor with your app, compile and run your application. If you want to use these C# sample examples in one or many applications then they can be used easily.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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

##### ****MultithreadProcessing.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{0B102DA4-C143-481D-A076-1F56E3CB1CF5}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>MultithreadProcessing</RootNamespace>
    <AssemblyName>MultithreadProcessing</AssemblyName>
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
    <Reference Include="Bytescout.PDFExtractor, Version=8.6.0.2917, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDFExtractor.OCRExtension, Version=8.6.0.2917, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF Extractor SDK\net4.00\Bytescout.PDFExtractor.OCRExtension.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultithreadProcessing.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.26730.10
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "MultithreadProcessing", "MultithreadProcessing.csproj", "{0B102DA4-C143-481D-A076-1F56E3CB1CF5}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{0B102DA4-C143-481D-A076-1F56E3CB1CF5}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{0B102DA4-C143-481D-A076-1F56E3CB1CF5}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{0B102DA4-C143-481D-A076-1F56E3CB1CF5}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{0B102DA4-C143-481D-A076-1F56E3CB1CF5}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {50466307-7059-438B-8545-42FDA71BC1A6}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Bytescout.PDFExtractor;

namespace MultithreadProcessing
{
	class Program
	{
	    // Limit to 4 threads in queue.
	    // Set this value to number of your processor cores for max performance.
	    private static readonly Semaphore ThreadLimiter = new Semaphore(4, 4);

        static void Main(string[] args)
		{
			const string inputFile = "sample.pdf";
			const string resultFile = "result.pdf";

			int pageCount;

			// Get document page count
			using (var infoExtractor = new InfoExtractor("demo", "demo"))
			{
				infoExtractor.LoadDocumentFromFile(inputFile);
				pageCount = infoExtractor.GetPageCount();
			}
			
			// Process the document by 10-page pieces

			int numberOfThreads = pageCount / 10;
			if (pageCount - numberOfThreads * 10 > 0)
				numberOfThreads += 1;

			WaitHandle[] doneEvents = new WaitHandle[numberOfThreads];
			Stopwatch stopwatch = Stopwatch.StartNew();
			int startPage, endPage;
			string[] pieces = new string[numberOfThreads];

			for (int i = 0; i < numberOfThreads; i++)
			{
			    // Wait for the queue
			    ThreadLimiter.WaitOne();

                doneEvents[i] = new ManualResetEvent(false);
				startPage = i * 10;
				endPage = Math.Min(pageCount - 1, (i + 1) * 10 - 1);

				pieces[i] = string.Format("temp-{0}-{1}.pdf", startPage, endPage);
				ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc),
					new object[] { i, doneEvents[i], inputFile, pieces[i], startPage, endPage });
			}

			// Wait for all threads
			WaitHandle.WaitAll(doneEvents);

			// Merge pieces 
			using (DocumentMerger merger = new DocumentMerger("demo", "demo"))
				merger.Merge(pieces, resultFile);

			// Delete temp files
			foreach (string tempFile in pieces)
				File.Delete(tempFile);

			Console.WriteLine("All done in {0}.", stopwatch.Elapsed);
			Console.WriteLine();

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		private static void ThreadProc(object stateInfo)
		{
			int threadIndex = (int) ((object[]) stateInfo)[0];
			ManualResetEvent doneEvent = (ManualResetEvent) ((object[]) stateInfo)[1];
			string inputFile = (string) ((object[]) stateInfo)[2];
			string outputFile = (string)((object[])stateInfo)[3];
			int startPage = (int)((object[])stateInfo)[4];
			int endPage = (int)((object[])stateInfo)[5];

            try
		    {
		        Console.WriteLine("Thread #{0} started with the page range from {1} to {2}.", threadIndex, startPage, endPage);

		        Stopwatch stopwatch = Stopwatch.StartNew();

		        // Extract a piece of document
		        string chunk = string.Format("temp-{0}-{1}", startPage, endPage);
		        using (DocumentSplitter splitter = new DocumentSplitter("demo", "demo"))
		            splitter.ExtractPageRange(inputFile, chunk, startPage + 1, endPage + 1);

		        // Process the piece
		        using (SearchablePDFMaker searchablePdfMaker = new SearchablePDFMaker("demo", "demo"))
		        {
		            searchablePdfMaker.OCRDetectPageRotation = true;
		            searchablePdfMaker.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\";
		            searchablePdfMaker.LoadDocumentFromFile(chunk);

		            // 300 DPI resolution is recommended. 
		            // Using of higher values will slow down the processing but does not guarantee the higher quality.
		            searchablePdfMaker.OCRResolution = 300;

		            searchablePdfMaker.MakePDFSearchable(outputFile);
		        }

		        File.Delete(chunk);

		        Console.WriteLine("Thread #{0} finished in {1}.", threadIndex, stopwatch.Elapsed);
		    }
            finally
            {
                // Signal the thread is finished
                doneEvent.Set();

                // Release semaphore
                ThreadLimiter.Release();
            }
        }
	}
}

```

<!-- code block end -->