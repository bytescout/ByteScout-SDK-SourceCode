## How to convert text email to pdf with pdf sdk in VB.NET with ByteScout PDF Suite

### This code in VB.NET shows how to convert text email to pdf with pdf sdk with this how to tutorial

An easy to understand sample source code to learn how to convert text email to pdf with pdf sdk in VB.NET ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to convert text email to pdf with pdf sdk with VB.NET.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VB.NET code from ByteScout PDF Suite for convert text email to pdf with pdf sdk below and use it in your application. Follow the instructions from scratch to work and copy the VB.NET code. Enjoy writing a code with ready-to-use sample codes in VB.NET.

The trial version of ByteScout PDF Suite can be downloaded for free from our website. It also includes source code samples for VB.NET and other programming languages.

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

##### ****EmailToPDF_TextEmail.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "EmailToPDF_TextEmail", "EmailToPDF_TextEmail.vbproj", "{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {ED62B20C-663D-4461-B83F-7E00E28143EB}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****EmailToPDF_TextEmail.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>EmailToPDF_TextEmail.Program</StartupObject>
    <RootNamespace>EmailToPDF_TextEmail</RootNamespace>
    <AssemblyName>EmailToPDF_TextEmail</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>Console</MyType>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>EmailToPDF_TextEmail.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>EmailToPDF_TextEmail.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
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
      <HintPath>packages\MsgReader.3.4.1\lib\net45\MsgReader.dll</HintPath>
    </Reference>
    <Reference Include="OpenMcdf, Version=2.2.1.2, Culture=neutral, PublicKeyToken=fdbb1629d7c00800, processorArchitecture=MSIL">
      <HintPath>packages\OpenMcdf.2.2.1.3\lib\net40\OpenMcdf.dll</HintPath>
    </Reference>
    <Reference Include="RtfPipe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=317a45ec926873fc, processorArchitecture=MSIL">
      <HintPath>packages\MsgReader.3.4.1\lib\net45\RtfPipe.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Security" />
    <Reference Include="System.Web" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
  </ItemGroup>
  <ItemGroup>
    <None Include="TxtSampleEmail.msg">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="packages.config" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Drawing.Printing
Imports System.Linq
Imports System.Text
Imports Bytescout.PDF
Imports Bytescout.PDF.Converters

Module Program

    Sub Main()

        Try

            Console.WriteLine("Please wait while PDF is being created...")

            ' Parse MessageContents using MsgReader Library
            ' MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
            Using msg = New MsgReader.Outlook.Storage.Message("TxtSampleEmail.msg")

                ' Get Sender information
                Dim from = msg.GetEmailSender(False, False)

                ' Message sent datetime
                Dim sentOn = msg.SentOn

                ' Recipient To information
                Dim recipientsTo = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.[To], False, False)

                ' Recipient CC information
                Dim recipientsCc = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.Cc, False, False)

                ' Recipient BCC information
                Dim recipientBcc = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.Bcc, False, False)


                Dim oHtmlGenerator As HtmlGenerator = New HtmlGenerator()

                oHtmlGenerator.Title = $"Subject: {msg.Subject}"
                oHtmlGenerator.AddParagraphBodyItem($"File Name: {msg.FileName}")
                oHtmlGenerator.AddParagraphBodyItem($"From: {from}")
                oHtmlGenerator.AddParagraphBodyItem($"Sent On: {(If(sentOn.HasValue, sentOn.Value.ToString("MM/dd/yyyy HH:mm"), ""))}")
                oHtmlGenerator.AddParagraphBodyItem($"To: {recipientsTo}")
                oHtmlGenerator.AddParagraphBodyItem($"Subject: {msg.Subject}")

                If Not String.IsNullOrEmpty(recipientsCc) Then
                    oHtmlGenerator.AddParagraphBodyItem($"CC: {recipientsCc}")
                End If

                If Not String.IsNullOrEmpty(recipientBcc) Then
                    oHtmlGenerator.AddParagraphBodyItem($"BCC: {recipientBcc}")
                End If

                oHtmlGenerator.AddRawBodyItem("<hr/>")
                Dim msgBodySplitted = msg.BodyText.Split(vbLf.ToCharArray())

                For Each itmBody In msgBodySplitted
                    oHtmlGenerator.AddParagraphBodyItem(itmBody)
                Next

                oHtmlGenerator.SaveHtml("result.html")

                Using converter As HtmlToPdfConverter = New HtmlToPdfConverter()
                    converter.PageSize = PaperKind.A4
                    converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait
                    converter.ConvertHtmlToPdf("result.html", "result.pdf")

                    Dim processStartInfo As ProcessStartInfo = New ProcessStartInfo("result.pdf")
                    processStartInfo.UseShellExecute = True

                    Process.Start(processStartInfo)

                End Using

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Press enter key to exit...")
            Console.ReadLine()
        End Try

    End Sub

    ''' <summary>
    ''' Html Generator class
    ''' </summary>
    Class HtmlGenerator

#Region "Constructors and variable declarations"

        Public Sub New()
            Me.StrBodyItems = New List(Of String)()
        End Sub

        Public Property Title As String
        Private Property StrBodyItems As List(Of String)

#End Region

#Region "Methods"

        ''' <summary>
        ''' Add Body Item
        ''' </summary>
        Public Sub AddRawBodyItem(ByVal strBodyItem As String)
            StrBodyItems.Add(strBodyItem)
        End Sub

        ''' <summary>
        ''' Add Paragraph body item
        ''' </summary>
        Public Sub AddParagraphBodyItem(ByVal strText As String)
            StrBodyItems.Add(String.Format("<p style=''>{0}</p>", strText))
        End Sub

        ''' <summary>
        ''' Gets generated HTML
        ''' </summary>
        Public Function GetHtml() As String
            Dim oRetHtml As StringBuilder = New StringBuilder(String.Empty)
            oRetHtml.Append("<html>")
            oRetHtml.Append("<head>")
            oRetHtml.AppendFormat("<title>{0}</title>", Title)
            oRetHtml.Append("<style>p {
                                    line-height: 107.9 %;
                                    margin-bottom: 13pt;
                                    font-family: 'Arial', 'sans-serif';
                                    font-size: 15pt;
                                    margin-top: 0;
                                    margin-left: 0;
                                    margin-right: 0;
                            }</style>")
            oRetHtml.Append("</head>")
            oRetHtml.Append("<body>")

            For Each itemBody In StrBodyItems
                oRetHtml.Append(itemBody)
            Next

            oRetHtml.Append("</body>")
            oRetHtml.Append("</html>")
            Return oRetHtml.ToString()
        End Function

        ''' <summary>
        ''' Save all HTML
        ''' </summary>
        Public Sub SaveHtml(ByVal fileName As String)
            Dim allHtml = GetHtml()
            System.IO.File.WriteAllText(fileName, allHtml)
        End Sub

#End Region

    End Class

End Module

```

<!-- code block end -->    

<!-- code block begin -->

##### ****packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="MsgReader" version="3.4.1" targetFramework="net45" />
  <package id="OpenMcdf" version="2.2.1.3" targetFramework="net45" />
</packages>
```

<!-- code block end -->