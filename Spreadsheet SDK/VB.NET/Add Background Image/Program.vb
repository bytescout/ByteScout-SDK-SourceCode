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
