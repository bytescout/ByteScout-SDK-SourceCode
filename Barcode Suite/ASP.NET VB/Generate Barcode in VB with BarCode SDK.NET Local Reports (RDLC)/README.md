## How to generate barcode in VB with barcode SDK in ASP.NET VB using ByteScout Barcode Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to generate barcode in VB with barcode SDK in ASP.NET VB

Every ByteScout tool includes simple example ASP.NET VB source codes that you can get here or in the folder with installed ByteScout product. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK. It can be applied to generate barcode in VB with barcode SDK using ASP.NET VB.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for ASP.NET VB plus the guidelines and the code below will help you quickly learn how to generate barcode in VB with barcode SDK. This ASP.NET VB sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample ASP.NET VB codes.

You can download free trial version of ByteScout Barcode Suite from our website to see and try many others source code samples for ASP.NET VB.

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