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


Imports System.IO
Imports System.Text
Imports Bytescout.Spreadsheet

Module Module1

    Sub Main()

        ' Spreadsheet document
        Using document As New Spreadsheet()

            ' Load Input File
            document.LoadFromFile("SimpleReport.xls")

            ' Create stream and export CSV data to stream
            Dim ms As New MemoryStream()
            document.Worksheet(0).SaveAsCSV(ms, vbTab)

            ' Convert memory stream to string
            Dim tabSeparatedData = Encoding.UTF8.GetString(ms.ToArray())

            ' Copy data to clipboard
            System.Windows.Forms.Clipboard.SetText(tabSeparatedData)

        End Using

        Console.WriteLine("Data copied to clipboard")
        Console.ReadLine()

    End Sub

End Module
