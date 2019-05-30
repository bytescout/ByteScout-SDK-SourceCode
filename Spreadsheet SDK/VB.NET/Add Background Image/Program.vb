'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports Bytescout.Spreadsheet

Class Program
    
    Friend Shared Sub Main(args As String())

        ' Create new spreadsheet (or open existing)
        Dim doc As New Spreadsheet()
        doc.RegistrationName = "demo"
        doc.RegistrationKey = "demo"

        ' Add worksheet
        Dim worksheet As Worksheet = doc.Worksheets.Add()

        ' Put background image on the worksheet
        worksheet.BackgroundPicture = Image.FromFile("image1.jpg")

        ' Save document
        doc.SaveAs("output.xls")

        ' Close spreadsheet
        doc.Close()

        ' Open generated XLS document in default application
        Process.Start("output.xls")

        doc.Dispose()

    End Sub
    
End Class
