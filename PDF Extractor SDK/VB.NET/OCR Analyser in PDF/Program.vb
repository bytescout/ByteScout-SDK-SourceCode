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


Imports System.Drawing
Imports Bytescout.PDFExtractor

' This example demonstrates the use of OCR Analyser - a tooling class for analysis of scanned documents
' in PDF or raster image formats to find best parameters for Optical Character Recognition (OCR) that
' provide highest recognition quality.

' To make OCR work you should add the following references to your project:
' 'Bytescout.PDFExtractor.dll', 'Bytescout.PDFExtractor.OCRExtension.dll'.

Class Program

    Friend Shared Sub Main(args As String())

        ' Input document
        Dim inputDocument As String = ".\sample_ocr.pdf"

        ' Document page index
        Dim pageIndex As Integer = 0

        ' Area of the document page to perform the analysis (optional).
        ' RectangleF.Empty means the full page.
        Dim rectangle As RectangleF = RectangleF.Empty ' New RectangleF(100, 50, 350, 250)

        ' Location of OCR language data files
        Dim ocrLanguageDataFolder As String = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\"

        ' OCR language
        Dim ocrLanguage As String = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
        ' Find more language files at https://github.com/tesseract-ocr/tessdata


        ' Create OCRAnalyzer instance and activate it with your registration information
        Using ocrAnalyzer As New OCRAnalyzer("demo", "demo")

            ' Display analysis progress
            AddHandler ocrAnalyzer.ProgressChanged, Sub(sender, message, progress, ByRef cancel)
                                                        Console.WriteLine(message)
                                                    End Sub

            ' Load document to OCRAnalyzer
            ocrAnalyzer.LoadDocumentFromFile(inputDocument)

            ' Setup OCRAnalyzer
            ocrAnalyzer.OCRLanguage = ocrLanguage
            ocrAnalyzer.OCRLanguageDataFolder = ocrLanguageDataFolder

            ' Set page area for analysis (optional)
            ocrAnalyzer.SetExtractionArea(rectangle)

            ' Perform analysis and get results
            Dim analysisResults As OCRAnalysisResults = ocrAnalyzer.AnalyzeByOCRConfidence(pageIndex)


            ' Now extract page text using detected OCR parameters

            Dim outputDocument As String = ".\result.txt"

            ' Create TextExtractor instance
            Using textExtractor As TextExtractor = New TextExtractor("demo", "demo")

                ' Load document to TextExtractor
                textExtractor.LoadDocumentFromFile(inputDocument)

                ' Setup TextExtractor
                textExtractor.OCRMode = OCRMode.Auto
                textExtractor.OCRLanguageDataFolder = ocrLanguageDataFolder
                textExtractor.OCRLanguage = ocrLanguage

                ' Apply analysys results to TextExtractor instance
                ocrAnalyzer.ApplyResults(analysisResults, textExtractor)

                ' Set extraction area (optional)
                textExtractor.SetExtractionArea(rectangle)

                ' Save extracted text to file
                textExtractor.SaveTextToFile(outputDocument)

                ' Open output file in default associated application (for demonstration purposes)
                System.Diagnostics.Process.Start(outputDocument)

            End Using

        End Using

    End Sub
    
End Class
