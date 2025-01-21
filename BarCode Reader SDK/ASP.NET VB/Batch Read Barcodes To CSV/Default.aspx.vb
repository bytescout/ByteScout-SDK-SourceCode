'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.BarCodeReader

Partial Public Class _Default
    Inherits Page

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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnImagePDFBarcodeToCSV_Click(sender As Object, e As EventArgs) Handles btnImagePDFBarcodeToCSV.Click

        ' Read Barcode Process
        Dim reader As Reader = New Reader()
        reader.RegistrationKey = "demo"
        reader.RegistrationName = "demo"

        ' Set Barcode type to find
        reader.BarcodeTypesToFind.All = True

        ' Output list
        Dim lstCSVOutput As List(Of CSVOutputFormat) = New List(Of CSVOutputFormat)()

        Dim files = System.IO.Directory.GetFiles(Request.MapPath("~/BarcodeFiles"))

        ' Get all files in folder, And iterate through each file
        For Each fileName As String In files

            ' Read barcodes
            Dim barcodes As FoundBarcode() = reader.ReadFrom(fileName)

            For Each code As FoundBarcode In barcodes
                lstCSVOutput.Add(New CSVOutputFormat With {
                    .barcodeValue = code.Value,
                    .barcodeType = code.Type.ToString(),
                    .scanDateTime = DateTime.Now.ToString(),
                    .fileName = fileName
                })
            Next

        Next

        ' Set info text
        lblInfo.Text = String.Format("Total {0} barcode found in {1} file.", lstCSVOutput.Count, files.Length)

        ' Export to CSV
        ExportToCsv(lstCSVOutput, Response)

    End Sub

    ''' <summary>
    ''' Exports to CSV
    ''' </summary>
    Private Shared Sub ExportToCsv(ByVal lstCSVOutput As List(Of CSVOutputFormat), ByVal response As HttpResponse)

        Dim csvOutputContent As System.Text.StringBuilder = New System.Text.StringBuilder(String.Empty)

        csvOutputContent.Append("Barcode Value,Barcode Type,Scan DateTime,File Name")

        For Each item As CSVOutputFormat In lstCSVOutput
            csvOutputContent.AppendFormat(vbCrLf & "{0},{1},{2},{3}", item.barcodeValue, item.barcodeType, item.scanDateTime, item.fileName)
        Next

        ' Perform download of file
        response.Clear()
        response.ClearHeaders()

        response.AppendHeader("Content-Length", csvOutputContent.Length.ToString())
        response.ContentType = "text/csv"
        response.AppendHeader("Content-Disposition", "attachment;filename=""output.csv""")

        response.Write(csvOutputContent.ToString())
        response.End()

    End Sub

End Class

Class CSVOutputFormat
    Public Property barcodeValue As String
    Public Property barcodeType As String
    Public Property scanDateTime As String
    Public Property fileName As String
End Class
