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


Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try

            Using extractor As New TextExtractor()

                ' Load noisy image document
                extractor.LoadDocumentFromFile("sample.png")

                ' Set the font repairing OCR mode 
                extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts

                ' Set the location of OCR language data files
                extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

                ' Set OCR language
                extractor.OCRLanguage = "eng" ' "eng" For english, "deu" For German, "fra" For French, "spa" For Spanish etc - according To files In "ocrdata" folder
                ' Find more language files at https://github.com/bytescout/ocrdata

                ' Set PDF document rendering resolution
                extractor.OCRResolution = 300

                ' You can also apply various preprocessing filters
                ' to improve the recognition on low-quality scans.

                Console.WriteLine("Please wait while PDF Extractor SDK is processing noisy image to read data...")

                ' Automatically deskew skewed scans
                extractor.OCRImagePreprocessingFilters.AddDeskew()

                ' Remove vertical Or horizontal lines (sometimes helps to avoid OCR engine's page segmentation errors)
                ' extractor.OCRImagePreprocessingFilters.AddVerticalLinesRemover();
                ' extractor.OCRImagePreprocessingFilters.AddHorizontalLinesRemover();

                ' Repair broken letters
                extractor.OCRImagePreprocessingFilters.AddDilate()

                ' Remove noise
                extractor.OCRImagePreprocessingFilters.AddMedian()

                ' Apply Gamma Correction
                extractor.OCRImagePreprocessingFilters.AddGammaCorrection()

                ' Add Contrast
                ' extractor.OCRImagePreprocessingFilters.AddContrast(20)

                ' (!) You can use New OCRAnalyser class to find an optimal set of image preprocessing 
                ' filters for your specific document.
                ' See "OCR Analyser" example.

                ' Read all text
                Dim allText = extractor.GetText()

                Console.Clear()
                Console.WriteLine("Extracted Text: ")
                Console.WriteLine(allText)

            End Using

        Catch ex As Exception
            Console.Clear()
            Console.WriteLine("Exception: " + ex.Message)
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
