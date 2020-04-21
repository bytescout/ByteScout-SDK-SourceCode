## How to extract text from large PDF document in parallel processing in C# with Multiple ByteScout SDK

### The tutorial shows how to extract text from large PDF document in parallel processing in C#

Sample source code below will show you how to cope with a difficult task like extract text from large PDF document in parallel processing in C#. Multiple ByteScout SDK is the set of few ByteScout SDK libraries that is used in apps performing multi-step workflows like searching for keywords or phrases inside existing documents with highlighting of results, or adding e-signature to existing document pdf based on the analysis of visual content in another document and you can use it to extract text from large PDF document in parallel processing with C#.

This rich sample source code in C# for Multiple ByteScout SDK includes the number of functions and options you should do calling the API to extract text from large PDF document in parallel processing. In your C# project or application you may simply copy & paste the code and then run your app! Detailed tutorials and documentation are available along with installed Multiple ByteScout SDK if you'd like to dive deeper into the topic and the details of the API.

Free trial version of Multiple ByteScout SDK is available for download from our website. Get it to try other source code samples for C#.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=Multiple%20ByteScout%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=Multiple%20ByteScout%20SDK%20Question) 

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
        // Set this value to number of cores in your CPU for max performance.
        private static readonly Semaphore _threadLimiter = new Semaphore(4, 4);
        private static int _runningThreadsCounter;

        static void Main(string[] args)
        {
            const string inputFileName = "sample.pdf";
            const string resultFileName = "result.txt";
            int CHUNK_SIZE = 10;

            int pageCount;

            // Get document page count
            using (var infoExtractor = new InfoExtractor("demo", "demo"))
            {
                infoExtractor.LoadDocumentFromFile(inputFileName);
                pageCount = infoExtractor.GetPageCount();
            }

            Stopwatch stopwatch = Stopwatch.StartNew();

            int numberOfThreads = pageCount / CHUNK_SIZE;
            if (pageCount - numberOfThreads * CHUNK_SIZE > 0)
                numberOfThreads += 1;

            ManualResetEvent allFinishedEvent = new ManualResetEvent(false);
            _runningThreadsCounter = 0;
            string[] chunks = new string[numberOfThreads];

            for (int i = 0; i < numberOfThreads; i++)
            {
                // Wait for the queue
                _threadLimiter.WaitOne();

                var startPage = i * CHUNK_SIZE;
                var endPage = Math.Min(pageCount - 1, (i + 1) * CHUNK_SIZE - 1);

                // Prepare temp file name for the chunk
                chunks[i] = string.Format("temp-{0}-{1}.txt", startPage, endPage);

                // Increase the thread counter
                Interlocked.Increment(ref _runningThreadsCounter);

                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc),
                    new object[] { i, allFinishedEvent, inputFileName, chunks[i], startPage, endPage });
            }

            // Wait for all threads
            allFinishedEvent.WaitOne();

            // Merge pieces into a single text file
            using (Stream resultFileStream = File.Create(resultFileName))
            {
                foreach (string tempFile in chunks)
                    using (Stream srcStream = File.OpenRead(tempFile))
                        srcStream.CopyTo(resultFileStream);
            }

            // Delete temp files
            foreach (string tempFile in chunks)
                File.Delete(tempFile);


            Console.WriteLine("All done in {0}.", stopwatch.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void ThreadProc(object stateInfo)
        {
            int threadIndex = (int) ((object[]) stateInfo)[0];
            ManualResetEvent allFinishedEvent = (ManualResetEvent) ((object[]) stateInfo)[1];
            string inputFile = (string) ((object[]) stateInfo)[2];
            string outputFile = (string) ((object[]) stateInfo)[3];
            int startPage = (int) ((object[]) stateInfo)[4];
            int endPage = (int) ((object[]) stateInfo)[5];

            try
            {
                Console.WriteLine("Thread #{0} started with the page range from {1} to {2}.", threadIndex, startPage, endPage);

                Stopwatch stopwatch = Stopwatch.StartNew();

                // Process the piece
                using (TextExtractor textExtractor = new TextExtractor("demo", "demo"))
                {
                    // Set page separator. Default is '\f' (Form Feed)
                    textExtractor.PageSeparator = Environment.NewLine;
                    // Since we are only extracting text, disable the caching to reduce memory usage
                    textExtractor.PageDataCaching = PageDataCaching.None;

                    textExtractor.OCRMode = OCRMode.Auto;
                    textExtractor.OCRLanguageDataFolder = @"c:\Program Files\Bytescout PDF Extractor SDK\net4.00\tessdata\";
                    textExtractor.OCRLanguage = "eng";
                    // 300 DPI resolution is recommended. 
                    // Using of higher values will slow down the processing but does not guarantee the higher quality.
                    textExtractor.OCRResolution = 300;

                    textExtractor.LoadDocumentFromFile(inputFile);

                    textExtractor.SaveTextToFile(startPage, endPage, outputFile);
                }

                Console.WriteLine("Thread #{0} finished in {1}.", threadIndex, stopwatch.Elapsed);
            }
            finally
            {
                // If it was the last thread, signal the main thread about the finish.
                if (Interlocked.Decrement(ref _runningThreadsCounter) == 0)
                    allFinishedEvent.Set();

                // Release semaphore
                _threadLimiter.Release();
            }
        }
    }
}
```

<!-- code block end -->