'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
