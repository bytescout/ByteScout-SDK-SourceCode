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
Imports System.Data.SqlClient

Class Program
    Friend Shared Sub Main(args As String())
        Try
            ' MODIFY THE CONNECTION STRING WITH YOUR CREDENTIALS!!!
            Dim connectionString As String = "Data Source=localhost;Initial Catalog=master;Integrated Security=true;"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Drop test database if exists
                ExecuteQueryWithoutResult(connection, "IF DB_ID ('CsvTests') IS NOT NULL DROP DATABASE CsvTests")
                ' Create empty database
                ExecuteQueryWithoutResult(connection, "CREATE DATABASE CsvTests")
                ' Switch to created database
                ExecuteQueryWithoutResult(connection, "USE CsvTests")
                ' Create a table for CSV data
                ExecuteQueryWithoutResult(connection, "CREATE TABLE CsvTest (Name VARCHAR(40), FullName VARCHAR(255))")

                ' Load CSV document
                Using document As New Spreadsheet()
                    document.LoadFromFile("sample.csv", ";") ' ";" - delimiter
                    Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

                    For row As Integer = 0 To worksheet.UsedRangeRowMax
                        Dim insertCommand As [String] = String.Format("INSERT CsvTest VALUES('{0}','{1}')",
                                                                      worksheet.Cell(row, 0).Value,
                                                                      worksheet.Cell(row, 1).Value)
                        ExecuteQueryWithoutResult(connection, insertCommand)
                    Next
                End Using

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
