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


Imports System.IO
Imports Bytescout.PDFExtractor

Module Program

    Sub Main()

        Try
            ' Output file list
            Dim lstAllFilesInfo = New List(Of FileIndexOutput)()

            ' Get all files inside directory
            Dim allFiles = Directory.GetFiles(".\Files", "*.*")

            ' Iterate all files, and get details
            For Each itmFile In allFiles
                ' Get basic file information
                Dim fileInfo As FileInfo = New FileInfo(itmFile)

                ' Check whether file is supported
                If _IsFileSupported(fileInfo) Then
                    ' Fill file index model
                    Dim oFileIndex = New FileIndexOutput()
                    oFileIndex.fileName = fileInfo.Name
                    oFileIndex.fileDate = fileInfo.CreationTime
                    oFileIndex.content = _GetFileContent(fileInfo)

                    ' Add to final list
                    lstAllFilesInfo.Add(oFileIndex)
                End If
            Next

            ' Print all output
            Console.WriteLine("Total {0} files indexed" & vbLf, lstAllFilesInfo.Count)

            For Each itmFileInfo In lstAllFilesInfo
                Console.WriteLine("fileName: {0}", itmFileInfo.fileName)
                Console.WriteLine("fileDate: {0}", itmFileInfo.fileDate.ToString("MMM dd yyyy hh:mm:ss"))
                Console.WriteLine("content: {0}", itmFileInfo.content.Trim())
                Console.WriteLine(vbLf)
            Next

        Catch ex As Exception
            Console.WriteLine(("ERROR:" + ex.Message))
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()
    End Sub

    ''' <summary>
    ''' Get File COntent
    ''' </summary>
    Private Function _GetFileContent(ByVal fileInfo As FileInfo) As String

        Dim fileExtension As String = System.IO.Path.GetExtension(fileInfo.FullName)

        If fileExtension = ".pdf" Then
            Return _GetPdfFileContent(fileInfo)
        ElseIf fileExtension = ".png" OrElse fileExtension = ".jpg" Then
            Return _GetImageContet(fileInfo)
        End If

        Throw New Exception("File not supported.")
    End Function

    ''' <summary>
    ''' Get PDF File Content
    ''' </summary>
    Private Function _GetPdfFileContent(ByVal fileInfo As FileInfo) As String

        ' Read all file content...
        Using textExtractor As TextExtractor = New TextExtractor("demo", "demo")

            ' Load Document
            textExtractor.LoadDocumentFromFile(fileInfo.FullName)

            Return textExtractor.GetText()

        End Using

    End Function

    ''' <summary>
    ''' Get Image Contents
    ''' </summary>
    Private Function _GetImageContet(ByVal fileInfo As FileInfo) As String

        ' Read all file content...
        Using extractor As TextExtractor = New TextExtractor()
            ' Load document
            extractor.LoadDocumentFromFile(fileInfo.FullName)

            ' Set option to repair text
            extractor.OCRMode = OCRMode.TextFromImagesAndVectorsAndRepairedFonts

            ' Enable Optical Character Recognition (OCR)
            ' in .Auto mode (SDK automatically checks if needs to use OCR or not)
            extractor.OCRMode = OCRMode.Auto

            ' Set the location of OCR language data files
            extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\ocrdata\"

            ' Set OCR language
            extractor.OCRLanguage = "eng" '"eng" for english, "deu" for German, "fra" for French, "spa" for Spanish etc - according to files in "ocrdata" folder
            ' Find more language files at https://github.com/bytescout/ocrdata

            ' Set PDF document rendering resolution
            extractor.OCRResolution = 300

            ' Read all text
            Return extractor.GetText()
        End Using
    End Function

    ''' <summary>
    ''' Check whether file is valid
    ''' </summary>
    Private Function _IsFileSupported(ByVal fileInfo As FileInfo) As Boolean
        ' Get File Extension
        Dim fileExtension As String = Path.GetExtension(fileInfo.Name)

        ' Check whether file extension is valid
        Return (fileExtension = ".pdf" OrElse fileExtension = ".png" OrElse fileExtension = ".jpg")
    End Function

    ''' <summary>
    ''' FileIndexOutput class
    ''' </summary>
    Public Class FileIndexOutput
        Public Property fileName As String
        Public Property fileDate As DateTime
        Public Property content As String
    End Class

End Module
