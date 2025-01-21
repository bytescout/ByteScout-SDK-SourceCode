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

                ' Set the location of OCR language data files
                extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata_best\"

                ' Set OCR language
                extractor.OCRLanguage = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                ' Find more language files at https://github.com/bytescout/ocrdata

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
