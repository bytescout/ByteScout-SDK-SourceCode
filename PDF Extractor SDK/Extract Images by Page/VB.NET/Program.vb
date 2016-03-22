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
	Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.ImageExtractor instance
        Dim extractor As New ImageExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
        extractor.LoadDocumentFromFile("sample1.pdf")

        ' Get count of pages
		Dim pageCount As Integer = extractor.GetPageCount()

        ' Extract images from each page
        For i As Integer = 0 To pageCount - 1

            Dim j As Integer = 0

            ' Initialize page images enumeration
            If extractor.GetFirstPageImage(i) Then
                Do
                    Dim outputFileName As String = "page" & i & "image" & j & ".png"

                    ' Save image to file
                    extractor.SaveCurrentImageToFile(outputFileName, ImageFormat.Png)

                    j = j + 1

                Loop While extractor.GetNextImage() ' Advance image enumeration
            End If

        Next

		' Open first output file in default associated application
        System.Diagnostics.Process.Start("page0image0.png")
	End Sub
End Class
