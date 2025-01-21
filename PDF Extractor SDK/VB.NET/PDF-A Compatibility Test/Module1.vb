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
Imports Bytescout.PDFExtractor

Namespace PDFATest

    Class Program

        Shared Sub Main(ByVal args As String())

            ' Create Bytescout.PDFExtractor.PDFAValidator instance
            Dim validator As New PDFAValidator()
            validator.RegistrationName = "demo"
            validator.RegistrationKey = "demo"

            ' Load sample PDF document
            validator.LoadDocumentFromFile("sample1.pdf")

            If validator.IsPDFA Then
                Console.WriteLine("This file conforms to the PDF/A standard")
            Else
                Console.WriteLine("This file doesn't conform to the PDF/A standard.")
                Console.WriteLine("Issues:")

                For Each validationError As String In validator.ValidationErrors
                    Console.WriteLine(validationError)
                Next
            End If

            ' Cleanup
            validator.Dispose()

            Console.WriteLine()
            Console.WriteLine("Press any key...")
            Console.ReadKey()

        End Sub

    End Class

End Namespace

