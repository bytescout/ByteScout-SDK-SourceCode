'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.Drawing
Imports System.IO
Imports System.Web.Script.Serialization
Imports Bytescout.PDFExtractor

Module Module1

    ''' <summary>
    ''' This example demonstrates detecting fraud within invoices
    ''' Please Note With Trial version, extracted value might have demo warnings And sample might Not work As exptected.
    ''' </summary>
    Sub Main()

        Dim allInputFiles As String() = {"Sample_Files\InvoiceMar.pdf", "Sample_Files\InvoiceApr.pdf", "Sample_Files\InvoiceApr_Forged.pdf"}
        Dim settingJson = File.ReadAllText("settings.json")
        Dim deserializer As New JavaScriptSerializer()

        ' Deserialize json to class objects
        Dim lstExtractionSettings = deserializer.Deserialize(Of List(Of ExtractionSettings))(settingJson)

        ' Loop through all input files
        For Each itmFile In allInputFiles

            ' Create TextExtractor instance
            Using textExtractor As New TextExtractor("demo", "demo")

                ' Load document from file
                textExtractor.LoadDocumentFromFile(itmFile)

                Console.WriteLine("Evaluating File: {0}{1}", itmFile, Environment.NewLine)

                Dim isAllCriteriaMatched As Boolean = True
                For Each itmSetting In lstExtractionSettings

                    ' Region to extract from
                    Dim extractionRegion As New RectangleF(itmSetting.RegionLocation.X, itmSetting.RegionLocation.Y, itmSetting.RegionLocation.Width, itmSetting.RegionLocation.Height)

                    ' Get Extracted Value
                    Dim extractedValue = GetTextFromRegion(textExtractor, extractionRegion)
                    Dim isCriteriaPassed As Boolean = (itmSetting.CorrectValue = extractedValue)

                    Console.WriteLine("Region Type: {0}", itmSetting.RegionType)
                    Console.WriteLine("Expected Value: {0}", itmSetting.CorrectValue)
                    Console.WriteLine("Extracted Value: {0}", extractedValue)
                    Console.WriteLine("Criteria Passed: {0}{1}", isCriteriaPassed, Environment.NewLine)

                    isAllCriteriaMatched = isCriteriaPassed AndAlso isAllCriteriaMatched
                Next

                Console.WriteLine("Fraud Detected: {0}", Not isAllCriteriaMatched)
                Console.WriteLine("{0}{0}-----------------------------{0}{0}", Environment.NewLine)

            End Using

        Next

        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

    ''' <summary>
    ''' Get text from particular region
    ''' </summary>
    Private Function GetTextFromRegion(ByVal textExtractor As TextExtractor, ByVal extractionRegion As RectangleF, ByVal Optional pageIndex As Int32 = 0) As String

        ' Set Extraction Area
        textExtractor.SetExtractionArea(extractionRegion)

        ' Get Text from that region
        Return textExtractor.GetTextFromPage(pageIndex).Trim()

    End Function

    Class ExtractionSettings

        Public Sub New()
            RegionLocation = New ExtractionSettingRegion()
        End Sub

        Public Property RegionType As String
        Public Property CorrectValue As String
        Public Property RegionLocation As ExtractionSettingRegion
    End Class

    Class ExtractionSettingRegion
        Public Property X As Single
        Public Property Y As Single
        Public Property Width As Single
        Public Property Height As Single
    End Class

End Module
