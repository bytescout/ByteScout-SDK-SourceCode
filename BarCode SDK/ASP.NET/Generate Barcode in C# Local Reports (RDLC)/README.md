## How to generate barcode in c# local reports (rdlc) in ASP.NET with ByteScout Barcode SDK

### This tutorial will show how to generate barcode in c# local reports (rdlc) in ASP.NET

On this page you will learn from code samples for programming in ASP.NET.Writing of the code to generate barcode in c# local reports (rdlc) in ASP.NET can be done by developers of any level using ByteScout Barcode SDK. What is ByteScout Barcode SDK? It is the robost SDK that generates high quality barcode images and pdf. Can generate all popular types of barcodes from QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix to more exotic barcode types. Fully customizable fonts, colors, print sizes. Includes special functions to ensure output quality, and tools for adding barcodes to new or existing pdf files and images. It can help you to generate barcode in c# local reports (rdlc) in your ASP.NET application.

Fast application programming interfaces of ByteScout Barcode SDK for ASP.NET plus the instruction and the code below will help you quickly learn how to generate barcode in c# local reports (rdlc). In order to implement the functionality, you should copy and paste this code for ASP.NET below into your code editor with your app, compile and run your application. Code testing will allow the function to be tested and work properly with your data.

Download free trial version of ByteScout Barcode SDK from our website with this and other source code samples for ASP.NET.

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
<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="804px">
		</rsweb:ReportViewer>
    
    </div>
    </form>
</body>
</html>

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Default.aspx.cs:**
    
```
using System;

using Bytescout.BarCode;
using Microsoft.Reporting.WebForms;

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
		// Fill the datasource from DB
		AdventureWorksTableAdapters.vProductAndDescriptionTableAdapter ta = 
			new AdventureWorksTableAdapters.vProductAndDescriptionTableAdapter();
		AdventureWorks.vProductAndDescriptionDataTable dt = 
			new AdventureWorks.vProductAndDescriptionDataTable();
		ta.Fill(dt);

		Barcode bc = new Barcode(SymbologyType.Code128);
		bc.RegistrationName = "demo";
		bc.RegistrationKey = "demo";
    	bc.DrawCaption = false;

		// Update DataTable with barcode image
		foreach (AdventureWorks.vProductAndDescriptionRow row in dt.Rows)
		{
			// Set the value to encode
			bc.Value = row.ProductID.ToString();
			// Generate the barcode image and store it into the Barcode Column
			row.Barcode = bc.GetImageBytesPNG();
		}

		// Create Report Data Source
		Microsoft.Reporting.WebForms.ReportDataSource rptDataSource = 
			new ReportDataSource("AdventureWorks_vProductAndDescription", dt);

		ReportViewer1.LocalReport.DataSources.Add(rptDataSource);
		ReportViewer1.LocalReport.ReportPath = Server.MapPath("BarcodeReport.rdlc");
		ReportViewer1.LocalReport.Refresh();
    }
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****web.config:**
    
```
<?xml version="1.0"?>
<!-- 
    Note: As an alternative to hand editing this file you can use the 
    web admin tool to configure settings for your application. Use
    the Website->Asp.Net Configuration option in Visual Studio.
    A full list of settings and comments can be found in 
    machine.config.comments usually located in 
    \Windows\Microsoft.Net\Framework\v2.x\Config 
-->
<configuration>
	<appSettings/>
	<connectionStrings>
		<add name="AdventureWorksConnectionString" connectionString="Data Source=STARKOV\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=True" providerName="System.Data.SqlClient"/>
	</connectionStrings>
	<system.web>
		<!-- 
            Set compilation debug="true" to insert debugging 
            symbols into the compiled page. Because this 
            affects performance, set this value to true only 
            during development.
        -->
		<httpHandlers>
   <add path="Reserved.ReportViewerWebControl.axd" verb="*" type="Microsoft.Reporting.WebForms.HttpHandler, Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    validate="false" />
  </httpHandlers>
  <compilation debug="true">
   <assemblies>
    <add assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=B03F5F7F11D50A3A" />
    <add assembly="Microsoft.ReportViewer.Common, Version=9.0.0.0, Culture=neutral, PublicKeyToken=B03F5F7F11D50A3A" />
   </assemblies>
   <buildProviders>
    <add extension=".rdlc" type="Microsoft.Reporting.RdlBuildProvider, Microsoft.ReportViewer.Common, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />
   </buildProviders>
  </compilation>
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
</configuration>

```

<!-- code block end -->