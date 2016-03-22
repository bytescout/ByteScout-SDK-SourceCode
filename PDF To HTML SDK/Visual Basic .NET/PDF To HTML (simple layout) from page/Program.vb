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

        ' Set plain HTML extraction mode
        extractor.ExtractionMode = HTMLExtractionMode.PlainHTML

        ' Load sample PDF document
        extractor.LoadDocumentFromFile("sample2.pdf")

        ' Convert 2-nd page to HTML and save it to file
        extractor.SaveHtmlPageToFile(1, "output.html")

        ' Open output file in default associated application
        System.Diagnostics.Process.Start("output.html")

	End Sub
End Class
