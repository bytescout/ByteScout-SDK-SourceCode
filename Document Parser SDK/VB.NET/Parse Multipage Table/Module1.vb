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

' This example demonstrates parsing of multipage tables in two different approaches.
' See comments in the code of templates.

Module Module1

    Sub Main()

        Dim inputDocument As String = ".\MultiPageTable.pdf"
        Dim template1 As String = ".\MultiPageTable-template1.yml"
        Dim template2 As String = ".\MultiPageTable-template2.yml"

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
