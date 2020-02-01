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


Imports System.IO
Imports Bytescout.PDF

Module Program

    Sub Main()

        Try
            Dim doc As Document = New Document

            ' Input file Url
            Dim inputUrl As String = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf"

            ' Get Stream for input url
            Dim oInputStream As Stream = GetStreamFromUrl(inputUrl)

            ' Load input stream
            doc.Load(oInputStream)

            ' Swap first and second pages:
            Dim tmp As Page = doc.Pages(1)
            doc.Pages.Remove(1)
            doc.Pages.Insert(0, tmp)

            'Save output file
            doc.Save("result.pdf")

            'Open output file
            Process.Start("result.pdf")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()

    End Sub

    ''' <summary>
    ''' Get stream from Url
    ''' </summary>
    Private Function GetStreamFromUrl(ByVal url As String) As Stream

        Dim oData As Byte() = Nothing

        Using wc As New System.Net.WebClient()
            oData = wc.DownloadData(url)
        End Using

        Return New MemoryStream(oData)

    End Function


End Module
