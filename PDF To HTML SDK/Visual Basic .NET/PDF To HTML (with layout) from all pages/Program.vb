'*******************************************************************
'       ByteScout PDF To HTML SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDF2HTML

Class Program
	Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDF2HTML.HTMLExtractor instance
        Dim extractor As New HTMLExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

		' Load sample PDF document
        extractor.LoadDocumentFromFile("sample2.pdf")

        ' Set HTML with CSS extraction mode
        extractor.ExtractionMode = HTMLExtractionMode.HTMLWithCSS

        ' Save extracted HTML to file
        extractor.SaveHtmlToFile("output.html")

		' Open output file in default associated application
        System.Diagnostics.Process.Start("output.html")
	End Sub
End Class
