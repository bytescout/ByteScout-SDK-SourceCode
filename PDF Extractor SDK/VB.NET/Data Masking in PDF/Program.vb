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
Imports System.Text.RegularExpressions
Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try

            ' Generate CSVExtractor instance
            Using extractor As New CSVExtractor("demo", "demo")

                ' Load PDF document
                extractor.LoadDocumentFromFile("sample.pdf")

                ' Get all data
                Dim allData = extractor.GetCSV()

                ' Regular expressions and replacements
                Dim ssnRegex = "\d{3}[-]?\d{2}[-]?\d{4}"
                Dim ssnReplace = "***-**-****"

                Dim phoneRegex = "\d{3}[-]?\d{3}[-]?\d{4}"
                Dim phoneReplace = "***-***-****"

                ' Find and mask SSN and phone numbers
                allData = Regex.Replace(allData, ssnRegex, ssnReplace)
                allData = Regex.Replace(allData, phoneRegex, phoneReplace)

                ' Write as CSV
                File.WriteAllText("output.csv", allData)

                ' Open file
                Process.Start("output.csv")

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

End Module
