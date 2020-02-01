'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


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
