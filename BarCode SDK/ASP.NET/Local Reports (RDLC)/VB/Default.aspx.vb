'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports Bytescout.BarCode

Partial Class _Default
    Inherits System.Web.UI.Page

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
