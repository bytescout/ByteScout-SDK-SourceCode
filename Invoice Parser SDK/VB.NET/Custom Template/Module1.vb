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


Imports ByteScout.InvoiceParser

' This example demonstrates invoice data parsing using the custom template.

Module Module1

    Sub Main()

        Dim customTemplate As String = ".\SampleTemplate.yml"
        Dim inputDocument As String = ".\SampleInvoice.pdf"

        ' Create InvoiceParser instance
        Using invoiceParser As New InvoiceParser("demo", "demo")

            Console.WriteLine($"Loading template ""{customTemplate}""...")
            Console.WriteLine()

            invoiceParser.AddTemplateFromFile(customTemplate)

            Console.WriteLine($"Parsing ""{inputDocument}""...")
            Console.WriteLine()

            ' Parse invoice data in JSON format
            Dim jsonString As String = invoiceParser.ParseDocument(inputDocument, OutputFormat.JSON)
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
