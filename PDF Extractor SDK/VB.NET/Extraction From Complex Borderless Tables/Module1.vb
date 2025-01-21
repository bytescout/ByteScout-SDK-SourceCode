'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Namespace ConsoleApplication1

    Class Program

        Shared Sub Main(ByVal args As String())

            ' Create Bytescout.PDFExtractor.CSVExtractor instance
            Dim extractor As New CSVExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("borderless_table.pdf")

            ' Set extraction columns explicitly.
            ' Coordinates in CustomExtractionColumns must match the left edges of the columns.
            ' To get coordinates in PDF points you can use PDF Multitool application 
            ' installed with the SDK. It shows mouse cursor coodinates in PDF points in the toolbar.
            extractor.CustomExtractionColumns = New Double() {0, 124.5, 185, 241}

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
            Process.Start("output.csv")

        End Sub
        
    End Class
End Namespace

