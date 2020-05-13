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


Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports Bytescout.PDFExtractor

Class Program

    Friend Shared Sub Main(args As String())

        ' Set extraction regions
        ' Use Bytescout Template Editor / Bytescout PDF Multitool or other tool to know region co-ordinates
        Dim lstExtractionRegion As New List(Of RectangleF) From {
            New RectangleF(7.5F, 33.8F, 244.5F, 353.3F),
            New RectangleF(273.8F, 201.8F, 247.5F, 198.0F),
            New RectangleF(537.8F, 27.0F, 246.0F, 268.5F)
        }

        ' Ouput File
        Dim resFile As String = "result.txt"
        Dim sRes As New StringBuilder(String.Empty)

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor As New TextExtractor With {
            .RegistrationName = "demo",
            .RegistrationKey = "demo"
        }

        ' Load sample PDF document
        extractor.LoadDocumentFromFile(".\SampleFoldable.pdf")

        '  Loop through all extraction regions, and extract text
        For Each oRegion As RectangleF In lstExtractionRegion
            sRes.AppendLine(GetTextFromRegion(extractor, oRegion))
        Next

        ' Cleanup
        extractor.Dispose()

        ' Write all result to output file
        File.WriteAllText(resFile, sRes.ToString())

        ' Open result file in default associated application (for demo purposes)
        System.Diagnostics.Process.Start(resFile)
    End Sub

    ''' <summary>
    ''' Get text from particular region
    ''' </summary>
    Friend Shared Function GetTextFromRegion(ByVal textExtractor As TextExtractor, ByVal extractionRegion As RectangleF, ByVal Optional pageIndex As Int32 = 0) As String

        ' Set Extraction Area
        textExtractor.SetExtractionArea(extractionRegion)

        ' Get Text from that region
        Return textExtractor.GetTextFromPage(pageIndex)

    End Function


End Class
