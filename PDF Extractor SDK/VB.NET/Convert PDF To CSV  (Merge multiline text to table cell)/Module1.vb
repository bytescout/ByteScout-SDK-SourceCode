'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Namespace ConsoleApplication1

    Class Program

        Shared Sub Main(ByVal args As String())

            ' Create Bytescout.PDFExtractor.CSVExtractor instance
            Dim extractor As New CSVExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample3_multiline.pdf")

            ' You can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales
            'extractor.CSVSeparatorSymbol = "," 

            ' For multiline cell join extracted cell text into single line
            extractor.LineGroupingMode = LineGroupingMode.GroupByRows
            extractor.Unwrap = True

            ' Save extracted CSV data to file
            extractor.SaveCSVToFile("output.csv")

            ' Cleanup
		    extractor.Dispose()

            Console.WriteLine()
            Console.WriteLine("Data has been extracted to 'output.csv' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue and open CSV in default CSV viewer (or Excel)...")
            Console.ReadKey()

            ' Open result file in default associated application (for demo purposes)
            Dim processStartInfo As New ProcessStartInfo("output.csv")
            processStartInfo.UseShellExecute = True
            Process.Start(processStartInfo)

        End Sub
        
    End Class
End Namespace

