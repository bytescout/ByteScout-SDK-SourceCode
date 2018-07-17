'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
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
