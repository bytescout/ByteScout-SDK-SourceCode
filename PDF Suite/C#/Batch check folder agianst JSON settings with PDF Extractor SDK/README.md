## batch check folder agianst JSON settings with PDF extractor SDK in C# with ByteScout PDF Suite

### Learn to code batch check folder agianst JSON settings with PDF extractor SDK in C#: How-To tutorial

Easy to understand coding instructions are written to assist you to try-out the features without the requirement to write your own code. ByteScout PDF Suite was made to help with batch check folder agianst JSON settings with PDF extractor SDK in C#. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

This rich and prolific sample source code in C# for ByteScout PDF Suite contains various functions and options you should do calling the API to implement batch check folder agianst JSON settings with PDF extractor SDK. To use batch check folder agianst JSON settings with PDF extractor SDK in your C# project or application just copy & paste the code and then run your app! C# application implementation mostly involves various stages of the software development so even if the functionality works please check it with your data and the production environment.

ByteScout PDF Suite is available as a free trial. You may get it from our website along with all other source code samples for C# applications.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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

##### ****BatchCheckFolderAgainstJsonSettings.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{99735776-2956-463D-9795-EBCE16928C30}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>BatchCheckFolderAgainstJsonSettings</RootNamespace>
    <AssemblyName>BatchCheckFolderAgainstJsonSettings</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
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
    <Reference Include="Bytescout.PDFExtractor, Version=9.1.0.3170, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF Extractor SDK\net2.00\Bytescout.PDFExtractor.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json, Version=12.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
      <HintPath>packages\Newtonsoft.Json.12.0.2\lib\net20\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="SettingsVM.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="InputFiles\sample1.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="InputFiles\sample2.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="InputFiles\sample3.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="packages.config" />
    <None Include="settings.json">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****BatchCheckFolderAgainstJsonSettings.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "BatchCheckFolderAgainstJsonSettings", "BatchCheckFolderAgainstJsonSettings.csproj", "{99735776-2956-463D-9795-EBCE16928C30}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{99735776-2956-463D-9795-EBCE16928C30}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{99735776-2956-463D-9795-EBCE16928C30}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{99735776-2956-463D-9795-EBCE16928C30}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{99735776-2956-463D-9795-EBCE16928C30}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {F42644BA-B778-4A7A-941F-CC608E834EB1}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using BatchCheckFolderAgainstJsonSettings;
using Bytescout.PDFExtractor;
using Newtonsoft.Json;
using System;
using System.IO;

namespace FindUsAddressRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Get all settings VM
                var allSettings = GetSettingsVM("settings.json");

                // Create Bytescout.PDFExtractor.TextExtractor instance
                TextExtractor extractor = new TextExtractor();
                extractor.RegistrationName = "demo";
                extractor.RegistrationKey = "demo";

                foreach (var fileName in Directory.GetFiles("InputFiles"))
                {
                    // Load sample PDF document
                    extractor.LoadDocumentFromFile(fileName);

                    // Enable regex search
                    extractor.RegexSearch = true;

                    // Get Number of pages PDF contains
                    int pageCount = extractor.GetPageCount();

                    for (int iPage = 0; iPage < pageCount; iPage++)
                    {
                        // Loop through all search settings
                        foreach (var itmSearchSetting in allSettings.Settings)
                        {
                            // If found, then copy file to sub-category folder
                            if(extractor.Find(iPage, itmSearchSetting.regex, false))
                            {
                                // If Directory does not exists, then create them
                                if (!Directory.Exists($"{allSettings.MainFolderName}/{itmSearchSetting.category}"))
                                {
                                    Directory.CreateDirectory($"{allSettings.MainFolderName}/{itmSearchSetting.category}");
                                }

                                // Copy File
                                File.Copy(fileName, $"{allSettings.MainFolderName}/{itmSearchSetting.category}/{Path.GetFileName(fileName)}", true);
                            }
                        }
                    }
                }
				
				// Cleanup
				extractor.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Get Settings VM
        /// </summary>
        private static SettingsVM GetSettingsVM(string settingsFileName)
        {
            var allJson = File.ReadAllText(settingsFileName);

            return JsonConvert.DeserializeObject<SettingsVM>(allJson);
        }
    }
}
```

<!-- code block end -->    

<!-- code block begin -->

##### ****SettingsVM.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Text;

namespace BatchCheckFolderAgainstJsonSettings
{
    public class SettingsVM
    {
        public string MainFolderName { get; set; }
        public List<Settings> Settings { get; set; }
    }

    public class Settings
    {
        public string category { get; set; }
        public string regex { get; set; }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Newtonsoft.Json" version="12.0.2" targetFramework="net20" />
</packages>
```

<!-- code block end -->