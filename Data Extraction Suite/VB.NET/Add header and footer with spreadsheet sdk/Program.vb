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


Imports System.Diagnostics
Imports System.IO
Imports Bytescout.Spreadsheet

Class Program
    Friend Shared Sub Main(ByVal args As String())

        ' Create new Spreadsheet object
        Dim doc As New Spreadsheet()

        ' Add worksheet
        Dim worksheet As Worksheet = doc.Worksheets.Add()

        ' Add headers:

        ' add date as left header
        worksheet.PageSetup.LeftHeader = "&D"
        ' add label with custom font as center header
        worksheet.PageSetup.CenterHeader = "&""Verdana,bold""&14Laws && Rights"
        ' add time as right header
        worksheet.PageSetup.RightHeader = "&T"

        ' Add footers:

        ' add file name as left footer
        worksheet.PageSetup.LeftFooter = "&F"
        ' add "page of pages" indicator as center footer
        worksheet.PageSetup.CenterFooter = "&P/&N"
        ' add simple text as right footer
        worksheet.PageSetup.RightFooter = "Right footer"

        ' Add worksheet content
        worksheet.Cell(1, 1).Value = "Click Print Preview to see headers and footers."
        
        ' Delete output file if exists
        If File.Exists("output.xls") Then
            File.Delete("output.xls")
        End If

        ' Save document
        doc.SaveAs("output.xls")

        ' Close spreadsheet
        doc.Close()
        doc.Dispose()

        ' Open generated XLS document in default application
        Process.Start("output.xls")

    End Sub
End Class
