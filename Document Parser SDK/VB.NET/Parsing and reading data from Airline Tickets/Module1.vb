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

        Dim templatesDocument As String = ".\SampleTicket.yml"
        Dim inputDocument As String = ".\SampleTicket.pdf"

        ' Create DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Loading template
            documentParser.AddTemplate(templatesDocument)

            ' Parse document data in JSON format
            Dim jsonString As String = documentParser.ParseDocument(inputDocument, OutputFormat.JSON)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in JSON format:")
            Console.WriteLine()
            Console.WriteLine(jsonString)

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "==================" + Environment.NewLine + Environment.NewLine)

            ' Parse document data in YAML format
            Dim yamlString As String = documentParser.ParseDocument(inputDocument, OutputFormat.YAML)
            ' Display parsed data in console
            Console.WriteLine("Parsing results in YAML format:")
            Console.WriteLine()
            Console.WriteLine(yamlString)

            Console.WriteLine(Environment.NewLine + Environment.NewLine + "==================" + Environment.NewLine + Environment.NewLine)

            ' Parse document data in YAML format
            Dim xmlString As String = documentParser.ParseDocument(inputDocument, OutputFormat.XML)
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
