'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.Spreadsheet
Imports System.IO

Module Module1

    Sub Main()
        Dim document As New Spreadsheet()

        ' Input file url
        Dim cUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/csv-to-pdf/sample.csv"

        ' Input stream
        Dim inpStream As Stream = GetStreamFromUrl(cUrl)

        ' load csv file from stream
        document.LoadFromStream(inpStream)

        ' Save document
        document.SaveAs("Output.xls")

        ' Close Spreadsheet
        document.Close()

        ' open in default spreadsheets viewer/editor
        Process.Start("Output.xls")

    End Sub

    ''' <summary>
    ''' Get stream from Url
    ''' </summary>
    Private Function GetStreamFromUrl(ByVal url As String) As Stream

        Dim oData As Byte() = Nothing

        Using wc As New System.Net.WebClient()
            oData = wc.DownloadData(url)
        End Using

        Return New MemoryStream(oData)

    End Function


End Module
