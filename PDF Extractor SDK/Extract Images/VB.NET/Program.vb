'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDFExtractor
Imports System.Drawing.Imaging

Class Program
    Friend Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.ImageExtractor instance
        Dim extractor As New ImageExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile("sample1.pdf")

        Dim i As Integer = 0

        ' Initialize image enumeration
        If extractor.GetFirstImage() Then
            Do
                Dim outputFileName As String = "image" & i & ".png"

                ' Save image to file
                extractor.SaveCurrentImageToFile(outputFileName, ImageFormat.Png)

                i = i + 1

            Loop While extractor.GetNextImage() ' Advance image enumeration
        End If

        ' Open first output file in default associated application
        System.Diagnostics.Process.Start("image0.png")

    End Sub
End Class
