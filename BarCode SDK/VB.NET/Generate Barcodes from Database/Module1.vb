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


Imports Bytescout.BarCode
Imports System.Data.OleDb

Module Module1

    Sub Main()

        Dim barcode As Barcode = New Barcode()

        barcode.Symbology = SymbologyType.QRCode

        Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=demodb.mdb;User Id=admin;Password=;")
        connection.Open()

        Dim command As OleDbCommand = connection.CreateCommand()
        command.CommandText = "SELECT title FROM Books"

        Dim dataReader As OleDbDataReader = command.ExecuteReader()

        Dim i As Integer

        While dataReader.Read()
            barcode.Value = dataReader.GetString(0)
            barcode.SaveImage(i & ".png")
            i = i + 1
        End While

        dataReader.Dispose()
        connection.Dispose()
        barcode.Dispose()

    End Sub

End Module
