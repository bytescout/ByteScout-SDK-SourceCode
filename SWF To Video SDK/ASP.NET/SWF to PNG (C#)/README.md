## SWF to PNG (c#) in ASP.NET with ByteScout SWF To Video SDK

### How To: tutorial on SWF to PNG (c#) in ASP.NET

Here you may find thousands pre-made source code pieces for easy implementation in your own programming ASP.NET projects. SWF to PNG (c#) in ASP.NET can be implemented with ByteScout SWF To Video SDK. ByteScout SWF To Video SDK is the specialized software development kit for programmers who need to add SWF (Flash Macromedia) to video conversion into their app. Supports WMV and AVI video output with sound as can take input flash movies with variables, actionscripts, dynamic files as input. You can control output video size, framerate, video and audio quality.

You will save a lot of time on writing and testing code as you may just take the code below and use it in your application. In order to implement this functionality, you should copy and paste code below into your app using code editor. Then compile and run your application. Further enhancement of the code will make it more vigorous.

Trial version can be obtained from our website for free. It includes this and other source code samples for ASP.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20SWF%20To%20Video%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20SWF%20To%20Video%20SDK%20Question) 

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
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SwfToPng._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.cs:**
    
```
// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode.

using System;
using System.IO;

using BytescoutSWFToVideo;

namespace SwfToPng
{
	public partial class _Default : System.Web.UI.Page
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

		protected void Page_Load(object sender, EventArgs e)
		{
			String inputSwfFile = Server.MapPath("Shapes.swf");

			// Create an instance of SWFToVideo ActiveX object
			SWFToVideo converter = new SWFToVideo();

			// Set debug log
			//converter.SetLogFile("log.txt");

			// Register SWFToVideo
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";


			// Enable trasparency - set BEFORE setting SWF filename
			converter.RGBAMode = true;

			// set input SWF file
			converter.InputSWFFileName = inputSwfFile;


			// Select the frame to extract (20th)
			converter.StartFrame = 20;
			converter.StopFrame = 20;

			// Run conversion.
			// Empty parameter means conversion to binary stream instead of file.
			converter.ConvertToPNG("");

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Display the extracted image:

			Response.Clear();
			// Add content type header 
			Response.ContentType = "image/png";
			// Set the content disposition 
			Response.AddHeader("Content-Disposition", "inline;filename=result.png");

			// Write the image bytes into the Response output stream 
			Response.BinaryWrite((byte[]) converter.BinaryImage);
			
			Response.End();
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
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwfToPng {
    
    
    /// <summary>
    /// _Default class.
    /// </summary>
    /// <remarks>
    /// Auto-generated class.
    /// </remarks>
    public partial class _Default {
        
        /// <summary>
        /// form1 control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected global::System.Web.UI.HtmlControls.HtmlForm form1;
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****README-FIRST-ASP-NET.txt:**
    
```
To use SWF To Video SDK on Web Server you may need to do the following adjustments to the server.

Confirmed: SDK works on virtual Windows 2003, 2008, 2012 servers with these adjustments.

1) Windows Server 2003 or later: 
If you are using WMV format then install Windows Media Player from "Desktop Experience"

2) Update flash player for Internet Explorer to the latest version. To update do the following
 - run Internet Explorer
 - open adobe.com
 - click on Update Flash Player
 - follow the instruction and install the latest flash player plugin for Internet Explorer
 
NOTE: on x64 Windows you should run Internet Explorer for x86 (not x64 version)

3) To convert interactive flash movies you should enable "allow interact with desktop" option

IMPORTANT: this may cause security breaches so pleaase be careful!

Recommended way:
- create new IIS user 
- use it to run web application to convert swf to video only
- set it to x86 mode only
- set it to "allow desktop interaction"

4) For Windows 2008, 2012 or later: 

If you are on Windows Server 2008 or higher and you have set "allow desktop interaction" already but still having the issue please try the following solution as suggested by Microsoft specialists:

Windows Server 2008, 2012 no longer allows interactive services, by default, which makes the Interactive Services Detection service unnecessary.
http://social.technet.microsoft.com/Forums/en-US/winserver8gen/thread/6fb5693a-a256-41f7-a1df-d30101d9f8b6

if you must run a the application that installs an interactive service on Windows Server 2012, you may sacrifice server stability for compatibility by changing the following registry value from the default of "1" into "0":
"NoInteractiveServices" in "HKLM\SYSTEM\CurrentControlSet\Control\Windows"

After doing so and rebooting, the Interactive Services Detection Service will start.

5) for x64 windows: you should set IIS to run your web application in x86 mode
6) for x64 Windows: you should compile your ASP.NET web application for x86 platform instead of AnyCPU


POSSIBLE ISSUES:
1) Flash movie with dynamic XML data shows "Can not load XML data". 
Solution: To check this issue try to run Internet Explorer on the server machine and open that flash movie (or URL to flash movie in Internet Explorer)

2) if you suspect the issue is caused by flash movie not properly running you may need to run it in Flash Player Debug version 
Solution: You should download "Windows Flash Player 11.7 ActiveX control content debugger (for IE)" from this page
http://www.adobe.com/support/flashplayer/downloads.html
Install, follow the instruction and try to open that flash movie in Internet Explorer again and flash player will display debug error messages from flash if needed

3) If your flash movie is designed to run on machines with sound card then you may experience issues related to the lack of audio devices.
Solution: if you are able to recompile flash movie then add the additional check for sound devices presented/installed

4) If your XML or external is loaded from different domain/subdomain then data can be restricted by cross-domain policies in the latest flash versions
Solution: make and upload cross-domain policy domain XML file to the domain(s) with the source data 
See 
http://kb2.adobe.com/cps/142/tn_14213.html
http://www.adobe.com/devnet/adobe-media-server/articles/cross-domain-xml-for-streaming.html
http://www.adobe.com/devnet/articles/crossdomain_policy_file_spec.html

--
Updated June 11, 2013
```

<!-- code block end -->    

<!-- code block begin -->

##### ****README-FIRST.txt:**
    
```
Interact with desktop permission may be required to run Screen Capturing SDK or SWF To Video SDK from service or to convert interactive ("live") flash movies with SWF To Video SDK

You may set this "Allow to interact with desktop" checkbox for the user that is used to run the service/app 
For IIS asp.net apps this user name is typically IIS_... user name

Important note for Windows Server 2008 or later

Newest Windows has disabled interactive services 

New Windows versions are no longer allowing to run interactive services by default to prevent services from accessing the desktop (to provide more security)

If you must run a Screen Capturing SDK or SWF To Video SDK from an interactive service then you may sacrifice server stability for compatibility by changing the following registry value from the default of "1" to "0".

HKLM\SYSTEM\CurrentControlSet\Control\Windows 
NoInteractiveServices

Then reboot so Windows will pick the new value from the registry and the Interactive Services Detection Service will start.

To make this change manually please do the following 

Start the registry editor (regedit.exe) in As Administrator mode
Locate the following Registry key: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Windows on the left side
double-click the NoInteractiveServices entry on the right side and change its value from 1 to 0
Then click OK and close the registry editor
Restart the computer
```

<!-- code block end -->    

<!-- code block begin -->

##### ****SwfToPng.csproj:**
    
```
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{50182C77-196E-4B94-AF8A-DF59A68BA706}</ProjectGuid>
    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>SwfToPng</RootNamespace>
    <AssemblyName>SwfToPng</AssemblyName>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\x86\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <OutputPath>bin\x86\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>x86</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Web" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Configuration" />
    <Reference Include="System.Web.Services" />
    <Reference Include="System.EnterpriseServices" />
    <Reference Include="System.Web.Mobile" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Content Include="Default.aspx" />
    <Content Include="Shapes.swf" />
    <Content Include="Web.config" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Default.aspx.cs">
      <SubType>ASPXCodeBehind</SubType>
      <DependentUpon>Default.aspx</DependentUpon>
    </Compile>
    <Compile Include="Default.aspx.designer.cs">
      <DependentUpon>Default.aspx</DependentUpon>
    </Compile>
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="BytescoutSWFToVideo">
      <Guid>{E76CD51E-7817-4D3E-8DD6-A71518D5AEC7}</Guid>
      <VersionMajor>1</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
    <COMReference Include="stdole">
      <Guid>{00020430-0000-0000-C000-000000000046}</Guid>
      <VersionMajor>2</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>primary</WrapperTool>
      <Isolated>False</Isolated>
    </COMReference>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
  <Import Project="$(MSBuildExtensionsPath)\Microsoft\VisualStudio\v8.0\WebApplications\Microsoft.WebApplication.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID="{349c5851-65df-11da-9384-00065b846f21}">
        <WebProjectProperties>
          <UseIIS>False</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>51445</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>
          </IISUrl>
          <NTLMAuthentication>False</NTLMAuthentication>
        </WebProjectProperties>
      </FlavorProperties>
    </VisualStudio>
  </ProjectExtensions>
  <PropertyGroup>
    <PreBuildEvent>
    </PreBuildEvent>
  </PropertyGroup>
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.config:**
    
```
<?xml version="1.0"?>

<configuration>
  
    <appSettings/>
    <connectionStrings/>
  
    <system.web>
        <!-- 
            Set compilation debug="true" to insert debugging 
            symbols into the compiled page. Because this 
            affects performance, set this value to true only 
            during development.
        -->
        <compilation debug="true" />
        <!--
            The <authentication> section enables configuration 
            of the security authentication mode used by 
            ASP.NET to identify an incoming user. 
        -->
        <authentication mode="Windows" />
        <!--
            The <customErrors> section enables configuration 
            of what to do if/when an unhandled error occurs 
            during the execution of a request. Specifically, 
            it enables developers to configure html error pages 
            to be displayed in place of a error stack trace.

        <customErrors mode="RemoteOnly" defaultRedirect="GenericErrorPage.htm">
            <error statusCode="403" redirect="NoAccess.htm" />
            <error statusCode="404" redirect="FileNotFound.htm" />
        </customErrors>
        -->
    </system.web>
</configuration>

```

<!-- code block end -->