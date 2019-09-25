## How to convert text email with attachments to pdf with pdf sdk in C# and ByteScout PDF Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to convert text email with attachments to pdf with pdf sdk in C#

Sample source code below will display you how to manage a complex task like convert text email with attachments to pdf with pdf sdk in C#. ByteScout PDF Suite can convert text email with attachments to pdf with pdf sdk. It can be applied from C#. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript.

Want to quickly learn? This fast application programming interfaces of ByteScout PDF Suite for C# plus the guidelines and the code below will help you quickly learn how to convert text email with attachments to pdf with pdf sdk. IF you want to implement the functionality, just copy and paste this code for C# below into your code editor with your app, compile and run your application. Check C# sample code samples to see if they respond to your needs and requirements for the project.

ByteScout PDF Suite free trial version is available on our website. C# and other programming languages are supported.

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

##### ****EmailToPDF_TextEmailWithAttachments.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{8B33CB1C-B6A2-4750-9D1C-EB963DC8A17D}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <RootNamespace>EmailToPDF_TextEmailWithAttachments</RootNamespace>
    <AssemblyName>EmailToPDF_TextEmailWithAttachments</AssemblyName>
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
    <Reference Include="Bytescout.PDF, Version=1.8.2.254, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout PDF SDK\net4.5\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDF.Converters">
      <HintPath>c:\Program Files\Bytescout PDF SDK\net4.5\Bytescout.PDF.Converters.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="MsgReader, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3ba01cf3434959fa, processorArchitecture=MSIL">
      <HintPath>packages\MsgReader.3.4.0\lib\net45\MsgReader.dll</HintPath>
    </Reference>
    <Reference Include="OpenMcdf, Version=2.2.1.2, Culture=neutral, PublicKeyToken=fdbb1629d7c00800, processorArchitecture=MSIL">
      <HintPath>packages\OpenMcdf.2.2.1.3\lib\net40\OpenMcdf.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Security" />
    <Reference Include="System.Web" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.cs" />
  </ItemGroup>
  <ItemGroup>
    <None Include="TxtSampleEmailWithAttachment.msg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="packages.config" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****EmailToPDF_TextEmailWithAttachments.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "EmailToPDF_TextEmailWithAttachments", "EmailToPDF_TextEmailWithAttachments.csproj", "{8B33CB1C-B6A2-4750-9D1C-EB963DC8A17D}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{8B33CB1C-B6A2-4750-9D1C-EB963DC8A17D}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{8B33CB1C-B6A2-4750-9D1C-EB963DC8A17D}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{8B33CB1C-B6A2-4750-9D1C-EB963DC8A17D}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{8B33CB1C-B6A2-4750-9D1C-EB963DC8A17D}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {23BDC0C1-F813-408F-B578-594556531EB9}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.cs:**
    
```
using Bytescout.PDF;
using Bytescout.PDF.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Text;

namespace EmailToPDF_TextEmailWithAttachments
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Parse MessageContents using MsgReader Library
                // MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
                using (var msg = new MsgReader.Outlook.Storage.Message("TxtSampleEmailWithAttachment.msg"))
                {
                    // Get Sender information
                    var from = msg.GetEmailSender(false, false);

                    // Message sent datetime
                    var sentOn = msg.SentOn;

                    // Recipient To information
                    var recipientsTo = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.To, false, false);

                    // Recipient CC information
                    var recipientsCc = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.Cc, false, false);

                    #region Generate and save html

                    // Get Html
                    HtmlGenerator oHtmlGenerator = new HtmlGenerator();
                    oHtmlGenerator.Title = $"Subject: {msg.Subject}";

                    oHtmlGenerator.AddParagraphBodyItem($"File Name: {msg.FileName}");
                    oHtmlGenerator.AddParagraphBodyItem($"From: {from}");
                    oHtmlGenerator.AddParagraphBodyItem($"Sent On: {(sentOn.HasValue ? sentOn.Value.ToString("MM/dd/yyyy HH:mm") : "")}");
                    oHtmlGenerator.AddParagraphBodyItem($"To: {recipientsTo}");
                    oHtmlGenerator.AddParagraphBodyItem($"Subject: {msg.Subject}");

                    if (!string.IsNullOrEmpty(recipientsCc))
                    {
                        oHtmlGenerator.AddParagraphBodyItem($"CC: {recipientsCc}");
                    }

                    oHtmlGenerator.AddRawBodyItem("<hr/>");

                    var msgBodySplitted = msg.BodyText.Split("\n".ToCharArray());

                    foreach (var itmBody in msgBodySplitted)
                    {
                        oHtmlGenerator.AddParagraphBodyItem(itmBody);
                    }

                    // Generate Html
                    oHtmlGenerator.SaveHtml("result.html");

                    #endregion

                    using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
                    {
                        converter.PageSize = PaperKind.A4;
                        converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait;

                        converter.ConvertHtmlToPdf("result.html", "result.pdf");

                        // Get attachments from message (if any, and append to document)
                        if (msg.Attachments.Count > 0)
                        {
                            using (Document outputDocument = new Document("result.pdf"))
                            {
                                foreach (MsgReader.Outlook.Storage.Attachment itmAttachment in msg.Attachments)
                                {
                                    // Get Memory Stream
                                    MemoryStream attachmentMemoryStream = new MemoryStream(itmAttachment.Data);

                                    // Append Attachment
                                    Document docAttachment = new Document(attachmentMemoryStream);

                                    // Append all pages to main PDF
                                    foreach (Page item in docAttachment.Pages)
                                    {
                                        outputDocument.Pages.Add(item);
                                    }
                                }
                                outputDocument.Save("result.pdf");
                            }
                        }

                        // Open result document in default associated application (for demo purpose)
                        ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
                        processStartInfo.UseShellExecute = true;
                        Process.Start(processStartInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter key to exit...");
                Console.ReadLine();
            }
        }
    }



    /// <summary>
    /// Html Generator class
    /// </summary>
    class HtmlGenerator
    {
        #region Constructor

        public HtmlGenerator()
        {
            this.StrBodyItems = new List<string>();
        }

        #endregion

        #region Variable Declarations

        public string Title { get; set; }
        private List<string> StrBodyItems { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Add Body Item
        /// </summary>
        public void AddRawBodyItem(string strBodyItem)
        {
            StrBodyItems.Add(strBodyItem);
        }

        /// <summary>
        /// Add Paragraph body item
        /// </summary>
        /// <param name="strText"></param>
        public void AddParagraphBodyItem(string strText)
        {
            StrBodyItems.Add(string.Format("<p style=''>{0}</p>", strText));
        }

        /// <summary>
        /// Gets Generated Html
        /// </summary>
        /// <returns></returns>
        public string GetHtml()
        {
            StringBuilder oRetHtml = new StringBuilder(string.Empty);

            oRetHtml.Append("<html>");

            oRetHtml.Append("<head>");
            oRetHtml.AppendFormat("<title>{0}</title>", Title);
            oRetHtml.Append(@"<style>p {
                                    line-height: 107.9 %;
                                    margin-bottom: 13pt;
                                    font-family: 'Arial', 'sans-serif';
                                    font-size: 15pt;
                                    margin-top: 0;
                                    margin-left: 0;
                                    margin-right: 0;
                            }</style>");
            oRetHtml.Append("</head>");

            oRetHtml.Append("<body>");
            foreach (var itemBody in StrBodyItems)
            {
                oRetHtml.Append(itemBody);
            }
            oRetHtml.Append("</body>");

            oRetHtml.Append("</html>");

            return oRetHtml.ToString();
        }

        /// <summary>
        /// Save all Html
        /// </summary>
        /// <param name="fileName"></param>
        public void SaveHtml(string fileName)
        {
            var allHtml = GetHtml();
            System.IO.File.WriteAllText(fileName, allHtml);
        }

        #endregion

    }

}
```

<!-- code block end -->    

<!-- code block begin -->

##### ****packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="MsgReader" version="3.4.0" targetFramework="net45" />
  <package id="OpenMcdf" version="2.2.1.3" targetFramework="net45" />
</packages>
```

<!-- code block end -->