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


Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports Bytescout.PDFExtractor

Namespace ConsoleApplication1

    Class Program

        Shared Sub Main(ByVal args As String())

            Dim inputDocument As String = Path.GetFullPath(".\UnicodeSample.pdf")
            Dim csvFilePath As String = Path.ChangeExtension(inputDocument, ".csv")
            Dim csvFileName As String = Path.GetFileName(csvFilePath)
            Dim csvDirectory As String = Path.GetDirectoryName(Path.GetFullPath(csvFilePath))

            ' Create Bytescout.PDFExtractor.CSVExtractor instance
            Using extractor As CSVExtractor = New CSVExtractor("demo", "demo")

                extractor.LoadDocumentFromFile(inputDocument)

                extractor.CSVSeparatorSymbol = ","

                Dim csvText As String = extractor.GetCSV()

                ' Save csv text in UTF-8 encoding without BOM (byte order mark):
                File.WriteAllText(csvFilePath, csvText)

            End Using

            ' Please Note: Target the project to x86 because Microsoft.Jet.OLEDB.4.0 driver is 32-bit only.
            Using connection As OleDbConnection = New OleDbConnection($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""{csvDirectory}"";Extended Properties=""Text;FMT=$;HDR=No;CharacterSet=65001""")

                Using command As OleDbCommand = New OleDbCommand($"select * from [{csvFileName}]", connection)

                    Using adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
                        Dim table As DataTable = New DataTable()
                        table.Locale = CultureInfo.CurrentCulture
                        adapter.Fill(table)
                        Console.WriteLine($"Loaded {table.Rows.Count} lines.")
                    End Using

                End Using

            End Using

            Console.ReadKey()

        End Sub

    End Class
End Namespace

