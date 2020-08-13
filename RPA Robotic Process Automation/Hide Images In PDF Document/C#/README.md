## hide images in PDF document in C# and ByteScout Robotic Process Automation ByteScout Robotic Process Automation is set of integrated APIs for quick replaccement of manual data processing with robotic process automations.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Robotic%20Process%20Automation%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Robotic%20Process%20Automation%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gEjuZ0zgtHo](https://www.youtube.com/watch?v=gEjuZ0zgtHo)




<!-- code block begin -->

##### **HideImagesInPdfDocument.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{AF6915BA-85D2-43E3-AD28-2743B7E805B1}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>HideImagesInPdfDocument</RootNamespace>
    <AssemblyName>HideImagesInPdfDocument</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <Deterministic>true</Deterministic>
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
    <Reference Include="Bytescout.PDF, Version=1.9.1.301, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL" />
    <Reference Include="Bytescout.PDFExtractor, Version=10.0.0.3429, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL" />
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Data" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="mask.png">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <None Include="sample.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <Folder Include="Properties\" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **HideImagesInPdfDocument.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 16
VisualStudioVersion = 16.0.28729.10
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "HideImagesInPdfDocument", "HideImagesInPdfDocument.csproj", "{AF6915BA-85D2-43E3-AD28-2743B7E805B1}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{AF6915BA-85D2-43E3-AD28-2743B7E805B1}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{AF6915BA-85D2-43E3-AD28-2743B7E805B1}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{AF6915BA-85D2-43E3-AD28-2743B7E805B1}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{AF6915BA-85D2-43E3-AD28-2743B7E805B1}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {3BF0F1FD-BA8E-45F6-ABB2-F7EB20F38CEF}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### **Program.cs:**
    
```
using System.Diagnostics;
using System.Drawing;
using Bytescout.PDF;
using Bytescout.PDFExtractor;
using Image = Bytescout.PDF.Image;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPdfDocument = @".\sample.pdf";
            string maskingImage = @".\mask.png";
            string resultPdfDocument = @".\result.pdf";


            // Create Bytescout.PDFExtractor.ImageExtractor instance
            using (ImageExtractor imageExtractor = new ImageExtractor())
            {
                imageExtractor.RegistrationName = "demo";
                imageExtractor.RegistrationKey = "demo";

                // Load document
                imageExtractor.LoadDocumentFromFile(inputPdfDocument);

                // Create Bytescout.PDF.Document instance
                using (Document pdfDocument = new Document())
                {
                    pdfDocument.RegistrationName = "demo";
                    pdfDocument.RegistrationKey = "demo";

                    // Load document
                    pdfDocument.Load(inputPdfDocument);
                    
                    // Load masking image
                    var maskImage = new Image(maskingImage);

                    // Process pages
                    for (int i = 0; i < pdfDocument.Pages.Count; i++)
                    {
                        Page page = pdfDocument.Pages[i];

                        // Find images on the page
                        if (imageExtractor.GetFirstPageImage(i))
                        {
                            do
                            {
                                // Get image rectangle
                                var imageRect = imageExtractor.GetCurrentImageRectangle();
                                
                                // Draw new image other the found image
                                page.Canvas.DrawImage(maskImage, imageRect.Left, imageRect.Top, imageRect.Width, imageRect.Height);

                            } while (imageExtractor.GetNextImage());
                        }
                    }

                    // Save modified document
                    pdfDocument.Save(resultPdfDocument);
                }
            }

            // Open document in default PDF viewer application (for demonstration).
            Process.Start(resultPdfDocument);
        }
    }
}

```

<!-- code block end -->