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


Imports Bytescout.PDFExtractor

' This example demonstrates the use of profiles. Profiles are set of properties 
' allowing to apply them to Extractor in any combination quickly. You can use 
' predefined profiles or create you own in JSON format like in this example.

Class Program

    Friend Shared Sub Main(args As String())

        ' Create Bytescout.PDFExtractor.TextExtractor instance
        Dim extractor As New TextExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"
        extractor.OCRLanguageDataFolder = "c:\Program Files\Bytescout PDF Extractor SDK\net2.00\tessdata"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile("sample_ocr.pdf")

        ' Apply predefined profiles
        extractor.Profiles = "scanned, no-layout"
        ' Extract text to file
        extractor.SaveTextToFile("result1.txt")


        extractor.Reset()


        ' Load another document
        extractor.LoadDocumentFromFile("sample_ocr.pdf")

        ' Load and apply custom profiles
        extractor.LoadProfiles("profiles.json")
        extractor.Profiles = "keep-formatting, ocr-forced-200dpi"
        ' Extract text to file
        extractor.SaveTextToFile("result2.txt")


        ' Cleanup
		extractor.Dispose()


    End Sub
End Class
