'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports ByteScout.DocumentParser

' This example demonstrates document data parsing to JSON, YAML and XML formats.

Module Module1

    Sub Main()

        Dim templatesDocument As String = ".\Templates\SampleTicket.yml"
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
