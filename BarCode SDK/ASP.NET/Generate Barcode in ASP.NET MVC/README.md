## How to generate barcode in ASP in ASP.NET and ByteScout Barcode SDK

### This code in ASP.NET shows how to generate barcode in ASP with this how to tutorial

The sample source codes on this page shows how to generate barcode in ASP in ASP.NET. Want to generate barcode in ASP in your ASP.NET app? ByteScout Barcode SDK is designed for it. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images.

This code snippet below for ByteScout Barcode SDK works best when you need to quickly generate barcode in ASP in your ASP.NET application. In order to implement the functionality, you should copy and paste this code for ASP.NET below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in ASP.NET.

You can download free trial version of ByteScout Barcode SDK from our website to see and try many others source code samples for ASP.NET.

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

##### ****BytescoutBarCodeHelper.cs:**
    
```
using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using Bytescout.BarCode;

namespace BarcodeGenerator.Helpers
{
    public static class GeneratorHelper
    {
        public static string GetBase64Barcode(string value, SymbologyType symbology, bool addChecksum = false)
        {
            using (var barcode = new Barcode())
            {
                barcode.Symbology = symbology;
                barcode.Value = value;

                barcode.AddChecksum = addChecksum;

                var imageBytes = barcode.GetImageBytesPNG();

                return Convert.ToBase64String(imageBytes);
            }
        }

        public static IHtmlString GetBarcode(this HtmlHelper helper,
                                          string value,
                                          SymbologyType symbology,
                                          bool addChecksum = false)
        {
            var base64ImageBytes = GetBase64Barcode(value, symbology, addChecksum);
            var str = string.Format("<img src=\"data:image/png;base64,{0}\">", base64ImageBytes);
            return MvcHtmlString.Create(str);
           
        }

        public static IHtmlString EmbeddedBarcodeImage(this HtmlHelper helper,
                                          string value,
                                          SymbologyType symbology,
                                          bool addChecksum = false)
        {
            using (var barcode = new Barcode())
            {
                barcode.Symbology = symbology;
                barcode.Value = value;

                barcode.AddChecksum = addChecksum;

                var imageBytes = barcode.GetImageBytesPNG();
                var str = string.Format("data:image/png;base64,{0}",
                                        Convert.ToBase64String(imageBytes));
                return MvcHtmlString.Create(str);
            }
        }      
        
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
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****MvcApplication1.csproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{80C7FCB9-5BFA-4B1B-915D-E8234537C81D}</ProjectGuid>
    <ProjectTypeGuids>{E3E379DF-F4C6-4180-9B81-6769533ABE47};{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MvcApplication1</RootNamespace>
    <AssemblyName>MvcApplication1</AssemblyName>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <MvcBuildViews>false</MvcBuildViews>
    <UseIISExpress>true</UseIISExpress>
    <IISExpressSSLPort />
    <IISExpressAnonymousAuthentication />
    <IISExpressWindowsAuthentication />
    <IISExpressUseClassicPipelineMode />
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
    <Reference Include="Bytescout.BarCode, Version=3.30.0.667, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>c:\Program Files\Bytescout BarCode Generator SDK\net4.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Data.Entity" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Web.DynamicData" />
    <Reference Include="System.Web.Entity" />
    <Reference Include="System.Web.ApplicationServices" />
    <Reference Include="System.ComponentModel.DataAnnotations" />
    <Reference Include="System.Core" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Web" />
    <Reference Include="System.Web.Extensions" />
    <Reference Include="System.Web.Abstractions" />
    <Reference Include="System.Web.Routing" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Configuration" />
    <Reference Include="System.Web.Services" />
    <Reference Include="System.EnterpriseServices" />
    <Reference Include="EntityFramework">
      <HintPath>..\packages\EntityFramework.5.0.0\lib\net40\EntityFramework.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Web.Infrastructure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.Web.Infrastructure.1.0.0.0\lib\net40\Microsoft.Web.Infrastructure.dll</HintPath>
    </Reference>
    <Reference Include="Microsoft.Web.Mvc.FixedDisplayModes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.Mvc.FixedDisplayModes.1.0.0\lib\net40\Microsoft.Web.Mvc.FixedDisplayModes.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json">
      <HintPath>..\packages\Newtonsoft.Json.4.5.11\lib\net40\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="System.Net.Http">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.Net.Http.2.0.30506.0\lib\net40\System.Net.Http.dll</HintPath>
    </Reference>
    <Reference Include="System.Net.Http.Formatting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <HintPath>..\packages\Microsoft.AspNet.WebApi.Client.4.0.30506.0\lib\net40\System.Net.Http.Formatting.dll</HintPath>
    </Reference>
    <Reference Include="System.Net.Http.WebRequest">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.Net.Http.2.0.30506.0\lib\net40\System.Net.Http.WebRequest.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <HintPath>..\packages\Microsoft.AspNet.WebApi.Core.4.0.30506.0\lib\net40\System.Web.Http.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Http.WebHost, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <HintPath>..\packages\Microsoft.AspNet.WebApi.WebHost.4.0.30506.0\lib\net40\System.Web.Http.WebHost.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Mvc, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.Mvc.4.0.30506.0\lib\net40\System.Web.Mvc.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Optimization">
      <HintPath>..\packages\Microsoft.AspNet.Web.Optimization.1.0.0\lib\net40\System.Web.Optimization.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Providers">
      <HintPath>..\packages\Microsoft.AspNet.Providers.Core.1.2\lib\net40\System.Web.Providers.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.Razor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.Razor.2.0.30506.0\lib\net40\System.Web.Razor.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.2.0.30506.0\lib\net40\System.Web.WebPages.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages.Deployment, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.2.0.30506.0\lib\net40\System.Web.WebPages.Deployment.dll</HintPath>
    </Reference>
    <Reference Include="System.Web.WebPages.Razor, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <Private>True</Private>
      <HintPath>..\packages\Microsoft.AspNet.WebPages.2.0.30506.0\lib\net40\System.Web.WebPages.Razor.dll</HintPath>
    </Reference>
    <Reference Include="WebGrease">
      <Private>True</Private>
      <HintPath>..\packages\WebGrease.1.3.0\lib\WebGrease.dll</HintPath>
    </Reference>
    <Reference Include="Antlr3.Runtime">
      <Private>True</Private>
      <HintPath>..\packages\WebGrease.1.3.0\lib\Antlr3.Runtime.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
    <Compile Include="App_Start\BundleConfig.cs" />
    <Compile Include="App_Start\FilterConfig.cs" />
    <Compile Include="App_Start\RouteConfig.cs" />
    <Compile Include="App_Start\WebApiConfig.cs" />
    <Compile Include="Controllers\HomeController.cs" />
    <Compile Include="Global.asax.cs">
      <DependentUpon>Global.asax</DependentUpon>
    </Compile>
    <Compile Include="Helpers\BytescoutBarCodeHelper.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="Content\themes\base\images\ui-bg_flat_0_aaaaaa_40x100.png" />
    <Content Include="Content\themes\base\images\ui-bg_flat_75_ffffff_40x100.png" />
    <Content Include="Content\themes\base\images\ui-bg_glass_55_fbf9ee_1x400.png" />
    <Content Include="Content\themes\base\images\ui-bg_glass_65_ffffff_1x400.png" />
    <Content Include="Content\themes\base\images\ui-bg_glass_75_dadada_1x400.png" />
    <Content Include="Content\themes\base\images\ui-bg_glass_75_e6e6e6_1x400.png" />
    <Content Include="Content\themes\base\images\ui-bg_glass_95_fef1ec_1x400.png" />
    <Content Include="Content\themes\base\images\ui-bg_highlight-soft_75_cccccc_1x100.png" />
    <Content Include="Content\themes\base\images\ui-icons_222222_256x240.png" />
    <Content Include="Content\themes\base\images\ui-icons_2e83ff_256x240.png" />
    <Content Include="Content\themes\base\images\ui-icons_454545_256x240.png" />
    <Content Include="Content\themes\base\images\ui-icons_888888_256x240.png" />
    <Content Include="Content\themes\base\images\ui-icons_cd0a0a_256x240.png" />
    <Content Include="Content\themes\base\jquery-ui.css" />
    <Content Include="Content\themes\base\jquery.ui.accordion.css" />
    <Content Include="Content\themes\base\jquery.ui.all.css" />
    <Content Include="Content\themes\base\jquery.ui.autocomplete.css" />
    <Content Include="Content\themes\base\jquery.ui.base.css" />
    <Content Include="Content\themes\base\jquery.ui.button.css" />
    <Content Include="Content\themes\base\jquery.ui.core.css" />
    <Content Include="Content\themes\base\jquery.ui.datepicker.css" />
    <Content Include="Content\themes\base\jquery.ui.dialog.css" />
    <Content Include="Content\themes\base\jquery.ui.progressbar.css" />
    <Content Include="Content\themes\base\jquery.ui.resizable.css" />
    <Content Include="Content\themes\base\jquery.ui.selectable.css" />
    <Content Include="Content\themes\base\jquery.ui.slider.css" />
    <Content Include="Content\themes\base\jquery.ui.tabs.css" />
    <Content Include="Content\themes\base\jquery.ui.theme.css" />
    <Content Include="Content\themes\base\minified\images\ui-bg_flat_0_aaaaaa_40x100.png" />
    <Content Include="Content\themes\base\minified\images\ui-bg_flat_75_ffffff_40x100.png" />
    <Content Include="Content\themes\base\minified\images\ui-bg_glass_55_fbf9ee_1x400.png" />
    <Content Include="Content\themes\base\minified\images\ui-bg_glass_65_ffffff_1x400.png" />
    <Content Include="Content\themes\base\minified\images\ui-bg_glass_75_dadada_1x400.png" />
    <Content Include="Content\themes\base\minified\images\ui-bg_glass_75_e6e6e6_1x400.png" />
    <Content Include="Content\themes\base\minified\images\ui-bg_glass_95_fef1ec_1x400.png" />
    <Content Include="Content\themes\base\minified\images\ui-bg_highlight-soft_75_cccccc_1x100.png" />
    <Content Include="Content\themes\base\minified\images\ui-icons_222222_256x240.png" />
    <Content Include="Content\themes\base\minified\images\ui-icons_2e83ff_256x240.png" />
    <Content Include="Content\themes\base\minified\images\ui-icons_454545_256x240.png" />
    <Content Include="Content\themes\base\minified\images\ui-icons_888888_256x240.png" />
    <Content Include="Content\themes\base\minified\images\ui-icons_cd0a0a_256x240.png" />
    <Content Include="Content\themes\base\minified\jquery-ui.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.accordion.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.autocomplete.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.button.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.core.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.datepicker.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.dialog.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.progressbar.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.resizable.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.selectable.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.slider.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.tabs.min.css" />
    <Content Include="Content\themes\base\minified\jquery.ui.theme.min.css" />
    <Content Include="Global.asax" />
    <Content Include="Content\Site.css" />
    <None Include="Scripts\jquery-1.8.2.intellisense.js" />
    <Content Include="Scripts\jquery-1.8.2.js" />
    <Content Include="Scripts\jquery-1.8.2.min.js" />
    <None Include="Scripts\jquery.validate-vsdoc.js" />
    <Content Include="Scripts\jquery-ui-1.8.24.js" />
    <Content Include="Scripts\jquery-ui-1.8.24.min.js" />
    <Content Include="Scripts\jquery.unobtrusive-ajax.js" />
    <Content Include="Scripts\jquery.unobtrusive-ajax.min.js" />
    <Content Include="Scripts\jquery.validate.js" />
    <Content Include="Scripts\jquery.validate.min.js" />
    <Content Include="Scripts\jquery.validate.unobtrusive.js" />
    <Content Include="Scripts\jquery.validate.unobtrusive.min.js" />
    <Content Include="Scripts\knockout-2.2.0.debug.js" />
    <Content Include="Scripts\knockout-2.2.0.js" />
    <Content Include="Scripts\modernizr-2.6.2.js" />
    <Content Include="Scripts\_references.js" />
    <Content Include="Web.config" />
    <Content Include="Web.Debug.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include="Web.Release.config">
      <DependentUpon>Web.config</DependentUpon>
    </Content>
    <Content Include="Views\Web.config" />
    <Content Include="Views\_ViewStart.cshtml" />
    <Content Include="Views\Shared\Error.cshtml" />
    <Content Include="Views\Shared\_Layout.cshtml" />
    <Content Include="Views\Home\Index.cshtml" />
  </ItemGroup>
  <ItemGroup>
    <Folder Include="App_Data\" />
    <Folder Include="Models\" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="packages.config" />
  </ItemGroup>
  <PropertyGroup>
    <VisualStudioVersion Condition="'$(VisualStudioVersion)' == ''">10.0</VisualStudioVersion>
    <VSToolsPath Condition="'$(VSToolsPath)' == ''">$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
  </PropertyGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
  <Import Project="$(VSToolsPath)\WebApplications\Microsoft.WebApplication.targets" Condition="'$(VSToolsPath)' != ''" />
  <Import Project="$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v10.0\WebApplications\Microsoft.WebApplication.targets" Condition="false" />
  <Target Name="MvcBuildViews" AfterTargets="AfterBuild" Condition="'$(MvcBuildViews)'=='true'">
    <AspNetCompiler VirtualPath="temp" PhysicalPath="$(WebProjectOutputDir)" />
  </Target>
  <ProjectExtensions>
    <VisualStudio>
      <FlavorProperties GUID="{349c5851-65df-11da-9384-00065b846f21}">
        <WebProjectProperties>
          <UseIIS>True</UseIIS>
          <AutoAssignPort>True</AutoAssignPort>
          <DevelopmentServerPort>49417</DevelopmentServerPort>
          <DevelopmentServerVPath>/</DevelopmentServerVPath>
          <IISUrl>http://localhost:49411/</IISUrl>
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
  </Target> -->
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Web.Debug.config:**
    
```
<?xml version="1.0"?>

<!-- For more information on using Web.config transformation visit http://go.microsoft.com/fwlink/?LinkId=125889 -->

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
      <customErrors> section of your Web.config file.
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

<!-- For more information on using Web.config transformation visit http://go.microsoft.com/fwlink/?LinkId=125889 -->

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
      <customErrors> section of your Web.config file.
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
<?xml version="1.0" encoding="utf-8"?>
<!--
  For more information on how to configure your ASP.NET application, please visit
  http://go.microsoft.com/fwlink/?LinkId=152368
  -->
<configuration>
  <configSections>
    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
    <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=4.4.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
  </configSections>
  <connectionStrings>
    <add name="DefaultConnection" providerName="System.Data.SqlClient" connectionString="Data Source=(LocalDb)\v11.0;Initial Catalog=aspnet-MvcApplication1-20140429195540;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnet-MvcApplication1-20140429195540.mdf" />
  </connectionStrings>
  <appSettings>
    <add key="webpages:Version" value="2.0.0.0" />
    <add key="webpages:Enabled" value="false" />
    <add key="PreserveLoginUrl" value="true" />
    <add key="ClientValidationEnabled" value="true" />
    <add key="UnobtrusiveJavaScriptEnabled" value="true" />
  </appSettings>
  <system.web>
    <compilation debug="true" targetFramework="4.0" />
    <authentication mode="Forms">
      <forms loginUrl="~/Account/Login" timeout="2880" />
    </authentication>
    <pages>
      <namespaces>
        <add namespace="System.Web.Helpers" />
        <add namespace="System.Web.Mvc" />
        <add namespace="System.Web.Mvc.Ajax" />
        <add namespace="System.Web.Mvc.Html" />
        <add namespace="System.Web.Optimization" />
        <add namespace="System.Web.Routing" />
        <add namespace="System.Web.WebPages" />
      </namespaces>
    </pages>
    <profile defaultProvider="DefaultProfileProvider">
      <providers>
        <add name="DefaultProfileProvider" type="System.Web.Providers.DefaultProfileProvider, System.Web.Providers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" connectionStringName="DefaultConnection" applicationName="/" />
      </providers>
    </profile>
    <membership defaultProvider="DefaultMembershipProvider">
      <providers>
        <add name="DefaultMembershipProvider" type="System.Web.Providers.DefaultMembershipProvider, System.Web.Providers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" connectionStringName="DefaultConnection" enablePasswordRetrieval="false" enablePasswordReset="true" requiresQuestionAndAnswer="false" requiresUniqueEmail="false" maxInvalidPasswordAttempts="5" minRequiredPasswordLength="6" minRequiredNonalphanumericCharacters="0" passwordAttemptWindow="10" applicationName="/" />
      </providers>
    </membership>
    <roleManager defaultProvider="DefaultRoleProvider">
      <providers>
        <add name="DefaultRoleProvider" type="System.Web.Providers.DefaultRoleProvider, System.Web.Providers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" connectionStringName="DefaultConnection" applicationName="/" />
      </providers>
    </roleManager>
    <!--
            If you are deploying to a cloud environment that has multiple web server instances,
            you should change session state mode from "InProc" to "Custom". In addition,
            change the connection string named "DefaultConnection" to connect to an instance
            of SQL Server (including SQL Azure and SQL  Compact) instead of to SQL Server Express.
      -->
    <sessionState mode="InProc" customProvider="DefaultSessionProvider">
      <providers>
        <add name="DefaultSessionProvider" type="System.Web.Providers.DefaultSessionStateProvider, System.Web.Providers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" connectionStringName="DefaultConnection" />
      </providers>
    </sessionState>
  </system.web>
  <system.webServer>
    <validation validateIntegratedModeConfiguration="false" />
    <modules runAllManagedModulesForAllRequests="true" />
    <handlers>
      <remove name="ExtensionlessUrlHandler-ISAPI-4.0_32bit" />
      <remove name="ExtensionlessUrlHandler-ISAPI-4.0_64bit" />
      <remove name="ExtensionlessUrlHandler-Integrated-4.0" />
      <add name="ExtensionlessUrlHandler-ISAPI-4.0_32bit" path="*." verb="GET,HEAD,POST,DEBUG,PUT,DELETE,PATCH,OPTIONS" modules="IsapiModule" scriptProcessor="%windir%\Microsoft.NET\Framework\v4.0.30319\aspnet_isapi.dll" preCondition="classicMode,runtimeVersionv4.0,bitness32" responseBufferLimit="0" />
      <add name="ExtensionlessUrlHandler-ISAPI-4.0_64bit" path="*." verb="GET,HEAD,POST,DEBUG,PUT,DELETE,PATCH,OPTIONS" modules="IsapiModule" scriptProcessor="%windir%\Microsoft.NET\Framework64\v4.0.30319\aspnet_isapi.dll" preCondition="classicMode,runtimeVersionv4.0,bitness64" responseBufferLimit="0" />
      <add name="ExtensionlessUrlHandler-Integrated-4.0" path="*." verb="GET,HEAD,POST,DEBUG,PUT,DELETE,PATCH,OPTIONS" type="System.Web.Handlers.TransferRequestHandler" preCondition="integratedMode,runtimeVersionv4.0" />
    </handlers>
  </system.webServer>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="System.Web.Helpers" publicKeyToken="31bf3856ad364e35" />
        <bindingRedirect oldVersion="1.0.0.0-2.0.0.0" newVersion="2.0.0.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Web.Mvc" publicKeyToken="31bf3856ad364e35" />
        <bindingRedirect oldVersion="1.0.0.0-4.0.0.0" newVersion="4.0.0.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Web.WebPages" publicKeyToken="31bf3856ad364e35" />
        <bindingRedirect oldVersion="1.0.0.0-2.0.0.0" newVersion="2.0.0.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="WebGrease" publicKeyToken="31bf3856ad364e35" />
        <bindingRedirect oldVersion="0.0.0.0-1.3.0.0" newVersion="1.3.0.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
  <entityFramework>
    <defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework" />
  </entityFramework>
</configuration>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****packages.config:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="EntityFramework" version="5.0.0" targetFramework="net40" />
  <package id="jQuery" version="1.8.2" targetFramework="net40" />
  <package id="jQuery.UI.Combined" version="1.8.24" targetFramework="net40" />
  <package id="jQuery.Validation" version="1.10.0" targetFramework="net40" />
  <package id="knockoutjs" version="2.2.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.Mvc" version="4.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.Mvc.FixedDisplayModes" version="1.0.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.Providers.Core" version="1.2" targetFramework="net40" />
  <package id="Microsoft.AspNet.Providers.LocalDB" version="1.1" targetFramework="net40" />
  <package id="Microsoft.AspNet.Razor" version="2.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.Web.Optimization" version="1.0.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.WebApi" version="4.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.WebApi.Client" version="4.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.WebApi.Core" version="4.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.WebApi.WebHost" version="4.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.AspNet.WebPages" version="2.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.jQuery.Unobtrusive.Ajax" version="2.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.jQuery.Unobtrusive.Validation" version="2.0.30506.0" targetFramework="net40" />
  <package id="Microsoft.Net.Http" version="2.0.20710.0" targetFramework="net40" />
  <package id="Microsoft.Web.Infrastructure" version="1.0.0.0" targetFramework="net40" />
  <package id="Modernizr" version="2.6.2" targetFramework="net40" />
  <package id="Newtonsoft.Json" version="4.5.11" targetFramework="net40" />
  <package id="WebGrease" version="1.3.0" targetFramework="net40" />
</packages>
```

<!-- code block end -->