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


Imports Bytescout.TextRecognition

Module Module1

    Sub Main()

        Dim inputDocument As String = ".\skewed.png"
        Dim outputDocument As String = ".\result.txt"

        ' Create and activate TextRecognizer instance
        Using textRecognizer As TextRecognizer = New TextRecognizer("demo", "demo")

            Try
                ' Load document (image or PDF)
                textRecognizer.LoadDocument(inputDocument)

                ' Set the location of OCR language data files
                textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_best\"

                ' Set OCR language.
                ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
                ' Find more language files at https://github.com/bytescout/ocrdata
                textRecognizer.OCRLanguage = "eng" 


                ' Add deskew filter that automatically rotates the image to make the text horizontal.
                ' Note, it analyzes the left edge of scanned text. Any dark artifacts may prevent 
                ' the correct angle detection.
                textRecognizer.ImagePreprocessingFilters.AddDeskew()

                ' Other filters that may be useful to improve recognition
                ' (note, the filters are applied in the order they were added):

                ' Improve image contrast.
                'textRecognizer.ImagePreprocessingFilters.AddContrast()

                ' Apply gamma correction.
                'textRecognizer.ImagePreprocessingFilters.AddGammaCorrection()

                ' Apply median filter. Helps to remove noise.
                'textRecognizer.ImagePreprocessingFilters.AddMedian()

                ' Apply dilate filter. Helps to cure symbols erosion.
                'textRecognizer.ImagePreprocessingFilters.AddDilate()

                ' Lines removers. Removing borders of some tables may improve the recognition.
                'textRecognizer.ImagePreprocessingFilters.AddHorizontalLinesRemover()
                'textRecognizer.ImagePreprocessingFilters.AddVerticalLinesRemover()

                
                ' Recognize text from all pages and save it to file
                textRecognizer.SaveText(outputDocument)

                ' Open the result file in default associated application (for demo purposes)
                Process.Start(outputDocument)

            Catch exception As Exception

                Console.WriteLine(exception)

            End Try

        End Using

    End Sub

End Module
