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
            ' Read all file content...
            Using extractor As TextExtractor = New TextExtractor()
                ' Load document
                extractor.LoadDocumentFromFile("sample.png")

                ' Extractor Progress event
                Console.WriteLine("Text Extraction in progress: " & vbLf)
                AddHandler extractor.ProgressChanged, AddressOf Extractor_ProgressChanged

                ' Set option to repair text
                extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts

                ' Enable Optical Character Recognition (OCR)
                ' in .Auto mode (SDK automatically checks if needs to use OCR or not)
                extractor.OCRMode = OCRMode.Auto

                ' Set the location of OCR language data files
                extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\"

                ' Set OCR language
                extractor.OCRLanguage = "eng" ' "eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
                ' Find more language files at https://github.com/tesseract-ocr/tessdata

                ' Set PDF document rendering resolution
                extractor.OCRResolution = 300

                ' Read all text
                Dim allExtractedText = extractor.GetText()
                Console.WriteLine(vbLf & vbLf & "Extracted Text:" & vbLf & vbLf & "{0}", allExtractedText)
            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub


    ''' <summary>
    ''' Handle progress change event
    ''' </summary>
    Private Sub Extractor_ProgressChanged(ByVal sender As Object, ByVal ongoingOperation As OngoingOperation, ByVal progress As Double, ByRef cancel As Boolean)
        drawTextProgressBar(Convert.ToInt32(progress), 100)
    End Sub

    ''' <summary>
    ''' Display progress bar
    ''' </summary>
    Private Sub drawTextProgressBar(ByVal progress As Integer, ByVal total As Integer)
        'draw empty progress bar
        Console.CursorLeft = 0
        Console.Write("[") ' start
        Console.CursorLeft = 32
        Console.Write("]") ' end
        Console.CursorLeft = 1
        Dim onechunk As Single = 30.0F / total
        Dim position As Integer = 1

        ' draw filled part
        For i As Integer = 0 To onechunk * progress - 1
            Console.BackgroundColor = ConsoleColor.Green
            Console.CursorLeft = Math.Min(System.Threading.Interlocked.Increment(position), position - 1)
            Console.Write(" ")
        Next

        ' draw unfilled part
        For i As Integer = position To 31
            Console.BackgroundColor = ConsoleColor.Gray
            Console.CursorLeft = Math.Min(System.Threading.Interlocked.Increment(position), position - 1)
            Console.Write(" ")
        Next

        ' draw totals
        Console.CursorLeft = 35
        Console.BackgroundColor = ConsoleColor.Black
        Console.Write(progress.ToString() & " of " & total.ToString() & "    ") ' blanks at the end remove any excess
    End Sub

End Module
