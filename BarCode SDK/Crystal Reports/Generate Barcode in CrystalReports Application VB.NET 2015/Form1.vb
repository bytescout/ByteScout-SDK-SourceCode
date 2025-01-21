'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Data.OleDb
Imports Bytescout.BarCode

Public Class Form1

    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=products.mdb")
        Dim dataAdapter As New OleDbDataAdapter("SELECT ID, ProductName, ProductDescription, ProductPrice FROM Products", connection)

        ' fill dataset
        Dim dataSet As New DataSet()
        dataAdapter.Fill(dataSet)

        connection.Close()

        'add virtual column into the result table
        dataSet.Tables(0).Columns.Add(New DataColumn("BarcodeImage", GetType(System.Byte())))

        ' create barcode object
        Dim barcode As New Barcode(SymbologyType.Code128)
        barcode.DrawCaption = False

        ' Fill BarcodeImage column with generated barcode image bytes
        For Each row As DataRow In dataSet.Tables(0).Rows

            'set barcode value
            barcode.Value = Convert.ToString(row("ID"))

            ' retrieve generated image bytes
            Dim barcodeBytes As Byte() = barcode.GetImageBytesWMF()

            ' fill virtual column with generated image bytes
            row("BarcodeImage") = barcodeBytes

        Next

        ' set filled DataSet as report's data source
        CrystalReport11.SetDataSource(dataSet.Tables(0))

    End Sub
End Class
