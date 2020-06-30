## fill form I 130 in C# using ByteScout PDF SDK ByteScout PDF SDK is the library for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings.

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

##### **FillForm.NETCore.csproj:**
    
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
    <None Include="I130.pdf">
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

##### **FillForm.VS2013.csproj:**
    
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
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="I130.pdf">
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

##### **FillForm.VS2015.csproj:**
    
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
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <TargetFrameworkProfile />
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
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDF, Version=1.0.0.15, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="I130.pdf">
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

##### **Program.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            // Load PDF form
            Document pdfDocument = new Document(@".\I130.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Iterate through all pages
            for (int i = 0; i < pdfDocument.Pages.Count; i++)
            {
                // Get current page
                Page page = pdfDocument.Pages[i];

                // Get FieldMap if exists
                var fieldMap = GetPageAnnotationValues(i);

                // Get widget by its name and change value
                foreach (KeyValuePair<string, object> keyValuePair in fieldMap)
                {
                    Annotation annotation = page.Annotations[keyValuePair.Key];

                    if (annotation is CheckBox)
                    {
                        ((CheckBox)annotation).Checked = Convert.ToBoolean(keyValuePair.Value);
                    }
                    else if (annotation is EditBox)
                    {
                        ((EditBox)annotation).Text = (string)keyValuePair.Value;
                    }
                    else if (annotation is ComboBox)
                    {
                        ((ComboBox)annotation).Text = (string)keyValuePair.Value;
                    }
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

        /// <summary>
        /// Get page annotation values
        /// </summary>
        static Dictionary<string, object> GetPageAnnotationValues(int pageIndex)
        {
            var lstAnnotationValues = new List<Dictionary<string, object>>();

            // Map of form fields and sample values to set

            // Set values for page-1
            var fieldMap_page1 = new Dictionary<string, object>()
            {
                { "Pt2Line11_SSN[0]", "987654321" },
                { "CheckBox1[0]", "True" },
                { "VolagNumber[0]", "V1234567" },
                { "AttorneyStateBarNumber[0]", "A2345678" },
                { "USCISOnlineAcctNumber[0]", "U45897231" },
                { "Pt1Line1_Spouse[0]", "True" },
                { "Pt1Line1_Siblings[0]", "False" },
                { "Pt1Line1_Parent[0]", "False" },
                { "Pt1Line1_Child[0]", "False" },
                { "Pt1Line2_InWedlock[0]", "True" },
                { "Pt1Line2_AdoptedChild[0]", "False" },
                { "Pt1Line2_Stepchild[0]", "False" },
                { "Pt1Line2_OutOfWedlock[0]", "False" },
                { "Pt1Line3_Yes[0]", "True" },
                { "Pt1Line4_No[0]", "False" },
                { "Pt1Line4_Yes[0]", "True" },
                { "Pt1Line3_No[0]", "False" },
                { "Pt2Line4a_FamilyName[0]", "Zawodny" },
                { "Pt2Line4b_GivenName[0]", "John" },
                { "Pt2Line4c_MiddleName[0]", "C" },
                { "Pt2Line1_AlienNumber[0]", "3948JDC" },
                { "Pt2Line2_USCISOnlineActNumber[0]", "D395083105" }
           };
            lstAnnotationValues.Add(fieldMap_page1);

            // Set values for page-2
            var fieldMap_page2 = new Dictionary<string, object>()
            {
                { "Pt2Line8_DateofBirth[0]", "02/22/1985" },
                { "Pt2Line9_Male[0]", "True" },
                { "Pt2Line9_Female[0]", "False" },
                { "Pt2Line7_CountryofBirth[0]", "Bolivia" },
                { "Pt2Line11_Yes[0]", "False" },
                { "Pt2Line11_No[0]", "True" },
                { "Pt2Line10_StreetNumberName[0]", "Happy Street" },
                { "Pt2Line10_Unit[0]", "True" },
                { "Pt2Line10_Unit[1]", "False" },
                { "Pt2Line10_Unit[2]", "False" },
                { "Pt2Line10_AptSteFlrNumber[0]", "12" },
                { "Pt2Line10_CityOrTown[0]", "NJ" },
                { "Pt2Line10_Province[0]", "Province" },
                { "Pt2Line10_PostalCode[0]", "39392" },
                { "Pt2Line10_ZipCode[0]", "39392" },
                { "Pt2Line10_State[0]", "NJ" },
                { "Pt2Line10_Country[0]", "USA" },
                { "Pt2Line10_InCareofName[0]", "Mrs Maizel" },
                { "Pt2Line14_StreetNumberName[0]", "Happy Street" },
                { "Pt2Line14_Unit[0]", "False" },
                { "Pt2Line14_Unit[1]", "True" },
                { "Pt2Line14_Unit[2]", "False" },
                { "Pt2Line14_AptSteFlrNumber[0]", "14" },
                { "Pt2Line14_CityOrTown[0]", "NY" },
                { "Pt2Line14_State[0]", "NY" },
                { "Pt2Line14_ZipCode[0]", "10001" },
                { "Pt2Line14_Province[0]", "Province" },
                { "Pt2Line14_Country[0]", "USA" },
                { "Pt2Line14_PostalCode[0]", "10001" },
                { "Pt2Line13a_DateFrom[0]", "12/30/2010" },
                { "Pt2Line15a_DateFrom[0]", "11/23/2010" },
                { "Pt2Line15b_DateTo[0]", "11/28/2010" },
                { "Pt2Line12_StreetNumberName[0]", "Happy Street" },
                { "Pt2Line12_Unit[0]", "False" },
                { "Pt2Line12_Unit[1]", "False" },
                { "Pt2Line12_Unit[2]", "True" },
                { "Pt2Line12_AptSteFlrNumber[0]", "14" },
                { "Pt2Line12_CityOrTown[0]", "NY" },
                { "Pt2Line12_State[0]", "NY" },
                { "Pt2Line12_ZipCode[0]", "10001" },
                { "Pt2Line12_Province[0]", "" },
                { "Pt2Line12_Country[0]", "USA" },
                { "Pt2Line12_PostalCode[0]", "12332"},
                { "Pt2Line6_CityTownOfBirth[0]", "Bolivia" },
                { "Pt2Line5a_FamilyName[0]", "Zawodny" },
                { "Pt2Line5b_GivenName[0]", "John" },
                { "Pt2Line5c_MiddleName[0]", "C" },
                { "Pt2Line16_NumberofMarriages[0]", "1" },
                { "Pt2Line17_Widowed[0]", "False" },
                { "Pt2Line17_Annulled[0]", "False" },
                { "Pt2Line17_Separated[0]", "False" },
                { "Pt2Line17_Single[0]", "False" },
                { "Pt2Line17_Married[0]", "True" },
                { "Pt2Line17_Divorced[0]", "False" },
                { "Pt2Line13b_DateTo[0]", "12/20/2011" },
           };

            lstAnnotationValues.Add(fieldMap_page2);

            if (pageIndex < lstAnnotationValues.Count)
            {
                return lstAnnotationValues.ElementAt(pageIndex);
            }

            // Return empty dictionary
            return new Dictionary<string, object>();
        }

    }
}

```

<!-- code block end -->