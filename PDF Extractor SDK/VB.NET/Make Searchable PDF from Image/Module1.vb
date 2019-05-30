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


Imports Bytescout.PDFExtractor

Module Module1

    Sub Main()

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim searchablePdfMaker As SearchablePDFMaker = New SearchablePDFMaker()
        searchablePdfMaker.RegistrationName = "demo"
        searchablePdfMaker.RegistrationKey = "demo"

        ' Load sample Image document
        searchablePdfMaker.LoadDocumentFromFile("sample_ocr.jpg")

        ' Set the location of OCR language data files
        searchablePdfMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\"

        ' Set OCR language
        searchablePdfMaker.OCRLanguage = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder

        ' Set PDF document rendering resolution
        searchablePdfMaker.OCRResolution = 300

        ' Save extracted text to file
        searchablePdfMaker.MakePDFSearchable("output.pdf")

        ' Cleanup
        searchablePDFMaker.Dispose()

        ' Open output file in default associated application
        Dim processStartInfo As New ProcessStartInfo("output.pdf")
        processStartInfo.UseShellExecute = True
        System.Diagnostics.Process.Start(processStartInfo)

    End Sub

End Module
