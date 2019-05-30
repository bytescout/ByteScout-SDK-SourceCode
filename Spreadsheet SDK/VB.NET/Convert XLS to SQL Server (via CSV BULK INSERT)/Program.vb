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


Imports System.IO
Imports Bytescout.Spreadsheet
Imports System.Data.SqlClient

Class Program
    Friend Shared Sub Main(args As String())
        Try
            ' Load XLS document
            Using document As New Spreadsheet()
                document.LoadFromFile("SimpleReport.xls")
                Dim csvFile As String = Path.GetTempPath() & "SimpleReport.csv"

                ' Save the document as CSV file
                document.Workbook.Worksheets(0).SaveAsCSV(csvFile)
                document.Close()

                If File.Exists(csvFile) Then
                    ' MODIFY THE CONNECTION STRING WITH YOUR CREDENTIALS!!!
                    Dim connectionString As String = "Data Source=localhost;Initial Catalog=master;Integrated Security=true;"

                    Using connection As New SqlConnection(connectionString)
                        connection.Open()

                        ' Drop test database if exists
                        ExecuteQueryWithoutResult(connection, "IF DB_ID ('XlsTests') IS NOT NULL DROP DATABASE XlsTests")
                        ' Create empty database
                        ExecuteQueryWithoutResult(connection, "CREATE DATABASE XlsTests")
                        ' Switch to created database
                        ExecuteQueryWithoutResult(connection, "USE XlsTests")
                        ' Create a table for CSV data
                        ExecuteQueryWithoutResult(connection, "CREATE TABLE CsvTest (Name VARCHAR(40), FullName VARCHAR(255))")
                        ' Export CSV data from local file
                        ExecuteQueryWithoutResult(connection, "BULK INSERT CsvTest FROM '" & csvFile & "' WITH ( FIELDTERMINATOR = ';', ROWTERMINATOR = '" & vbLf & "')")

                        ' Check the data successfully exported
                        Using command As New SqlCommand("SELECT * from CsvTest", connection)
                            Dim reader As SqlDataReader = command.ExecuteReader()

                            If reader IsNot Nothing Then
                                Console.WriteLine()
                                Console.WriteLine("Exported CSV data:")
                                Console.WriteLine()

                                While reader.Read()
                                    Console.WriteLine([String].Format("{0}  |  {1}", reader(0), reader(1)))
                                End While
                            End If
                        End Using

                        Console.WriteLine()
                        Console.WriteLine("Press any key.")
                        Console.ReadKey()
                    End Using
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.ReadKey()
        End Try
    End Sub

    Private Shared Sub ExecuteQueryWithoutResult(connection As SqlConnection, query As String)
        Using command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class
