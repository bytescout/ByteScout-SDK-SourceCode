## How to convert email with attachemnts to PDF in VB.NET and ByteScout PDF SDK

### This tutorial will show how to convert email with attachemnts to PDF in VB.NET

With this source code sample you may quickly learn how to convert email with attachemnts to PDF in VB.NET. ByteScout PDF SDK is the SDK for pdf documents generation, modification and updates. Can also generate and fill PDF forms. Provides support for text (fonts, style, size, font family), layers, pdf form fields, vector and raster drawings and you can use it to convert email with attachemnts to PDF with VB.NET.

This rich sample source code in VB.NET for ByteScout PDF SDK includes the number of functions and options you should do calling the API to convert email with attachemnts to PDF. In order to implement the functionality, you should copy and paste this code for VB.NET below into your code editor with your app, compile and run your application. Detailed tutorials and documentation are available along with installed ByteScout PDF SDK if you'd like to dive deeper into the topic and the details of the API.

You can download free trial version of ByteScout PDF SDK from our website to see and try many others source code samples for VB.NET.

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

##### ****EmailToPDF_EmailWithAttachment.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}") = "EmailToPDF_EmailWithAttachment", "EmailToPDF_EmailWithAttachment.vbproj", "{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}"
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
		SolutionGuid = {CFDB2579-28C4-448D-8CAE-279B99F84573}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****EmailToPDF_EmailWithAttachment.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{E0A3BA18-AA04-4C1E-AF80-F7232FD8D83E}</ProjectGuid>
    <OutputType>Exe</OutputType>
    <StartupObject>EmailToPDF_EmailWithAttachment.Program</StartupObject>
    <RootNamespace>EmailToPDF_EmailWithAttachment</RootNamespace>
    <AssemblyName>EmailToPDF_EmailWithAttachment</AssemblyName>
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
    <DocumentationFile>EmailToPDF_EmailWithAttachment.xml</DocumentationFile>
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
    <DocumentationFile>EmailToPDF_EmailWithAttachment.xml</DocumentationFile>
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
    <None Include="EmailWithAttachments.msg">
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
            Using msg = New MsgReader.Outlook.Storage.Message("EmailWithAttachments.msg")

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
                    page.Canvas.DrawString("Message body in next page.", font, brush, 20, topMargin)

                    Using converter As HtmlToPdfConverter = New HtmlToPdfConverter()
                        converter.PageSize = PaperKind.A4
                        converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait

                        ' Get all inline attachment, and replace them
                        For Each itmAttachment As MsgReader.Outlook.Storage.Attachment In msg.Attachments

                            If itmAttachment.IsInline Then
                                Dim oData = itmAttachment.Data
                                Dim dataBase64 = Convert.ToBase64String(oData)

                                ' Replace within email
                                msgBody = msgBody.Replace($"src=""{itmAttachment.FileName}""", $"src=""data:image/jpeg;base64,{dataBase64}""")
                            End If
                        Next

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

                            ' Apped all other attachments
                            For Each itmAttachment As MsgReader.Outlook.Storage.Attachment In msg.Attachments

                                If Not itmAttachment.IsInline Then
                                    ' Attachment is image, so adding accordingly
                                    Dim pageAttachment = New Page(PaperFormat.A4)
                                    Dim canvas As Canvas = pageAttachment.Canvas

                                    Dim oAttachmentStream = New MemoryStream(itmAttachment.Data)
                                    Dim imageAttachment As Image = New Image(oAttachmentStream)

                                    canvas.DrawImage(imageAttachment, 20, 20)

                                    ' Add attachment
                                    outputDocument.Pages.Add(pageAttachment)
                                End If
                            Next
                            ' Save output file
                            outputDocument.Save("result.pdf")
                        End Using
                    End Using

                    ' Open output file
                    Process.Start("result.pdf")
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