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

            ' Loop through all files in directory and check whether OCR operation is required
            For Each filePath As String In System.IO.Directory.GetFiles("InputFiles")
                _CheckOCRRequired(filePath)
            Next

        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Check whether OCR Operation is required
    ''' </summary>
    ''' <param name="filePath"></param>
    Private Sub _CheckOCRRequired(ByVal filePath As String)

        ' Read all file content...
        Using extractor As TextExtractor = New TextExtractor()

            extractor.RegistrationKey = "demo"
            extractor.RegistrationName = "demo"

            ' Load document
            extractor.LoadDocumentFromFile(filePath)
            Console.WriteLine("{1}*******************{1}{1}FilePath: {0}", filePath, vbLf)

            Dim pageIndex As Int32 = 0

            ' Identify OCR operation is recommended for page
            If (extractor.IsOCRRecommendedForPage(pageIndex)) Then

                Console.WriteLine("{0}OCR Recommended: True", vbLf)

                ' Enable Optical Character Recognition (OCR)
                ' in .Auto mode (SDK automatically checks if needs to use OCR or not)
                extractor.OCRMode = OCRMode.Auto

                ' Set the location of "tessdata" folder containing language data files
                extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\Redistributable\net2.00\tessdata\"

                ' Set OCR language
                extractor.OCRLanguage = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in /tessdata
                ' Find more language files at https://github.com/tesseract-ocr/tessdata/tree/3.04.00

                ' Set PDF document rendering resolution
                extractor.OCRResolution = 300

            Else
                Console.WriteLine("{0}OCR Recommended: False", vbLf)
            End If

            ' Read all text
            Dim allExtractedText = extractor.GetText()
            Console.WriteLine("{1}Extracted Text:{1}{0}{1}{1}", allExtractedText, vbLf)

        End Using

    End Sub



End Module
