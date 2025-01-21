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

        Dim inputFile As String = "sample1.pdf"

        Using rotator As New DocumentRotator("demo", "demo")
            rotator.Rotate(inputFile, "result.pdf", RotationAngle.Deg90)
        End Using

        Process.Start("result.pdf")

    End Sub
    
End Class
