## How to read barcodes from image with barcode reader sdk in ASP.NET C# with ByteScout Barcode Suite

### Learn to code in ASP.NET C# to read barcodes from image with barcode reader sdk with this step-by-step tutorial

Read barcodes from image with barcode reader sdk is simple to apply in ASP.NET C# if you use these source codes below. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can be applied to read barcodes from image with barcode reader sdk using ASP.NET C#.

The SDK samples given below describe how to quickly make your application do read barcodes from image with barcode reader sdk in ASP.NET C# with the help of ByteScout Barcode Suite. This ASP.NET C# sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! If you want to use these ASP.NET C# sample examples in one or many applications then they can be used easily.

ByteScout Barcode Suite free trial version is available on our website. ASP.NET C# and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****Barcodes From Image.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{856C6546-084F-4A68-AD73-9F069B17E064}</ProjectGuid>
    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>Barcodes_From_Image</RootNamespace>
    <AssemblyName>Barcodes From Image</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <UseIISExpress>false</UseIISExpress>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCodeReader, Version=5.10.0.957, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>C:\Program Files\Bytescout BarCode Reader SDK\net4.00\Bytescout.BarCodeReader.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Web.Extensions" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Web" />
    <Reference Include="System.Configuration" />
    <Reference Include="System.Web.ApplicationServices" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="Account\ChangePassword.aspx" />
    <Content Include="Account\ChangePasswordSuccess.aspx" />
    <Content Include="Account\Login.aspx" />
    <Content Include="Account\Register.aspx" />
    <Content Include="Styles\Site.css" />
    <Content Include="Default.aspx" />
    <Content Include="Global.asax" />
    <Content Include="Scripts\jquery-1.4.1-vsdoc.js" />
    <Content Include="Scripts\jquery-1.4.1.js" />
    <Content Include="Scripts\jquery-1.4.1.min.js" />
    <Content Include="Web.config" />
    <Content Include="Web.Debug.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include="Web.Release.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Account\ChangePassword.aspx.cs">
      <DependentUpon>ChangePassword.aspx</DependentUpon>
      <SubType>ASPXCodeBehind</SubType>
    </Compile>
    <Compile Include="Account\ChangePassword.aspx.designer.cs">
      <DependentUpon>ChangePassword.aspx</DependentUpon>
    </Compile>
    <Compile Include="Account\ChangePasswordSuccess.aspx.cs">
      <DependentUpon>ChangePasswordSuccess.aspx</DependentUpon>
      <SubType>ASPXCodeBehind</SubType>
    </Compile>
    <Compile Include="Account\ChangePasswordSuccess.aspx.designer.cs">
      <DependentUpon>ChangePasswordSuccess.aspx</DependentUpon>
    </Compile>
    <Compile Include="Account\Login.aspx.cs">
      <DependentUpon>Login.aspx</DependentUpon>
      <SubType>ASPXCodeBehind</SubType>
    </Compile>
    <Compile Include="Account\Login.aspx.designer.cs">
      <DependentUpon>Login.aspx</DependentUpon>
    </Compile>
    <Compile Include="Account\Register.aspx.cs">
      <DependentUpon>Register.aspx</DependentUpon>
      <SubType>ASPXCodeBehind</SubType>
    </Compile>
    <Compile Include="Account\Register.aspx.designer.cs">
      <DependentUpon>Register.aspx</DependentUpon>
    </Compile>
    <Compile Include="Default.aspx.cs">
      <DependentUpon>Default.aspx</DependentUpon>
      <SubType>ASPXCodeBehind</SubType>
    </Compile>
    <Compile Include="Default.aspx.designer.cs">
      <DependentUpon>Default.aspx</DependentUpon>
    </Compile>
    <Compile Include="Global.asax.cs">
      <DependentUpon>Global.asax</DependentUpon>
    </Compile>
    <Compile Include="Properties\AssemblyInfo.cs" />
    <Compile Include="Site.Master.cs">
      <DependentUpon>Site.Master</DependentUpon>
      <SubType>ASPXCodeBehind</SubType>
    </Compile>
    <Compile Include="Site.Master.designer.cs">
      <DependentUpon>Site.Master</DependentUpon>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <Folder Include="App_Data\" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="Account\Web.config" />
    <Content Include="Site.Master" />
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
  <Import Project="$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\WebApplications\Microsoft.WebApplication.targets" />
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID="{349c5851-65df-11da-9384-00065b846f21}">
        <WebProjectProperties>
          <UseIIS>False</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>18617</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>
          </IISUrl>
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

##### ****Default.aspx:**
    
```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebTestSharp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Web Barcode Reader Tester (C#)</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Click browse button to upload an image<br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" /><br />
        <br />
        <asp:Button id="UploadButton" 
           Text="Upload file"
           OnClick="UploadButton_Click"
           runat="server">
       </asp:Button> 
        <br />
       <br />
        <asp:Label id="UploadStatusLabel" Text="" runat="server"></asp:Label> 
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox><br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="74px" Width="71px" /></div>
    </form>
</body>
</html>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.cs:**
    
```
using System;
using System.Drawing;
using System.IO;
using Bytescout.BarCodeReader;

namespace WebTestSharp
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

	public partial class _Default : System.Web.UI.Page
	{
		protected void UploadButton_Click(object sender, EventArgs e)
		{
			String savePath = @"\uploads\";

			if (FileUpload1.HasFile)
			{
			    string virtualFilePath = Path.Combine(savePath, FileUpload1.FileName);

                string serverFilePath = Server.MapPath(virtualFilePath);
                if (!Directory.Exists(Path.GetDirectoryName(serverFilePath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(serverFilePath));

                FileUpload1.SaveAs(serverFilePath);

				Image image = null;

				try
				{
                    using (Stream fileStream = File.OpenRead(serverFilePath))
				    {
				        image = Image.FromStream(fileStream);
				    }
				}
				catch (Exception)
				{
				}

				if (image == null)
				{
					UploadStatusLabel.Visible = true;
					UploadStatusLabel.Text = "Your file is not an image.";
					Image1.Visible = false;
					ListBox1.Visible = false;
				}
				else
				{
					UploadStatusLabel.Visible = false;
                    Image1.ImageUrl = virtualFilePath;
					Image1.Visible = true;
				    Image1.Width = image.Width;
				    Image1.Height = image.Height;
					ListBox1.Items.Clear();
					ListBox1.Visible = true;

                    FindBarcodes(serverFilePath);
					
					if (ListBox1.Items.Count == 0)
						ListBox1.Items.Add("No barcodes found");
				}
			}
			else
			{
				// Notify the user that a file was not uploaded.
				UploadStatusLabel.Text = "You did not specify a file to upload.";
			}
		}

		private void FindBarcodes(string fileName)
		{
			Reader reader = new Reader();

			// Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
			// Change to reader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
			// or select specific type, e.g. reader.BarcodeTypesToFind.PDF417 = True
			reader.BarcodeTypesToFind.SetAll1D();

			// reader.MediumTrustLevelCompatible = true; // uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

			reader.ReadFromFile(fileName);

			foreach (FoundBarcode barcode in reader.FoundBarcodes)
			{
				ListBox1.Items.Add(String.Format("{0} : {1}", barcode.Type, barcode.Value));
			}
		}
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

namespace WebTestSharp {
    
    
    public partial class _Default {
        
        /// <summary>
        /// form1 control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.HtmlControls.HtmlForm form1;
        
        /// <summary>
        /// FileUpload1 control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.FileUpload FileUpload1;
        
        /// <summary>
        /// UploadButton control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Button UploadButton;
        
        /// <summary>
        /// UploadStatusLabel control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Label UploadStatusLabel;
        
        /// <summary>
        /// ListBox1 control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.ListBox ListBox1;
        
        /// <summary>
        /// Image1 control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.Image Image1;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Global.asax.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Barcodes_From_Image
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Site.Master.cs:**
    
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Barcodes_From_Image
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Site.Master.designer.cs:**
    
```
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barcodes_From_Image
{


    public partial class SiteMaster
    {

        /// <summary>
        /// HeadContent control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.ContentPlaceHolder HeadContent;

        /// <summary>
        /// MasterPageScriptManager control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.ScriptManager MasterPageScriptManager;

        /// <summary>
        /// HeadLoginView control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.LoginView HeadLoginView;

        /// <summary>
        /// HeadHomeLink control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.HtmlControls.HtmlAnchor HeadHomeLink;

        /// <summary>
        /// HeadAboutLink control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.HtmlControls.HtmlAnchor HeadAboutLink;

        /// <summary>
        /// MainContent control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.WebControls.ContentPlaceHolder MainContent;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.Debug.config:**
    
```
<?xml version="1.0"?>

<!-- For more information on using web.config transformation visit http://go.microsoft.com/fwlink/?LinkId=125889 -->

<configuration xmlns:xdt="http://schemas.microsoft.com/XML-Document-Transform">
  <!--
    In the example below, the "SetAttributes" transform will change the value of 
    "connectionString" to use "ReleaseSQLServer" only when the "Match" locator 
    finds an atrribute "name" that has a value of "MyDB".
    
    <connectionStrings>
      <add name="MyDB" 
        connectionString="Data Source=ReleaseSQLServer;Initial Catalog=MyReleaseDB;Integrated Security=True" 
        xdt:Transform="SetAttributes" xdt:Locator="Match(name)"/>
    </connectionStrings>
  -->
  <system.web>
    <!--
      In the example below, the "Replace" transform will replace the entire 
      <customErrors> section of your web.config file.
      Note that because there is only one customErrors section under the 
      <system.web> node, there is no need to use the "xdt:Locator" attribute.
      
      <customErrors defaultRedirect="GenericError.htm"
        mode="RemoteOnly" xdt:Transform="Replace">
        <error statusCode="500" redirect="InternalError.htm"/>
      </customErrors>
    -->
  </system.web>
</configuration>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.Release.config:**
    
```
<?xml version="1.0"?>

<!-- For more information on using web.config transformation visit http://go.microsoft.com/fwlink/?LinkId=125889 -->

<configuration xmlns:xdt="http://schemas.microsoft.com/XML-Document-Transform">
  <!--
    In the example below, the "SetAttributes" transform will change the value of 
    "connectionString" to use "ReleaseSQLServer" only when the "Match" locator 
    finds an atrribute "name" that has a value of "MyDB".
    
    <connectionStrings>
      <add name="MyDB" 
        connectionString="Data Source=ReleaseSQLServer;Initial Catalog=MyReleaseDB;Integrated Security=True" 
        xdt:Transform="SetAttributes" xdt:Locator="Match(name)"/>
    </connectionStrings>
  -->
  <system.web>
    <compilation xdt:Transform="RemoveAttributes(debug)" />
    <!--
      In the example below, the "Replace" transform will replace the entire 
      <customErrors> section of your web.config file.
      Note that because there is only one customErrors section under the 
      <system.web> node, there is no need to use the "xdt:Locator" attribute.
      
      <customErrors defaultRedirect="GenericError.htm"
        mode="RemoteOnly" xdt:Transform="Replace">
        <error statusCode="500" redirect="InternalError.htm"/>
      </customErrors>
    -->
  </system.web>
</configuration>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.config:**
    
```
<?xml version="1.0"?>

<!--
  For more information on how to configure your ASP.NET application, please visit
  http://go.microsoft.com/fwlink/?LinkId=169433
  -->

<configuration>
  <connectionStrings>
    <add name="ApplicationServices"
         connectionString="data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnetdb.mdf;User Instance=true"
         providerName="System.Data.SqlClient" />
  </connectionStrings>

  <system.web>
    <compilation debug="true" targetFramework="4.0" />

    <authentication mode="Forms">
      <forms loginUrl="~/Account/Login.aspx" timeout="2880" />
    </authentication>

    <membership>
      <providers>
        <clear/>
        <add name="AspNetSqlMembershipProvider" type="System.Web.Security.SqlMembershipProvider" connectionStringName="ApplicationServices"
             enablePasswordRetrieval="false" enablePasswordReset="true" requiresQuestionAndAnswer="false" requiresUniqueEmail="false"
             maxInvalidPasswordAttempts="5" minRequiredPasswordLength="6" minRequiredNonalphanumericCharacters="0" passwordAttemptWindow="10"
             applicationName="/" />
      </providers>
    </membership>

    <profile>
      <providers>
        <clear/>
        <add name="AspNetSqlProfileProvider" type="System.Web.Profile.SqlProfileProvider" connectionStringName="ApplicationServices" applicationName="/"/>
      </providers>
    </profile>

    <roleManager enabled="false">
      <providers>
        <clear/>
        <add name="AspNetSqlRoleProvider" type="System.Web.Security.SqlRoleProvider" connectionStringName="ApplicationServices" applicationName="/" />
        <add name="AspNetWindowsTokenRoleProvider" type="System.Web.Security.WindowsTokenRoleProvider" applicationName="/" />
      </providers>
    </roleManager>

  </system.web>

  <system.webServer>
     <modules runAllManagedModulesForAllRequests="true"/>
  </system.webServer>
</configuration>

```

<!-- code block end -->