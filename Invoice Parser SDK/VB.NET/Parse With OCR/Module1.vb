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


Imports ByteScout.InvoiceParser

' This example demonstrates the use of Optical Character Recognition (OCR) to parse invoice data 
' from scanned PDF documents and raster images.

Module Module1

    Sub Main()

        Dim inputDocument1 As String = ".\DigitalOcean-scanned.jpg"

        ' Create InvoiceParser instance
        Using invoiceParser As New InvoiceParser("demo", "demo")

            ' Enable Optical Character Recognition (OCR)
            ' in .Auto mode (SDK automatically checks if needs to use OCR or not)
            invoiceParser.OCRMode = OCRMode.Auto
            
            ' Set the location of OCR language data files
            invoiceParser.OCRLanguageDataFolder = "c:\Program Files\ByteScout Invoice Parser SDK\ocrdata"

            ' Set OCR language
            ' "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
            invoiceParser.OCRLanguage = "eng"
            ' Find more language files at https://github.com/bytescout/ocrdata

            Console.WriteLine($"Parsing ""{inputDocument1}""...")
            Console.WriteLine()

            ' Parse invoice data in JSON format
            Dim jsonString As String = invoiceParser.ParseDocument(inputDocument1, OutputFormat.JSON)
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
