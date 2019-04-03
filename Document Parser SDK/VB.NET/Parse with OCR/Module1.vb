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

' This example demonstrates parsing of scanned documents
' using the Optical Character Recognition (OCR).

Module Module1

    Sub Main()

        Dim template As String = ".\DigitalOcean.yml"
        Dim inputDocument As String = ".\DigitalOcean-scanned.jpg"

        ' Create and activate DocumentParser instance
        Using documentParser As New DocumentParser("demo", "demo")

            ' Enable Optical Character Recognition (OCR) in Auto mode
            ' (DocumentParser automatically detects if OCR Is required).
            documentParser.OCRMode = OCRMode.Auto

            ' Set PDF document rendering resolution
            documentParser.OCRResolution = 300

            ' Set the location of OCR language data files
            documentParser.OCRLanguageDataFolder = "c:\Program Files\ByteScout Document Parser SDK\ocrdata"

            ' Set OCR language
            ' "eng" for english, "deu" for German, "fra" for French, etc. - according to files in "ocrdata" folder
            documentParser.OCRLanguage = "eng"
            ' Find more language files at https://github.com/bytescout/ocrdata

            ' Note: The OCRLanguage can be overridden in a template. 
            ' See the Template Creation Guide.


            ' You can also apply various preprocessing filters
            ' to improve the recognition on low-quality scans.

            ' Automatically deskew skewed scans
            'documentParser.OCRImagePreprocessingFilters.AddDeskew()

            ' Remove vertical or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
            'documentParser.OCRImagePreprocessingFilters.AddVerticalLinesRemover()
            'documentParser.OCRImagePreprocessingFilters.AddHorizontalLinesRemover()

            ' Repair broken letters
            'documentParser.OCRImagePreprocessingFilters.AddDilate()

            ' Remove noise
            'documentParser.OCRImagePreprocessingFilters.AddMedian()

            ' Apply Gamma Correction
            'documentParser.OCRImagePreprocessingFilters.AddGammaCorrection(1.4)

            ' Add Contrast
            'documentParser.OCRImagePreprocessingFilters.AddContrast(20)

            ' Load template
            documentParser.AddTemplate(template)
                
            Console.WriteLine("Template loaded.")
            Console.WriteLine()

            Console.WriteLine($"Parsing ""{inputDocument}"" with OCR...")
            Console.WriteLine()


            ' Parse document data to JSON format
            Dim jsonString As String = documentParser.ParseDocument(inputDocument, OutputFormat.JSON)

            ' Display parsed data in console
            Console.WriteLine("Parsed data in JSON format:")
            Console.WriteLine()
            Console.WriteLine(jsonString)

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

End Module
