'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports ByteScout.DocumentParser

' This example demonstrates data parsing from an invoice using the custom template.

Module Module1

    Sub Main()

        Dim customTemplate As String = ".\SampleTemplate.yml"
        Dim inputDocument As String = ".\SampleInvoice.pdf"

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            Console.WriteLine($"Loading template ""{customTemplate}""...")
            Console.WriteLine()

            documentParser.AddTemplate(customTemplate)

            Console.WriteLine($"Parsing ""{inputDocument}""...")
            Console.WriteLine()

            ' Parse invoice data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(inputDocument, OutputFormat.JSON)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in JSON format:")
            Console.WriteLine()
            Console.WriteLine(jsonString)
            
        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

End Module
