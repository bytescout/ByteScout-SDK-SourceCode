'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
