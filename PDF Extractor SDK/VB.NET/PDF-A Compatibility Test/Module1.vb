'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


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
            
            validator.Dispose()

            Console.WriteLine()
            Console.WriteLine("Press any key...")
            Console.ReadKey()

        End Sub

    End Class

End Namespace

