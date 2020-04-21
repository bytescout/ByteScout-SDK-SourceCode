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


Imports System.Drawing.Imaging
Imports System.IO
Imports Bytescout.PDF
Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try
            ' Files
            Dim fileName As String = "hindi_text_with_image.pdf"
            Dim destFileName As String = "output_hindi_text_with_image.pdf"
            Dim destFileName_serachable As String = "output_hindi_text_with_image_searchable.pdf"

            ' Read all text from pdf file
            Dim allTextExtracted As String = ""

            Using extractor As New TextExtractor

                ' Load PDF document
                extractor.LoadDocumentFromFile(fileName)

                ' Read all text to a variable
                allTextExtracted = extractor.GetText

            End Using

            ' Get image from pdf file
            Dim memoryStream As MemoryStream = New MemoryStream

            Using extractor As New ImageExtractor

                ' Load PDF document
                extractor.LoadDocumentFromFile(fileName)

                If extractor.GetFirstImage Then
                    extractor.SaveCurrentImageToStream(memoryStream, ImageFormat.Png)
                End If

            End Using

            ' Load image from file to System.Drawing.Image object (we need it to get the image resolution)
            Using sysImage As System.Drawing.Image = System.Drawing.Image.FromStream(memoryStream)

                ' Compute image size in PDF units (Points)
                Dim widthInPoints As Single = (sysImage.Width / sysImage.HorizontalResolution * 72.0F)
                Dim heightInPoints As Single = (sysImage.Height / sysImage.VerticalResolution * 72.0F)

                ' Create new PDF document
                Dim outPdfDocument As Document = New Document
                outPdfDocument.RegistrationName = "demo"
                outPdfDocument.RegistrationKey = "demo"

                ' Create page of computed size
                Dim page As Page = New Page(widthInPoints, heightInPoints)

                ' Add page to the document
                outPdfDocument.Pages.Add(page)

                Dim canvas As Canvas = page.Canvas

                ' Create Bytescout.PDF.Image object from loaded image
                Dim pdfImage As Image = New Image(sysImage)

                ' Draw the image
                canvas.DrawImage(pdfImage, 0, 0, widthInPoints, heightInPoints)

                ' Dispose the System.Drawing.Image object to free resources
                sysImage.Dispose()

                ' Create brush
                Dim transparentBrush As SolidBrush = New SolidBrush(New ColorGray(0))

                ' ... and make it transparent
                transparentBrush.Opacity = 0

                ' Draw text with transparent brush
                ' Need to set Font which supports hindi characters.
                Dim font16 As Font = New Font("Arial Unicode MS", 16)
                canvas.DrawString(allTextExtracted, font16, transparentBrush, 40, 40)

                ' Save document to file
                outPdfDocument.Save(destFileName)

            End Using


            'Make PDF file with hindi text searchable to OCR.
            Using searchablePDFMaker As New SearchablePDFMaker

                'Load PDF document
                searchablePDFMaker.LoadDocumentFromFile(destFileName)

                ' Set the location of "tessdata" folder containing language data files

                ' It used following files for hindi language support. Need to put these files into "testdata" folder. Below location contains these files.
                ' https://github.com/tesseract-ocr/tessdata/tree/3.04.00 
                ' hin.traineddata
                ' hin.cube.bigrams
                ' hin.cube.lm
                ' hin.cube.nn
                ' hin.cube.params
                ' hin.cube.word-freq
                ' hin.tesseract_cube.nn

                ' Set the location of "tessdata" folder containing language data files
                searchablePDFMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\net2.00\tessdata"

                ' Set OCR language
                searchablePDFMaker.OCRLanguage = "hin"

                ' Need to set Font which supports hindi characters
                searchablePDFMaker.LabelingFont = "Arial Unicode MS"

                ' Set PDF document rendering resolution
                searchablePDFMaker.OCRResolution = 300

                ' Make PDF document searchable
                searchablePDFMaker.MakePDFSearchable(destFileName_serachable)

            End Using

            ' Open document in default PDF viewer app
            Process.Start(destFileName_serachable)

        Catch ex As Exception
            Console.WriteLine("ERROR:" + ex.Message)
        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

End Module
