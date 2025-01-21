'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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
