## How to draw text on rotated page in C# and ByteScout PDF SDK ByteScout PDF SDK: the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gdsQ0EAqwGQ](https://www.youtube.com/watch?v=gdsQ0EAqwGQ)




<!-- code block begin -->

##### **DrawHeaderAndFooterOnRotatedPage.NETCore.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <EnableDefaultCompileItems>false</EnableDefaultCompileItems>
    <GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>
    <GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>
    <GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>
    <GenerateAssemblyInformationalVersionAttribute>false</GenerateAssemblyInformationalVersionAttribute>
    <GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>
    <GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>
    <GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>
    <GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>
    <GenerateAssemblyTrademarkAttribute>false</GenerateAssemblyTrademarkAttribute>
    <GenerateAssemblyCultureAttribute>false</GenerateAssemblyCultureAttribute>
    <GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>
  </PropertyGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <None Include="RotatedPages.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Microsoft.Windows.Compatibility" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDF">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF SDK\netcoreapp2.0\Bytescout.PDF.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### **DrawHeaderAndFooterOnRotatedPage.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{474F52FF-3928-44EA-8F6F-379E9DAA23FF}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>DrawHeaderAndFooterOnRotatedPage</RootNamespace>
    <AssemblyName>DrawHeaderAndFooterOnRotatedPage</AssemblyName>
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
    <Reference Include="Bytescout.PDF, Version=1.0.0.15, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="RotatedPages.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
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

<!-- code block begin -->

##### **Program.cs:**
    
```
using Bytescout.PDF;
using System.Diagnostics;
using System.Drawing;
using Brush = Bytescout.PDF.Brush;
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;
using StringFormat = Bytescout.PDF.StringFormat;


namespace DrawHeaderAndFooterOnRotatedPage
{
    /// <summary>
    /// This example demonstrates how to add header and footer to rotated PDF pages.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Load document
            Document pdfDocument = new Document(@".\RotatedPages.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            string headerText = "Sample Header";
            string footerText = "Sample Footer";

            // Prepare StringFormat with Center text alignment
            StringFormat stringFormat = new StringFormat { HorizontalAlign = HorizontalAlign.Center };
            // Prepare drawing tools
            Font font = new Font(StandardFonts.Helvetica, 9);
            Brush brush = new SolidBrush(new ColorRGB(255, 0, 0));
            
            for (int i = 0; i < pdfDocument.Pages.Count; ++i)
            {
                Page page = pdfDocument.Pages[i];
                
                page.Canvas.SaveGraphicsState();

                // Calculate the coordinates of the text taking into account the page rotation:

                float headerY = 10;
                float footerY;
                float textRectWidth;
                float textRectHeight = font.GetTextHeight() + 5;

                if (page.RotationAngle == RotationAngle.Rotate0 || page.RotationAngle == RotationAngle.Rotate180)
                {
                    footerY = page.Height - textRectHeight - 10;
                    textRectWidth = page.Width;
                }
                else
                {
                    footerY = page.Width - textRectHeight - 10;
                    textRectWidth = page.Height;
                }

                // Rotate page canvas according to page rotation
                switch (page.RotationAngle)
                {
                    case RotationAngle.Rotate90:
                        page.Canvas.RotateTransform(-90);
                        page.Canvas.TranslateTransform(-page.Height, 0);
                        break;
                    case RotationAngle.Rotate180:
                        page.Canvas.RotateTransform(180);
                        page.Canvas.TranslateTransform(-page.Width, -page.Height);
                        break;
                    case RotationAngle.Rotate270:
                        page.Canvas.RotateTransform(-270);
                        page.Canvas.TranslateTransform(0, -page.Width);
                        break;
                }
                
                // Draw header and footer
                page.Canvas.DrawString(headerText, font, brush, new RectangleF(0, headerY, textRectWidth, textRectHeight), stringFormat);
                page.Canvas.DrawString(footerText, font, brush, new RectangleF(0, footerY, textRectWidth, textRectHeight), stringFormat);

                page.Canvas.RestoreGraphicsState();
            }
            
            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result PDF document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}

```

<!-- code block end -->