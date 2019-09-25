## How to generate barcode in webimage control in VB in ASP.NET and ByteScout Barcode SDK

### Tutorial on how to generate barcode in webimage control in VB in ASP.NET

The coding tutorials are designed to help you test the features without need to write your own code. ByteScout Barcode SDK can generate barcode in webimage control in VB. It can be used from ASP.NET. ByteScout Barcode SDK is the robost library (Software Development Kit) that is designed for automatic generation of high-quality barcodes for printing, electronic documents and pdf. All popular barcode types are supported from Code 39 and Code 129 to QR Code, UPC, GS1, GS-128, Datamatrix, PDF417, Maxicode and many others. Provides support for full customization of fonts, colors, output and printing sizes. Special tools are included to verify output quality and printing quality. Can add generated barcode into new or existing documents, images and PDF.

The SDK samples like this one below explain how to quickly make your application do generate barcode in webimage control in VB in ASP.NET with the help of ByteScout Barcode SDK. In order to implement the functionality, you should copy and paste this code for ASP.NET below into your code editor with your app, compile and run your application. Implementing ASP.NET application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

Free trial version of ByteScout Barcode SDK is available for download from our website. Get it to try other source code samples for ASP.NET.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




<!-- code block begin -->

##### ****Default.aspx:**
    
```
<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="VBWebImageTester._Default" %>

<%@ Register Assembly="Bytescout.BarCode" Namespace="Bytescout.BarCode" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>BarcodeWebImage test page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:BarcodeWebImage ID="BarcodeWebImage1" runat="server" RenderingHint="SystemDefault"
            SmoothingMode="Default" Value="DATA" ForeColor="Black" HorizontalAlignment="Right"
            Angle="Degrees0" CaptionPosition="Below" NarrowBarWidth="3" VerticalAlignment="Top"
            AddChecksum="False" AddChecksumToCaption="False" AdditionalCaptionPosition="Above"
            AdditionalCaptionFont="Arial, 13pt" BackColor="White" BarHeight="50" CaptionFont="Arial, 13pt"
            DrawCaption="True" WideToNarrowRatio="3" Symbology="Code128" AdditionalCaption=" ">
        </cc1:BarcodeWebImage>
        <br />
        <br />
        If you are using web control in new application you do need to modify the <strong>Web.config
        </strong>file in your application&#39;s virtual directory (or C:\Inetpub\wwwroot\
        if you don&#39;t have a separate application):<br />
        <br />
        For Visual Studio 2005 - 2010 insert the following lines into <strong>&lt;system.web&gt;</strong>
        section of <strong>Web.config</strong>:
        <br />
        <div class="code">
            <span codelanguage="other"><em>
                <br />
                &lt;httpHandlers&gt;<br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &lt;add verb="*" path="BarcodeHandler.aspx"
                type="Bytescout.BarCode.BarcodeHandler, Bytescout.BarCode"/&gt;<br />
                &lt;/httpHandlers&gt;</em><br />
            </span>
        </div>
        <br />
        For Visual Studio 2012 and later insert the following lines into <strong>&lt;system.webServer&gt;</strong>
        section of <strong>Web.config</strong>:
        <br />
        <div class="code">
            <span codelanguage="other"><em>
                <br />
                &lt;httpHandlers&gt;<br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &lt;add verb="*" path="BarcodeHandler.aspx"
                type="Bytescout.BarCode.BarcodeHandler, Bytescout.BarCode"/&gt;<br />
                &lt;/httpHandlers&gt;<br />
                &lt;validation validateIntegratedModeConfiguration="false"/&gt;</em><br />
            </span>
        </div>
    </div>
    </form>
</body>
</html>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.designer.vb:**
    
```
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.7905
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<summary>
'''_Default class.
'''</summary>
'''<remarks>
'''Auto-generated class.
'''</remarks>
Partial Public Class _Default

    '''<summary>
    '''form1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents form1 As Global.System.Web.UI.HtmlControls.HtmlForm

    '''<summary>
    '''BarcodeWebImage1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents BarcodeWebImage1 As Global.Bytescout.BarCode.BarcodeWebImage
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.vb:**
    
```
Partial Public Class _Default
    Inherits System.Web.UI.Page

    ' IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

    ' Temporary folder access is required for web application when you use ByteScout SDK in it.
    ' If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

    ' SOLUTION:

    ' If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

    ' If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

    ' In this case
    ' - check the User or User Group your web application is running under
    ' - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
    ' - restart your web application and try again

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****VBWebImageTester.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" ToolsVersion="4.0">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{3A7D5A77-53D8-4C87-80C1-DADEBC609C8B}</ProjectGuid>
    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{F184B08F-C81C-45F6-A57F-5ABD9991F28F}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <RootNamespace>VBWebImageTester</RootNamespace>
    <AssemblyName>VBWebImageTester</AssemblyName>
    <OldToolsVersion>3.5</OldToolsVersion>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\</OutputPath>
    <DocumentationFile>VBWebImageTester.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\</OutputPath>
    <DocumentationFile>VBWebImageTester.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, processorArchitecture=MSIL">
      <HintPath>..\..\..\Output\Bytescout.BarCode.dll</HintPath>
      <SpecificVersion>False</SpecificVersion>
    </Reference>
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
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Collections.Specialized" />
    <Import Include="System.Configuration" />
    <Import Include="System.Text" />
    <Import Include="System.Text.RegularExpressions" />
    <Import Include="System.Web" />
    <Import Include="System.Web.Caching" />
    <Import Include="System.Web.SessionState" />
    <Import Include="System.Web.Security" />
    <Import Include="System.Web.Profile" />
    <Import Include="System.Web.UI" />
    <Import Include="System.Web.UI.WebControls" />
    <Import Include="System.Web.UI.WebControls.WebParts" />
    <Import Include="System.Web.UI.HtmlControls" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="Default.aspx" />
    <Content Include="Web.config" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Default.aspx.vb">
      <SubType>ASPXCodeBehind</SubType>
      <DependentUpon>Default.aspx</DependentUpon>
    </Compile>
    <Compile Include="Default.aspx.designer.vb">
      <DependentUpon>Default.aspx</DependentUpon>
    </Compile>
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
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
          <DevelopmentServerPort>61282</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>
          </IISUrl>
          <NTLMAuthentication>False</NTLMAuthentication>
        </WebProjectProperties>
      </FlavorProperties>
    </VisualStudio>
  </ProjectExtensions>
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
        <httpHandlers>
            <add verb="*" path="BarcodeHandler.aspx" type="Bytescout.BarCode.BarcodeHandler, Bytescout.BarCode"/>
        </httpHandlers>

        <!-- 
            Set compilation debug="true" to insert debugging 
            symbols into the compiled page. Because this 
            affects performance, set this value to true only 
            during development.

            Visual Basic options:
            Set strict="true" to disallow all data type conversions 
            where data loss can occur. 
            Set explicit="true" to force declaration of all variables.
        -->
        <compilation debug="true" strict="false" explicit="true">
            <assemblies>
                <add assembly="System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=B77A5C561934E089"/>
                <add assembly="System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=B03F5F7F11D50A3A"/>
            </assemblies>
        </compilation>
        <pages>
            <namespaces>
                <clear/>
                <add namespace="System"/>
                <add namespace="System.Collections"/>
                <add namespace="System.Collections.Specialized"/>
                <add namespace="System.Configuration"/>
                <add namespace="System.Text"/>
                <add namespace="System.Text.RegularExpressions"/>
                <add namespace="System.Web"/>
                <add namespace="System.Web.Caching"/>
                <add namespace="System.Web.SessionState"/>
                <add namespace="System.Web.Security"/>
                <add namespace="System.Web.Profile"/>
                <add namespace="System.Web.UI"/>
                <add namespace="System.Web.UI.WebControls"/>
                <add namespace="System.Web.UI.WebControls.WebParts"/>
                <add namespace="System.Web.UI.HtmlControls"/>
            </namespaces>
        </pages>
        <!--
            The <authentication> section enables configuration 
            of the security authentication mode used by 
            ASP.NET to identify an incoming user. 
        -->
        <authentication mode="Windows"/>
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
    <system.webServer>

        <handlers>
            <add name="BarcodeHandler" verb="*" path="BarcodeHandler.aspx" type="Bytescout.BarCode.BarcodeHandler, Bytescout.BarCode"/>
        </handlers>
        <validation validateIntegratedModeConfiguration="false"/>

    </system.webServer>
</configuration>
```

<!-- code block end -->