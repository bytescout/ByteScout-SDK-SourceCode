'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.TextRecognition

Module Module1

    Sub Main()

        Dim inputDocument As String = ".\bad-quality.png"
        Dim outputDocument As String = ".\result.txt"

        ' Create and activate TextRecognizer instance
        Using textRecognizer As TextRecognizer = New TextRecognizer("demo", "demo")

            Try
                ' Load document (image or PDF)
                textRecognizer.LoadDocument(inputDocument)

                ' Set the location of OCR language data files
                textRecognizer.OCRLanguageDataFolder = "c:\Program Files\ByteScout Text Recognition SDK\ocrdata_fast\"

                ' Set OCR language.
                ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish, etc. - according to files in "ocrdata" folder
                ' Find more language files at https://github.com/bytescout/ocrdata
                textRecognizer.OCRLanguage = "eng" 


                ' Add error corrections that will be applied after the recognition.
                textRecognizer.Corrections.Add("Tut ", "Test ")
                textRecognizer.Corrections.Add("Recog\w{1,}on", "Recognition", True)

                
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
