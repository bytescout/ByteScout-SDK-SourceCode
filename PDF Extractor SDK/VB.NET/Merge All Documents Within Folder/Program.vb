'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
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

        Dim processStartInfo As New ProcessStartInfo(DestinationDocument)
        processStartInfo.UseShellExecute = True
        Process.Start(processStartInfo)

    End Sub
    
End Class
