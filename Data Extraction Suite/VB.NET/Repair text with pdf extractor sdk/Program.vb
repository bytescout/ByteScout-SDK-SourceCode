'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try

            Using extractor As New TextExtractor()

                ' Load PDF document
                extractor.LoadDocumentFromFile("sample.pdf")

                ' Set the font repairing OCR mode 
                extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts

                ' Set the location of OCR language data files
                extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

                ' Set OCR language
                extractor.OCRLanguage = "eng" ' "eng" For english, "deu" For German, "fra" For French, "spa" For Spanish etc - according To files In "ocrdata" folder
                ' Find more language files at https://github.com/bytescout/ocrdata

                ' Set PDF document rendering resolution
                extractor.OCRResolution = 300

                ' Read all text
                Dim allText = extractor.GetText()

                Console.WriteLine("Extracted Text: ")
                Console.WriteLine(allText)

            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
