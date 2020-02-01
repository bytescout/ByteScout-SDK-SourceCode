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


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Bytescout.PDFExtractor
Imports System.Diagnostics
Imports System.IO

Namespace ConsoleApplication1

    Class Program

        Shared Sub Main(ByVal args As String())

            'Please note: Streams can be read/write To azure blobs, so In this example,
            'we 're demonstrating how to read pdf from stream, convert to csv, 
            'And write to csv stream

            ' Create Bytescout.PDFExtractor.CSVExtractor instance
            Dim extractor As New CSVExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Get input stream
            Dim inputStream = GetMemoryStream("sample3.pdf")

            ' Load sample PDF document from Stream
            extractor.LoadDocumentFromStream(inputStream)

            ' You can change CSV separator symbol (if needed) from "," symbol to another if needed for non-US locales
            'extractor.CSVSeparatorSymbol = "," 

            ' Save extracted CSV data to output stream
            Dim outputStream As New MemoryStream()
            extractor.SaveCSVToStream(outputStream)

            ' Save output stream to file, so  we can take a look
            WriteStreamToFile(outputStream, "output.csv")

            ' Cleanup
            extractor.Dispose()

            Console.WriteLine()
            Console.WriteLine("Data has been extracted to 'output.csv' file.")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue and open CSV in default CSV viewer (or Excel)...")
            Console.ReadKey()

            ' Open result file in default associated application (for demo purposes)
            Process.Start("output.csv")

        End Sub

        ''' <summary>
        ''' Get Memory stream from file
        ''' </summary>
        Shared Function GetMemoryStream(ByVal fileName As String) As Stream
            Return New FileStream(fileName, FileMode.Open)
        End Function

        ''' <summary>
        ''' Write stream to file
        ''' </summary>
        Shared Sub WriteStreamToFile(ByVal stream As Stream, ByVal fileName As String)

            Using fileStream = File.Create(fileName)
                stream.Seek(0, SeekOrigin.Begin)
                stream.CopyTo(fileStream)
            End Using

        End Sub

    End Class
End Namespace

