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


Imports System.Drawing
Imports Bytescout.TextRecognition

Module Module1

    Sub Main()

        Dim inputDocument As String = ".\areas-sample.pdf"
        Dim pageIndex As Integer = 0
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
                
                ' Get page size (in pixels). Size of PDF document is computed from PDF Points 
                ' and the rendering resoultion specified by `textRecognizer.PDFRenderingResolution` (default 300 DPI)
                Dim pageSize As Size = textRecognizer.GetPageSize(pageIndex)

                ' Add area of interest as a rectangle at the top-right corner of the page
                textRecognizer.RecognitionAreas.Add(pageSize.Width / 2, 0, pageSize.Width / 2, 300)
                ' Add area of interest as a rectangle at the bottom-left corner of the page,
                ' and indicate it should be rotated at 90 deg
                textRecognizer.RecognitionAreas.Add(0, pageSize.Height / 2, 300, pageSize.Height / 2, AreaRotation.Rotate90FlipNone)

                ' Now you can get recognized text for further analysis as a list of objects 
                ' containing coordinates, object kind, confidence.
                Dim ocrObjectList As OCRObjectList = textRecognizer.GetOCRObjects(pageIndex)
                For Each ocrObject As OCRObject In ocrObjectList
                    Console.WriteLine(ocrObject.ToString())
                Next

                ' ... or you can save recognized text pieces to file
                textRecognizer.KeepTextFormatting = False ' save without formatting
                textRecognizer.SaveText(outputDocument, pageIndex, pageIndex)


                ' Open the result file in default associated application (for demo purposes)
                Process.Start(outputDocument)

            Catch exception As Exception

                Console.WriteLine(exception)

            End Try

        End Using

    End Sub

End Module
