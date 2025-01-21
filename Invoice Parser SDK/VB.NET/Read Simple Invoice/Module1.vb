'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports ByteScout.InvoiceParser

' This example demonstrates invoice data parsing to JSON and YAML formats.

Module Module1

    Sub Main()

        Dim inputDocument1 As String = ".\DigitalOcean.pdf"
        Dim inputDocument2 As String = ".\AmazonAWS.pdf"

        ' Create InvoiceParser instance
        Using invoiceParser As New InvoiceParser("demo", "demo")

            Console.WriteLine($"Parsing ""{inputDocument1}""...")
            Console.WriteLine()

            ' Parse invoice data in JSON format
            Dim jsonString As String = invoiceParser.ParseDocument(inputDocument1, OutputFormat.JSON)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in JSON format:")
            Console.WriteLine()
            Console.WriteLine(jsonString)

            Console.WriteLine()
            Console.WriteLine($"Parsing ""{inputDocument2}""...")
            Console.WriteLine()

            ' Parse invoice data in YAML format
            Dim yamlString As String = invoiceParser.ParseDocument(inputDocument2, OutputFormat.YAML)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in YAML format:")
            Console.WriteLine()
            Console.WriteLine(yamlString)

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

End Module
