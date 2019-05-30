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


Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try

            Using searchablePDFMaker = New SearchablePDFMaker("demo", "demo")

                ' Load input file
                searchablePDFMaker.LoadDocumentFromFile("sample_ocr.pdf")

                ' Add Progress change event...
                Console.WriteLine("Searchable PDF making in progress: " & vbLf)
                AddHandler searchablePDFMaker.ProgressChanged, AddressOf SearchablePDF_ProgressChanged

                ' Set the location of OCR language data files 
                searchablePDFMaker.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\"

                ' Set OCR language
                searchablePDFMaker.OCRLanguage = "eng"

                ' Set PDF document rendering resolution
                searchablePDFMaker.OCRResolution = 300

                ' Save extracted text to file
                searchablePDFMaker.MakePDFSearchable("output.pdf")

                ' Open output file in default associated application
                System.Diagnostics.Process.Start("output.pdf")
            End Using

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine(vbLf & vbLf & " Press enter key to exit...")
        Console.ReadLine()
    End Sub


    ''' <summary>
    ''' Handle progress change event
    ''' </summary>
    Private Sub SearchablePDF_ProgressChanged(ByVal sender As Object, ByVal ongoingOperation As OngoingOperation, ByVal progress As Double, ByRef cancel As Boolean)
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
