## How to generate barcode in VB non visual class with barcode SDK in ASP.NET VB with ByteScout Barcode Suite

### This code in ASP.NET VB shows how to generate barcode in VB non visual class with barcode SDK with this how to tutorial

On this page you will learn from code samples for programming in ASP.NET VB.Writing of the code to generate barcode in VB non visual class with barcode SDK in ASP.NET VB can be executed by programmers of any level using ByteScout Barcode Suite. ByteScout Barcode Suite: the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can generate barcode in VB non visual class with barcode SDK in ASP.NET VB.

Want to save time? You will save a lot of time on writing and testing code as you may just take the ASP.NET VB code from ByteScout Barcode Suite for generate barcode in VB non visual class with barcode SDK below and use it in your application. Just copy and paste the code into your ASP.NET VB application’s code and follow the instructions. Use of ByteScout Barcode Suite in ASP.NET VB is also described in the documentation included along with the product.

ByteScout provides the free trial version of ByteScout Barcode Suite along with the documentation and source code samples.

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

##### ****Default.aspx:**
    
```
<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

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

##### ****Default.aspx.vb:**
    
```
Imports System.Drawing.Imaging

Imports Bytescout.BarCode

Partial Class _Default
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
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.Code39
        ' Set value
        barcode.Value = "Sample"

        ' Clear http output
        Response.Clear()
        ' Set the content type to PNG
        Response.ContentType = "image/png"
        ' Add content type header
        Response.AddHeader("Content-Type", "image/png")
        ' Set the content disposition
        Response.AddHeader("Content-Disposition", "inline;filename=result.png")

        ' Save image to output stream
        barcode.SaveImage(Response.OutputStream, ImageFormat.Png)

        ' End response
        Response.End()
    End Sub
End Class

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
	<connectionStrings/>
	<system.web>
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
		<compilation debug="false" strict="false" explicit="true">
			<assemblies>
				<add assembly="System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=B77A5C561934E089"/>
				<add assembly="System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=B03F5F7F11D50A3A"/></assemblies></compilation>
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
</configuration>

```

<!-- code block end -->