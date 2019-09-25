## resize image as fit within in C# and ByteScout Watermarking SDK

### Tutorial: how to do resize image as fit within in C#

On this page you will learn from code samples for programming in C#. ByteScout Watermarking SDK helps with resize image as fit within in C#. ByteScout Watermarking SDK is the library for software developers that can be used to quickly add image watermarking features into your web or desktop applications. Use ready to use presets or create your own to be applied for input PNG, JPG, BMP images. Can customize fonts, text position and rotation if required.

C# code snippet like this for ByteScout Watermarking SDK works best when you need to quickly implement resize image as fit within in your C# application. C# sample code is all you need: copy and paste the code to your C# application's code editor, add a reference to ByteScout Watermarking SDK (if you haven't added yet) and you are ready to go! Use of ByteScout Watermarking SDK in C# is also explained in the documentation included along with the product.

On our website you may get trial version of ByteScout Watermarking SDK for free. Source code samples are included to help you with your C# application.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Watermarking%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Watermarking%20SDK%20Question) 

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

##### ****Fit within resize.VS2005.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Fit_within_resize</RootNamespace>
    <AssemblyName>Fit within resize</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
  <ItemGroup>
    <Reference Include="Bytescout.Watermarking, Version=1.5.3.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
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

<!-- code block begin -->

##### ****Fit within resize.VS2005.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 9.00
# Visual Studio 2005
# SharpDevelop 2.2.1.2648
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Fit within resize","Fit within resize.VS2005.csproj", "{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Release|Any CPU.Build.0 = Release|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Release|Any CPU.ActiveCfg = Release|Any CPU
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Fit within resize.VS2008.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="3.5">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.21022</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Fit_within_resize</RootNamespace>
    <AssemblyName>Fit within resize</AssemblyName>
    <OldToolsVersion>2.0</OldToolsVersion>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
  <ItemGroup>
    <Reference Include="Bytescout.Watermarking, Version=1.5.3.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
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

##### ****Fit within resize.VS2008.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 10.00
# Visual Studio 2008
# SharpDevelop 2.2.1.2648
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Fit within resize","Fit within resize.VS2008.csproj", "{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Release|Any CPU.Build.0 = Release|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Release|Any CPU.ActiveCfg = Release|Any CPU
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Fit within resize.VS2010.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Fit_within_resize</RootNamespace>
    <AssemblyName>Fit within resize</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
  <ItemGroup>
    <Reference Include="Bytescout.Watermarking, Version=1.5.3.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
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

##### ****Fit within resize.VS2010.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 11.00
# Visual Studio 2010
# SharpDevelop 2.2.1.2648
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Fit within resize","Fit within resize.VS2010.csproj", "{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Release|Any CPU.Build.0 = Release|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Release|Any CPU.ActiveCfg = Release|Any CPU
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Fit within resize.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Fit_within_resize</RootNamespace>
    <AssemblyName>Fit within resize</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
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
  <ItemGroup>
    <Reference Include="Bytescout.Watermarking, Version=1.5.3.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
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

<!-- code block begin -->

##### ****Fit within resize.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 9.00
# Visual Studio 2005
# SharpDevelop 2.2.1.2648
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Fit within resize", "Fit within resize.csproj", "{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Release|Any CPU.Build.0 = Release|Any CPU
		{75A2CDE7-8F28-48B4-BF4B-0569FF30E043}.Release|Any CPU.ActiveCfg = Release|Any CPU
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using Bytescout.Watermarking;
using Bytescout.Watermarking.Presets;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Watermarker instance
            Watermarker waterMarker = new Watermarker();

            // Initialize library
            waterMarker.InitLibrary("demo", "demo");

            // Set input file name
            string inputFilePath = "my_sample_image.jpg";
            // Set output file title
            string outputFilePath = "my_sample_output.jpg";


            // Add image to apply watermarks to
            waterMarker.AddInputFile(inputFilePath, outputFilePath);

            // Allow resize
            waterMarker.OutputOptions.Resize = true;

            // Allow to enlarge image
            waterMarker.OutputOptions.DontEnlargeSmallImages = false;

            // Set resize type to pixels
            waterMarker.OutputOptions.ResizeType = ResizeType.Pixels;

            // Fit to width
            waterMarker.OutputOptions.ResizeFitWithin = FitWithin.WidthOnly;

            // Set width
            waterMarker.OutputOptions.ResizeWidthInPixels = 600;

            // Set height
            waterMarker.OutputOptions.ResizeHeightInPixels = 20;


            // Set output directory
            waterMarker.OutputOptions.OutputDirectory = ".";


            // Apply watermarks
            waterMarker.Execute();

            // open generated image file in default image viewer installed in Windows
            Process.Start(outputFilePath);
        }
    }
}

```

<!-- code block end -->