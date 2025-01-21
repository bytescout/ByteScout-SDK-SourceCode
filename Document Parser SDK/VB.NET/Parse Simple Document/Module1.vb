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

' This example demonstrates document data parsing to JSON, YAML and XML formats.

Module Module1

    Sub Main()

        Dim templates As String() = New String() {"DigitalOcean.yml", "AmazonAWS.yml", "Google.yml"}

        Dim inputDocument1 As String = ".\DigitalOcean.pdf"
        Dim inputDocument2 As String = ".\AmazonAWS.pdf"
        Dim inputDocument3 As String = ".\Google.pdf"

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            Console.WriteLine("Loading templates...")

            For Each template In templates
                documentParser.AddTemplate(template)
            Next

            Console.WriteLine("Templates loaded.")
            Console.WriteLine()


            Console.WriteLine($"Parsing ""{inputDocument1}""...")
            Console.WriteLine()

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(inputDocument1, OutputFormat.JSON)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in JSON format:")
            Console.WriteLine()
            Console.WriteLine(jsonString)

            Console.WriteLine()
            Console.WriteLine($"Parsing ""{inputDocument2}""...")
            Console.WriteLine()

            ' Parse document data in YAML format
            Dim yamlString As String = documentParser.ParseDocument(inputDocument2, OutputFormat.YAML)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in YAML format:")
            Console.WriteLine()
            Console.WriteLine(yamlString)


            Console.WriteLine()
            Console.WriteLine($"Parsing ""{inputDocument3}""...")
            Console.WriteLine()

            ' Parse document data in CSV format
            Dim csvOptions = New CSVOptions()
            csvOptions.GenerateColumnHeaders = True
            csvOptions.SeparatorCharacter = ","
            csvOptions.QuotationCharacter = """"
            csvOptions.EncodingName = "utf-8"
            Dim xmlString As String = documentParser.ParseDocument(inputDocument3, OutputFormat.CSV, csvOptions)
            
            ' Display parsed data in console
            Console.WriteLine("Parsing results in XML format:")
            Console.WriteLine()
            Console.WriteLine(xmlString)

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

End Module
