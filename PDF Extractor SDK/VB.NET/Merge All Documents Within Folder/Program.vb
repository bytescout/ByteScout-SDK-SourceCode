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


Imports Bytescout.PDFExtractor
Imports System.Diagnostics

Class Program

	Friend Shared Sub Main(args As String())

        Dim SourceFolder As String = "PDFDocs"
        Dim DestinationDocument As String = "result.pdf"
        Dim IncludeSubFolder As Boolean = True

        Using merger As New DocumentMerger("demo", "demo")

            merger.MergeFolder(SourceFolder, DestinationDocument, IncludeSubFolder)

        End Using

        Process.Start(DestinationDocument)

    End Sub
    
End Class
