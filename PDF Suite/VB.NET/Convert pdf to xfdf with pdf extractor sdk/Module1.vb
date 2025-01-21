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

            ' Create Bytescout.PDFExtractor.XFDFExtractor instance
            Dim extractor As New XFDFExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load PDF document
            ' (!) We do not provide the sample document, please load your own.
            extractor.LoadDocumentFromFile("xfdf-form.pdf")

            extractor.SaveXFDFToFile("output.xml")

            ' Cleanup
		    extractor.Dispose()

            Console.WriteLine()
            Console.WriteLine("Extracted data saved to 'output.xml' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key...")
            Console.ReadKey()

        End Sub

    End Class
    
End Namespace

