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


Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try

            Using extractor As New TextExtractor()

                ' Load PDF document
                extractor.LoadDocumentFromFile("sample.pdf")

                ' Set the font repairing OCR mode 
                extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts

                ' Set the location of "tessdata" folder containing language data files
                extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net2.00\tessdata\"

                ' Set OCR language
                extractor.OCRLanguage = "eng" ' "eng" For english, "deu" For German, "fra" For French, "spa" For Spanish etc - according To files In /tessdata
                ' Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00

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
