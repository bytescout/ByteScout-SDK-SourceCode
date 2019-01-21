'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


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

        ' Cleanup
        extractor.Dispose();

        ' Open output file in default associated application
        System.Diagnostics.Process.Start("output.html")

    End Sub
End Class
