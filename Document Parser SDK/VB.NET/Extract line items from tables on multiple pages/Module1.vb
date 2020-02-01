'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports ByteScout.DocumentParser

' This example demonstrates extracting line items from tables on multiple pages with two different approaches.
' See comments in the code of templates.

Module Module1

    Sub Main()

        Dim inputDocument As String = ".\MultiPageTable.pdf"
        Dim template1 As String = ".\MultiPageTable-template1.yml"
        Dim template2 As String = ".\MultiPageTable-template2.yml"

        ' Process using template-1
        Using documentParser As New DocumentParser("demo", "demo")

            Console.WriteLine("Loading template 1...")
            documentParser.AddTemplate(template1)

            Console.WriteLine("Template 1 loaded.")
            Console.WriteLine()

            Console.WriteLine($"Parsing ""{inputDocument}""...")
            Console.WriteLine()

            ' Parse document data in JSON format
            documentParser.ParseDocument(inputDocument, "result1.json", OutputFormat.JSON)
            
            Console.WriteLine("Parsing results saved to `result1.json`.")
            Console.WriteLine()

        End Using

        ' Process using template-2
        Using documentParser As New DocumentParser("demo", "demo")

            Console.WriteLine("Loading template 2...")
            documentParser.AddTemplate(template2)

            Console.WriteLine("Template 2 loaded.")
            Console.WriteLine()

            Console.WriteLine($"Parsing ""{inputDocument}""...")
            Console.WriteLine()

            ' Parse document data in JSON format
            documentParser.ParseDocument(inputDocument, "result2.json", OutputFormat.JSON)
            
            Console.WriteLine("Parsing results saved to `result2.json`.")
            Console.WriteLine()

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

End Module
