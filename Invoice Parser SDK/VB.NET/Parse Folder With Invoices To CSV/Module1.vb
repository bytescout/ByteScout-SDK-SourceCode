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


Imports System.Text
Imports ByteScout.InvoiceParser

Module Module1

    Sub Main()

        Dim inputFolder As String = ".\invoices"
        Dim outputFile As String = ".\result.csv"

        ' Create InvoiceParser instance
        Using parser As InvoiceParser = New InvoiceParser("demo", "demo")

            ' Disable fallback to default generic template if document is nor recognized
            parser.FallbackToGenericTemplate = False

            ' Setup CSV output
            Dim csvOptions As CSVOptions = New CSVOptions()
            csvOptions.Encoding = Encoding.UTF8
            csvOptions.SeparatorCharacter = ","
            csvOptions.QuotationCharacter = """"
            csvOptions.UnwrapMultilineValues = True

            ' Parse all document in input folder and save results to CSV file
            BatchProcessing.ParseFolderToCSV(parser, inputFolder, outputFile, csvOptions, AddressOf ProcessingCallback)

        End Using

        ' Open generated CSV file in default associated application (for demo purpose)
        Process.Start(outputFile)

    End Sub

    Sub ProcessingCallback(fileName As String, parsingResult As Boolean, progress As Double, innerException As Exception, ByRef cancel As Boolean)

        Console.WriteLine($"{progress}% Processed file ""{fileName}""")
        Console.WriteLine($"  Result: {parsingResult}")

        If Not parsingResult 

            If innerException IsNot Nothing
                Console.WriteLine(innerException.ToString())
            End If

            Console.Write("Continue processing? (y/n): ")
            Dim key As Integer = Console.Read()
            If key = 110 ' n
                Console.WriteLine("Interrupted.")
                cancel = True
            End If

        End If

    End Sub

End Module
