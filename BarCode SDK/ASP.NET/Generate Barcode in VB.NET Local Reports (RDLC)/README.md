## How to generate barcode in VB in ASP.NET using ByteScout Barcode SDK

### This code in ASP.NET shows how to generate barcode in VB with this how to tutorial

The sample source code below will teach you how to generate barcode in VB in ASP.NET. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images and you can use it to generate barcode in VB with ASP.NET.

ASP.NET code samples for ASP.NET developers help to speed up coding of your application when using ByteScout Barcode SDK. In your ASP.NET project or application you may simply copy & paste the code and then run your app! Test ASP.NET sample code examples whether they respond your needs and requirements for the project.

Trial version of ByteScout Barcode SDK can be downloaded for free from our website. It also includes source code samples for ASP.NET and other programming languages.

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
<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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

    Protected Sub form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles form1.Load

        ' Fill the datasource from DB
        Dim ta As New AdventureWorksTableAdapters.vProductAndDescriptionTableAdapter()
        Dim dt As New AdventureWorks.vProductAndDescriptionDataTable()
        ta.Fill(dt)

        ' Create and setup an instance of Bytescout Barcode SDK
        Dim bc As New Barcode(SymbologyType.Code128)
        bc.RegistrationName = "demo"
        bc.RegistrationKey = "demo"
        bc.DrawCaption = False


        ' Update DataTable with barcode image
        Dim row As AdventureWorks.vProductAndDescriptionRow

        For Each row In dt.Rows
            ' Set the value to encode
            bc.Value = row.ProductID.ToString()
            'Generate the barcode image and store it into the Barcode Column
            row.Barcode = bc.GetImageBytesPNG()
        Next

        'Create Report Data Source
        Dim rptDataSource As New Microsoft.Reporting.WebForms.ReportDataSource("AdventureWorks_vProductAndDescription", dt)
        Me.ReportViewer1.LocalReport.DataSources.Add(rptDataSource)
        Me.ReportViewer1.LocalReport.ReportPath = Server.MapPath("BarcodeReport.rdlc")
        Me.ReportViewer1.LocalReport.Refresh()
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
    <connectionStrings>
        <add name="AdventureWorksConnectionString" connectionString="Data Source=STARKOV\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=True"
            providerName="System.Data.SqlClient" />
    </connectionStrings>
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

        </compilation>
        <pages>
          <namespaces>
            <clear />
            <add namespace="System" />
            <add namespace="System.Collections" />
            <add namespace="System.Collections.Generic" />
            <add namespace="System.Collections.Specialized" />
            <add namespace="System.Configuration" />
            <add namespace="System.Text" />
            <add namespace="System.Text.RegularExpressions" />
            <add namespace="System.Web" />
            <add namespace="System.Web.Caching" />
            <add namespace="System.Web.SessionState" />
            <add namespace="System.Web.Security" />
            <add namespace="System.Web.Profile" />
            <add namespace="System.Web.UI" />
            <add namespace="System.Web.UI.WebControls" />
            <add namespace="System.Web.UI.WebControls.WebParts" />
            <add namespace="System.Web.UI.HtmlControls" />
          </namespaces>

        </pages>
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