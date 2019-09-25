## How to convert html email with attachments to pdf with pdf sdk in VB.NET and ByteScout PDF Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to convert html email with attachments to pdf with pdf sdk in VB.NET

Quickly learn how to convert html email with attachments to pdf with pdf sdk in VB.NET with this sample source code. What is ByteScout PDF Suite? It is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to convert html email with attachments to pdf with pdf sdk in your VB.NET application.

Want to save time? You will save a lot of time on writing and testing code as you may just take the VB.NET code from ByteScout PDF Suite for convert html email with attachments to pdf with pdf sdk below and use it in your application.  Simply copy and paste in your VB.NET project or application you and then run your app! If you want to use these VB.NET sample examples in one or many applications then they can be used easily.

ByteScout provides the free trial version of ByteScout PDF Suite along with the documentation and source code samples.

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

##### ****EmailToPDF_HTMLEmailWithAttachments.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "EmailToPDF_HTMLEmailWithAttachments", "EmailToPDF_HTMLEmailWithAttachments.vbproj", "{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}"
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
		SolutionGuid = {05DEC94F-8A54-473F-8949-E27D15706BFC}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****EmailToPDF_HTMLEmailWithAttachments.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>EmailToPDF_HTMLEmailWithAttachments.Program</StartupObject>
    <RootNamespace>EmailToPDF_HTMLEmailWithAttachments</RootNamespace>
    <AssemblyName>EmailToPDF_HTMLEmailWithAttachments</AssemblyName>
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
    <DocumentationFile>EmailToPDF_HTMLEmailWithAttachments.xml</DocumentationFile>
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
    <DocumentationFile>EmailToPDF_HTMLEmailWithAttachments.xml</DocumentationFile>
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
    <None Include="HtmlSampleEmailWithAttachment.msg">
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
Imports System.IO
Imports System.Text
Imports Bytescout.PDF
Imports Bytescout.PDF.Converters

Imports Font = Bytescout.PDF.Font
Imports SolidBrush = Bytescout.PDF.SolidBrush

Module Program

    Sub Main()

        Try
            ' Parse MessageContents using MsgReader Library
            ' MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
            Using msg = New MsgReader.Outlook.Storage.Message("HtmlSampleEmailWithAttachment.msg")

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

                ' Message subject
                Dim subject = msg.Subject

                ' Get Message Body
                Dim msgBody = msg.BodyHtml

                ' Prepare PDF docuemnt
                Using outputDocument As Document = New Document()

                    ' Add registration keys
                    outputDocument.RegistrationName = "demo"
                    outputDocument.RegistrationKey = "demo"

                    ' Add page
                    Dim page As Page = New Page(PaperFormat.A4)
                    outputDocument.Pages.Add(page)

                    ' Default font and brush
                    Dim font As Font = New Font(StandardFonts.Times, 12)
                    Dim brush As Brush = New SolidBrush()

                    ' Add Email contents
                    Dim topMargin As Integer = 0
                    topMargin += 20
                    page.Canvas.DrawString($"File Name: {msg.FileName}", font, brush, 20, topMargin)

                    topMargin += 20
                    page.Canvas.DrawString($"From: {from}", font, brush, 20, topMargin)

                    topMargin += 20
                    page.Canvas.DrawString($"Sent On: {(If(sentOn.HasValue, sentOn.Value.ToString("MM/dd/yyyy HH:mm"), ""))}", font, brush, 20, topMargin)

                    topMargin += 20
                    page.Canvas.DrawString($"To: {recipientsTo}", font, brush, 20, topMargin)

                    If Not String.IsNullOrEmpty(recipientsCc) Then
                        topMargin += 20
                        page.Canvas.DrawString($"CC: {recipientsCc}", font, brush, 20, topMargin)
                    End If

                    If Not String.IsNullOrEmpty(recipientBcc) Then
                        topMargin += 20
                        page.Canvas.DrawString($"BCC: {recipientBcc}", font, brush, 20, topMargin)
                    End If

                    topMargin += 20
                    page.Canvas.DrawString($"Subject: {subject}", font, brush, 20, topMargin)

                    topMargin += 20
                    page.Canvas.DrawString("Message body and attachments in next page.", font, brush, 20, topMargin)

                    ' Convert Html body to PDF in order to retain all formatting.
                    Using converter As HtmlToPdfConverter = New HtmlToPdfConverter()

                        converter.PageSize = PaperKind.A4
                        converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait

                        ' Convert input HTML to stream
                        Dim byteArrayBody As Byte() = Encoding.UTF8.GetBytes(msgBody)
                        Dim inputStream As MemoryStream = New MemoryStream(byteArrayBody)

                        ' Create output stream to store generated PDF file
                        Using outputStream = New MemoryStream()
                            ' Convert HTML to PDF
                            converter.ConvertHtmlToPdf(inputStream, outputStream)

                            ' Create new document from generated output stream
                            Dim docContent As Document = New Document(outputStream)

                            ' Append all pages to main PDF
                            For Each item As Page In docContent.Pages
                                outputDocument.Pages.Add(item)
                            Next

                            ' Get attachments from message (if any, and append to document)
                            If msg.Attachments.Count > 0 Then

                                For Each itmAttachment As MsgReader.Outlook.Storage.Attachment In msg.Attachments

                                    ' Get Memory Stream
                                    Dim attachmentMemoryStream As MemoryStream = New MemoryStream(itmAttachment.Data)

                                    ' Append Attachment
                                    Dim docAttachment As Document = New Document(attachmentMemoryStream)

                                    ' Append all pages to main PDF
                                    For Each item As Page In docAttachment.Pages
                                        outputDocument.Pages.Add(item)
                                    Next

                                Next

                            End If

                            ' Save output file
                            outputDocument.Save("result.pdf")

                            ' Open output file
                            Process.Start("result.pdf")

                        End Using
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Press enter key to exit...")
            Console.ReadLine()
        End Try

    End Sub

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