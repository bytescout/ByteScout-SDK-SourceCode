'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDFExtractor

Class Program
    Friend Shared Sub Main(ByVal args As String())

        ' Create Bytescout.PDFExtractor.MultimediaExtractor instance
        Dim extractor As New MultimediaExtractor()
		extractor.RegistrationName = "demo"
		extractor.RegistrationKey = "demo"

        ' Load sample PDF document
        extractor.LoadDocumentFromFile("sample.pdf")

        Dim i As Integer = 0

        ' Initialize sound clips enumeration
        If extractor.GetFirstAudio() Then
            Do
                Dim outputFileName As String = "audio" & i & extractor.GetCurrentAudioExtension()

                ' Save sound clip to file
                extractor.SaveCurrentAudioToFile(outputFileName)

                i = i + 1

            Loop While extractor.GetNextAudio() ' Advance sounds enumeration
        End If

    End Sub
End Class
