## external JS for form data validation in C# with ByteScout PDF SDK What is ByteScout PDF SDK? It is the component to help programmers in generating new pdf files, modifying and updating existing pdf documents or pdf forms. Provides support for auto-filling pdf forms, adding text with adjustable font, style, size, font family, new form fields, vector and raster drawings.

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

##### **ExternalJsFormValidation.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{474F52FF-3928-44EA-8F6F-379E9DAA23FF}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>ExternalJsFormValidation</RootNamespace>
    <AssemblyName>ExternalJsFormValidation</AssemblyName>
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
using System.Diagnostics;
using Bytescout.PDF;

namespace ExternalJsFormValidation
{
    /// <summary>
    /// This example demonstrates validation of form with JavaScript
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Add page
            Page page = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page);

            // Get page canvas
            Canvas canvas = page.Canvas;

            // Prepare font and brush
            Font font = new Font(StandardFonts.Helvetica, 15);
            SolidBrush blackBrush = new SolidBrush();

            // Draw First Name Label
            canvas.DrawString("First Name: ", font, blackBrush, 50, 50);

            // Create First Name EditBox
            EditBox firstName = new EditBox(130, 50, 100, 30, "FirstName");
            
            // Add javascript validation of focus lose
            firstName.OnLoseFocus = new JavaScriptAction(@"
if(event.value == ''){
    app.alert('First Name is required!');
}
");
            // Add First Name Editbox to page
            page.Annotations.Add(firstName);

            // Draw Last Name Label
            canvas.DrawString("Last Name: ", font, blackBrush, 50, 100);

            // Create Last Name EditBox
            EditBox lastName = new EditBox(130, 100, 100, 30, "LastName");
            
            // Add javascript validation on focus lose
            lastName.OnLoseFocus = new JavaScriptAction(@"
if(event.value == ''){
    app.alert('Last Name is required!');
}
");
            page.Annotations.Add(lastName);

            // Create a button
            PushButton btnSubmit = new PushButton(50, 150, 150, 30, "SayHello");
            btnSubmit.Caption = "Say Hello!";

            // Javascript action to validate as well as displaying message
            btnSubmit.OnMouseDown = new JavaScriptAction(@"

var valFirstName = this.getField('FirstName').value;
var valLastName = this.getField('LastName').value;

if(valFirstName == '' || valLastName == ''){
    app.alert('Please complete incompete values in form!');
}
else{
    var messageToDisplay = 'Hello, ' + valLastName + ' ' + valFirstName + '!';
    app.alert(messageToDisplay, 4);
}

");

            page.Annotations.Add(btnSubmit);

            // Save document to file
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