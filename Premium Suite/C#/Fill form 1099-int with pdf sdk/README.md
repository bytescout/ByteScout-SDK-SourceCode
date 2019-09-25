## fill form 1099 int with pdf sdk in C# with ByteScout Premium Suite

### Build fill form 1099 int with pdf sdk in C#: ### Step-by-step instructions on how to do fill form 1099 int with pdf sdk in C#

These source code samples are assembled by their programming language and functions they use. ByteScout Premium Suite helps with fill form 1099 int with pdf sdk in C#. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

If you want to quickly learn then these fast application programming interfaces of ByteScout Premium Suite for C# plus the guideline and the C# code below will help you quickly learn fill form 1099 int with pdf sdk. If you want to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Enjoy writing a code with ready-to-use sample C# codes to add fill form 1099 int with pdf sdk functions using ByteScout Premium Suite in C#.

Trial version can be downloaded from our website for free. It contains this and other source code samples for C#.

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

##### ****FillForm.NETCore.csproj:**
    
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
    <None Include="f1099int.pdf">
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

##### ****FillForm.VS2013.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{474F52FF-3928-44EA-8F6F-379E9DAA23FF}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>FillFormExample</RootNamespace>
    <AssemblyName>FillFormExample</AssemblyName>
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
    <Content Include="f1099int.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
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

##### ****FillForm.VS2015.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{474F52FF-3928-44EA-8F6F-379E9DAA23FF}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>FillFormExample</RootNamespace>
    <AssemblyName>FillFormExample</AssemblyName>
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
    <Content Include="f1099int.pdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
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

##### ****Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Bytescout.PDF;

namespace FillFormExample
{
    /// <summary>
    /// This example demonstrates how to fill PDF form programmatically.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Map of form fields and sample values to set
            Dictionary<string, object> fieldMap = new Dictionary<string, object>()
            {
               { "c2_1[0]", true }, // VOID
               { "c2_1[1]", true }, // CORRECTED
               { "f2_1[0]", "John Smith, 12 Palm st., Hill Valley, CA 12345" }, // PAYER’S name, street address, city or town, ...
               { "f2_2[0]", "123456" }, // PAYER’S TIN
               { "f2_3[0]", "234567" }, // RECIPIENT’S TIN 
               { "f2_4[0]", "John Doe" }, // RECIPIENT’S name
               { "f2_5[0]", "23 Elm st., 345" }, // Street address (including apt. no.)
               { "f2_6[0]", "Hill Valley, CA 12345" }, // City or town, state or province, country, and ZIP or foreign postal code
               { "c2_2[0]", true }, // FATCA filing requirement
               { "f2_7[0]", "345678" }, // Account number (see instructions)
               { "f2_8[0]", "456789" }, // Payer's RTN (optional)
               { "f2_9[0]", "1000.00" }, // 1 Interest income
               { "f2_10[0]", "11.00" }, // 2 Early withdrawal penalty
               { "f2_11[0]", "12.00" }, // 3 Interest on U.S. Savings Bonds and Treas. obligations
               { "f2_12[0]", "13.00" }, // 4 Federal income tax withheld
               { "f2_13[0]", "14.00" }, // 5 Investment expenses
               { "f2_14[0]", "15.00" }, // 6 Foreign tax paid
               { "f2_15[0]", "16.00" }, // 7 Foreign country or U.S. possession
               { "f2_16[0]", "17.00" }, // 8 Tax-exempt interest
               { "f2_17[0]", "18.00" }, // 9  Specified private activity bond interest
               { "f2_18[0]", "19.00" }, // 10 Market discount
               { "f2_19[0]", "20.00" }, // 11 Bond premium
               { "f2_20[0]", "21.00" }, // 12 Bond premium on Treasury obligations
               { "f2_21[0]", "22.00" }, // 13 Bond premium on tax-exempt bond 
               { "f2_22[0]", "567890" }, // 14 Tax-exempt and tax credit bond CUSIP no.
               { "f2_23[0]", "AA" }, // 15 State [field 1] 
               { "f2_24[0]", "BB" }, // 15 State [field 2]
               { "f2_25[0]", "33" }, // 16 State identification no. [field 1]
               { "f2_26[0]", "44" }, // 16 State identification no. [field 2]
               { "f2_27[0]", "30.00" }, // 17 State tax withheld [field 1]
               { "f2_28[0]", "40.00" } // 17 State tax withheld [field 2]
            };
            
            // Load PDF form
            Document pdfDocument = new Document(@".\f1099int.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Get second page ("Copy 1")
            Page page = pdfDocument.Pages[1];

            // Get widget by its name and change value
            foreach (KeyValuePair<string, object> keyValuePair in fieldMap)
            {
                Annotation annotation = page.Annotations[keyValuePair.Key];

                if (annotation is CheckBox)
                {
                    ((CheckBox) annotation).Checked = (bool) keyValuePair.Value;
                }
                else if (annotation is EditBox)
                {
                    ((EditBox) annotation).Text = (string) keyValuePair.Value;
                }
            }

            // Save modified document
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}

```

<!-- code block end -->