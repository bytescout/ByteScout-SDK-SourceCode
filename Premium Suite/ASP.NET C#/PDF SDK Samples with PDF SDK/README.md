## PDF SDK samples with PDF SDK in ASP.NET C# using ByteScout Premium Suite

### Learn PDF SDK samples with PDF SDK in ASP.NET C#

The documentation is crafted to assist you to apply the features on your side easily. ByteScout Premium Suite helps with PDF SDK samples with PDF SDK in ASP.NET C#. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 Want to speed up the application development? Then this ASP.NET C#, code samples for ASP.NET C#, developers help to speed up the application development and writing a code when using ByteScout Premium Suite. If you want to know how it works, then this ASP.NET C# sample code should be copied and pasted into your application’s code editor. Then just compile and run it. These ASP.NET C# sample examples can be used in one or many applications.

ByteScout Premium Suite is available as a free trial. You may get it from our website along with all other source code samples for ASP.NET C# applications.

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

##### ****Default.aspx:**
    
```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PDFSDKSamples.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PDF SDK Samples</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <div style="font-size: 20px; text-decoration: underline;">
                <br /> This page demostrates Byscout PDF SDK, by perfomring following PDF related operations.<br /> <br /><br />
            </div>

            <div>
                <asp:Button ID="btnPDFConversionFromHtml" runat="server" Text="1. Html to PDF conversion" Width="360px" OnClick="btnPDFConversionFromHtml_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblPDFConversationFromHTML" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnTableCreation" runat="server" Text="2. Table Creation" Width="360px" OnClick="btnTableCreation_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblTableCreation" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnSplitPDF" runat="server" Text="3. Splitting PDF" Width="360px" OnClick="btnSplitPDF_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblSplitPDF" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnMergePDF" runat="server" Text="4. Merging PDF" Width="360px" OnClick="btnMergePDF_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblMergePDF" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnProtectingPDF" runat="server" Text="5. Protecting PDF (password=password1)" Width="360px" OnClick="btnProtectingPDF_Click" />
                &nbsp;&nbsp;<asp:Label ID="lblProtectingPDF" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.cs:**
    
```
using Bytescout.PDF;
using Bytescout.PDF.Converters;
using System;
using System.Drawing.Printing;
using System.IO;

namespace PDFSDKSamples
{
    public partial class Default : System.Web.UI.Page
    {

        /*
        IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

        Temporary folder access is required for web application when you use ByteScout SDK in it.
        If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

        SOLUTION:

        If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

        If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

        In this case
        - check the User or User Group your web application is running under
        - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
        - restart your web application and try again

        */

        #region Events

        /// <summary>
        /// Handle HTML to PDF conversation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPDFConversionFromHtml_Click(object sender, EventArgs e)
        {
            try
            {
                // HTML to PDF Conversion
                using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
                {
                    converter.PageSize = PaperKind.A4;
                    converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait;
                    converter.Footer = "<p style=\"color: blue;\">FOOTER TEXT</p>";

                    // Get html document in input stream
                    FileStream inputFileStream = new FileStream(Server.MapPath("~/SampleFiles/sample.html"), FileMode.Open);

                    // Define output stream
                    MemoryStream outputStream = new MemoryStream();

                    // Get converted PDF docuement in output stream
                    converter.ConvertHtmlToPdf(inputFileStream, outputStream);

                    // Download converted document
                    Response.Clear();
                    Response.ClearHeaders();

                    Response.AppendHeader("Content-Length", outputStream.Length.ToString());
                    Response.ContentType = "text/pdf";
                    Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_ConvertedFromHTML.pdf\"");

                    Response.BinaryWrite(outputStream.ToArray());
                    Response.End();
                }
            }
            catch (Exception ex)
            {
                lblPDFConversationFromHTML.Text = "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Handle Table Creation with PDF SDK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnTableCreation_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new document
                Document pdfDocument = new Document();
                pdfDocument.RegistrationName = "demo";
                pdfDocument.RegistrationKey = "demo";

                // Add page
                Bytescout.PDF.Page page = new Bytescout.PDF.Page(PaperFormat.A4);
                pdfDocument.Pages.Add(page);

                DeviceColor lightGrayColor = new ColorGray(200);
                DeviceColor whiteColor = new ColorGray(255);
                DeviceColor lightBlueColor = new ColorRGB(200, 200, 250);
                DeviceColor lightRedColor = new ColorRGB(255, 200, 200);

                // Create a table and set default background color
                Bytescout.PDF.Table table = new Bytescout.PDF.Table();
                table.BackgroundColor = lightGrayColor;

                // Add row headers column and set its color
                table.Columns.Add(new TableColumn("RowHeaders"));
                table.Columns[0].BackgroundColor = lightGrayColor;

                // Add columns A, B, C, ...
                for (int c = 0; c < 10; c++)
                {
                    string columnName = Convert.ToChar('A' + c).ToString();
                    table.Columns.Add(new TableColumn(columnName, columnName));
                }

                // Add rows
                for (int r = 0; r < 10; r++)
                {
                    // Create new row and set its background color
                    Bytescout.PDF.TableRow row = table.NewRow();
                    row.BackgroundColor = whiteColor;

                    // Set row header text
                    row["RowHeaders"].Text = (r + 1).ToString();

                    // Set cell text
                    for (int c = 0; c < 10; c++)
                    {
                        string columnName = Convert.ToChar('A' + c).ToString();
                        row[columnName].Text = columnName + (r + 1);
                    }

                    // Add the row to the table
                    table.Rows.Add(row);
                }

                // Decorate the table
                table.Rows[1]["B"].BackgroundColor = lightRedColor;
                table.Columns[2].BackgroundColor = lightBlueColor;
                table.Rows[1].BackgroundColor = lightBlueColor;
                table.Rows[1]["RowHeaders"].BackgroundColor = lightBlueColor;

                // Draw the table on canvas
                page.Canvas.DrawTable(table, 20, 20);

                // Save created PDF to memory stream
                MemoryStream memoryStream = new MemoryStream();
                pdfDocument.Save(memoryStream);

                // Perform download of file
                Response.Clear();
                Response.ClearHeaders();

                Response.AppendHeader("Content-Length", memoryStream.Length.ToString());
                Response.ContentType = "text/pdf";
                Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_PDFWithTable.pdf\"");

                Response.BinaryWrite(memoryStream.ToArray());
                Response.End();
            }
            catch (Exception ex)
            {
                lblTableCreation.Text = "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Demonstrate Splitting PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSplitPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Open Document
                Document document = new Document(Server.MapPath("~/SampleFiles/sample.pdf"));
                document.RegistrationName = "demo";
                document.RegistrationKey = "demo";

                // Create Split PDF Document
                Document documentSplitPDF = new Document();
                documentSplitPDF.RegistrationName = "demo";
                documentSplitPDF.RegistrationKey = "demo";

                // Get page 1&2 to Split PDF document
                for (int i = 0; i < 2; i++)
                {
                    documentSplitPDF.Pages.Add(document.Pages[i]);
                }

                // Save splitted PDF to memory stream
                MemoryStream memoryStream = new MemoryStream();
                documentSplitPDF.Save(memoryStream);

                // Perform download of file
                Response.Clear();
                Response.ClearHeaders();

                Response.AppendHeader("Content-Length", memoryStream.Length.ToString());
                Response.ContentType = "text/pdf";
                Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_splitPDF.pdf\"");

                Response.BinaryWrite(memoryStream.ToArray());
                Response.End();
            }
            catch (Exception ex)
            {
                lblSplitPDF.Text = "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Handle Merging PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnMergePDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Open first document
                Document document1 = new Document(Server.MapPath("~/SampleFiles/sample.pdf"));
                document1.RegistrationName = "demo";
                document1.RegistrationKey = "demo";

                // Open second document
                Document document2 = new Document(Server.MapPath("~/SampleFiles/sample2.pdf"));
                document2.RegistrationName = "demo";
                document2.RegistrationKey = "demo";

                // Add pages from document2 to document1
                for (int i = 0; i < document2.Pages.Count; ++i)
                {
                    document1.Pages.Add(document2.Pages[i]);
                }

                // Save merged PDF to memory stream
                MemoryStream memoryStream = new MemoryStream();
                document1.Save(memoryStream);

                // Perform download of file
                Response.Clear();
                Response.ClearHeaders();

                Response.AppendHeader("Content-Length", memoryStream.Length.ToString());
                Response.ContentType = "text/pdf";
                Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_mergedPDF.pdf\"");

                Response.BinaryWrite(memoryStream.ToArray());
                Response.End();
            }
            catch (Exception ex)
            {
                lblMergePDF.Text = "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Handle Protecting PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnProtectingPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (Document pdfDocument = new Document())
                {
                    // Set registration key and password
                    pdfDocument.RegistrationKey = "demo";
                    pdfDocument.RegistrationName = "demo";

                    // PDF file path
                    string pdfFilePath = Server.MapPath("~/SampleFiles/sample.pdf");

                    // Load pdf file
                    pdfDocument.Load(pdfFilePath);

                    // Set document encryption algorythm
                    pdfDocument.Security.EncryptionAlgorithm = EncryptionAlgorithm.RC4_40bit;

                    // Set various user permissions
                    pdfDocument.Security.AllowPrintDocument = false;
                    pdfDocument.Security.AllowContentExtraction = false;
                    pdfDocument.Security.AllowModifyAnnotations = false;
                    pdfDocument.Security.PrintQuality = PrintQuality.LowResolution;

                    // PDF format supports two kinds of passwords: owner and user password.
                    // User password allows to view document and perform allowed actions.
                    // Owner password allows everything, including changing passwords and permissions.

                    // Set owner password
                    // pdfDocument.Security.OwnerPassword = "ownerpassword";

                    // Set user password
                    pdfDocument.Security.UserPassword = "password1";

                    // Extract PDF document to Stream
                    MemoryStream memoryStream = new MemoryStream();
                    pdfDocument.Save(memoryStream);

                    // Perform download of file
                    Response.Clear();
                    Response.ClearHeaders();

                    Response.AppendHeader("Content-Length", memoryStream.Length.ToString());
                    Response.ContentType = "text/pdf";
                    Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_protectedPDF.pdf\"");

                    Response.BinaryWrite(memoryStream.ToArray());
                    Response.End();
                }
            }
            catch (Exception ex)
            {
                lblProtectingPDF.Text = "Error: " + ex.Message;
            }

        }

        #endregion
    }
}
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.designer.cs:**
    
```
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. 
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDFSDKSamples {
    
    
    public partial class Default {
        
        /// <summary>
        /// form1 control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.HtmlControls.HtmlForm form1;
        
        /// <summary>
        /// btnPDFConversionFromHtml control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnPDFConversionFromHtml;
        
        /// <summary>
        /// lblPDFConversationFromHTML control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblPDFConversationFromHTML;
        
        /// <summary>
        /// btnTableCreation control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnTableCreation;
        
        /// <summary>
        /// lblTableCreation control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblTableCreation;
        
        /// <summary>
        /// btnSplitPDF control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnSplitPDF;
        
        /// <summary>
        /// lblSplitPDF control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblSplitPDF;
        
        /// <summary>
        /// btnMergePDF control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnMergePDF;
        
        /// <summary>
        /// lblMergePDF control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblMergePDF;
        
        /// <summary>
        /// btnProtectingPDF control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button btnProtectingPDF;
        
        /// <summary>
        /// lblProtectingPDF control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label lblProtectingPDF;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****PDFSDKSamples.csproj:**
    
```
<Project ToolsVersion="15.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{762F5B5F-2A6B-46F8-9B22-6107C2514B41}</ProjectGuid>
    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>PDFSDKSamples</RootNamespace>
    <AssemblyName>PDFSDKSamples</AssemblyName>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
    <UseIISExpress>true</UseIISExpress>
    <Use64BitIISExpress />
    <IISExpressSSLPort />
    <IISExpressAnonymousAuthentication />
    <IISExpressWindowsAuthentication />
    <IISExpressUseClassicPipelineMode />
    <UseGlobalApplicationHostFile />
    <TargetFrameworkProfile />
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <Prefer32Bit>false</Prefer32Bit>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.PDF, Version=1.8.2.254, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF SDK\net2.0\Bytescout.PDF.dll</HintPath>
    </Reference>
    <Reference Include="Bytescout.PDF.Converters, Version=1.8.2.254, Culture=neutral, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout PDF SDK\Redistributable\net4.5\Bytescout.PDF.Converters.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Web.DynamicData" />
    <Reference Include="System.Web.Entity" />
    <Reference Include="System.Web.ApplicationServices" />
    <Reference Include="System.ComponentModel.DataAnnotations" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Web.Extensions" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Web" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Configuration" />
    <Reference Include="System.Web.Services" />
    <Reference Include="System.EnterpriseServices" />
    <Reference Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="SampleFiles\sample.html" />
    <Content Include="SampleFiles\sample.pdf" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="Default.aspx" />
    <Content Include="Web.config" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Default.aspx.cs">
      <DependentUpon>Default.aspx</DependentUpon>
      <SubType>ASPXCodeBehind</SubType>
    </Compile>
    <Compile Include="Default.aspx.designer.cs">
      <DependentUpon>Default.aspx</DependentUpon>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Content Include="SampleFiles\sample2.pdf" />
  </ItemGroup>
  <PropertyGroup>
    <VisualStudioVersion Condition="'$(VisualStudioVersion)' == ''">10.0</VisualStudioVersion>
    <VSToolsPath Condition="'$(VSToolsPath)' == ''">$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
  <Import Project="$(VSToolsPath)\WebApplications\Microsoft.WebApplication.targets" Condition="'$(VSToolsPath)' != ''" />
  <Import Project="$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\WebApplications\Microsoft.WebApplication.targets" Condition="false" />
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID="{349c5851-65df-11da-9384-00065b846f21}">
        <WebProjectProperties>
          <UseIIS>True</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>57323</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>http://localhost:57323/</IISUrl>
          <NTLMAuthentication>False</NTLMAuthentication>
          <UseCustomServer>False</UseCustomServer>
          <CustomServerUrl>
          </CustomServerUrl>
          <SaveServerSettingsInUserFile>False</SaveServerSettingsInUserFile>
        </WebProjectProperties>
      </FlavorProperties>
    </VisualStudio>
  </ProjectExtensions>
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

##### ****PDFSDKSamples.sln:**
    
```

Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 15
VisualStudioVersion = 15.0.27703.2026
MinimumVisualStudioVersion = 10.0.40219.1
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "PDFSDKSamples", "PDFSDKSamples.csproj", "{762F5B5F-2A6B-46F8-9B22-6107C2514B41}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{762F5B5F-2A6B-46F8-9B22-6107C2514B41}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{762F5B5F-2A6B-46F8-9B22-6107C2514B41}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{762F5B5F-2A6B-46F8-9B22-6107C2514B41}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{762F5B5F-2A6B-46F8-9B22-6107C2514B41}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {912E8124-8E79-49D2-BD0A-364AA7D726DA}
	EndGlobalSection
EndGlobal

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.config:**
    
```
<?xml version="1.0"?>
<!--
  For more information on how to configure your ASP.NET application, please visit
  https://go.microsoft.com/fwlink/?LinkId=169433
  -->
<configuration>
  <!--
    For a description of web.config changes see http://go.microsoft.com/fwlink/?LinkId=235367.

    The following attributes can be set on the <httpRuntime> tag.
      <system.Web>
        <httpRuntime targetFramework="4.5" />
      </system.Web>
  -->
  <system.web>
    <compilation debug="true" targetFramework="4.5"/>
    <pages controlRenderingCompatibilityVersion="4.0"/>
  </system.web>
</configuration>
```

<!-- code block end -->