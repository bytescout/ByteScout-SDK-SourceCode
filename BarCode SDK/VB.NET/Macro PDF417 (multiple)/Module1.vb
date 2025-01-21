'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.BarCode

Module Module1

    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.MacroPDF417

        ' we will encode value 123456789
        ' will break into 3 segments, each segment includes 3 symbols
        Dim macro417SegmentHelper As Macro417SegmentHelper = New Macro417SegmentHelper()
        macro417SegmentHelper.AddValue("123", "456", "789")

        For Each itmSegment As Macro417Segment In macro417SegmentHelper.GetAllSegments()
            ' create the first segment barcode so set SegmentIndex = 1
            barcode.Options.PDF417SegmentIndex = itmSegment.SegmentIndex

            ' Set value            
            barcode.Value = itmSegment.SegmentValue

            ' set that this Is Not the last segment yet
            barcode.Options.PDF417LastSegment = itmSegment.IsLastSegment

            ' Save barcode to image
            barcode.SaveImage($"MacroPDFBarcode-part{itmSegment.SegmentIndex}.png")

            ' Show image in default image viewer
            Process.Start($"MacroPDFBarcode-part{itmSegment.SegmentIndex}.png")
        Next

    End Sub


    Public Class Macro417SegmentHelper

        ' Declarations
        Private Property lstValues As List(Of String) = New List(Of String)()

        ' Add segment value
        Public Sub AddValue(ParamArray strValue As String())
            For Each item As String In strValue
                lstValues.Add(item)
            Next
        End Sub

        ' Get all segment value
        Public Function GetAllSegments() As List(Of Macro417Segment)
            Dim lstRet = New List(Of Macro417Segment)()

            For i As Integer = 0 To lstValues.Count - 1
                Dim oSegment = New Macro417Segment With {
                    .SegmentValue = lstValues(i),
                    .SegmentIndex = i + 1,
                    .IsLastSegment = ((i + 1) = lstValues.Count)
                }
                lstRet.Add(oSegment)
            Next

            Return lstRet
        End Function

    End Class

    Public Class Macro417Segment
        Public Property SegmentValue As String
        Public Property SegmentIndex As Integer
        Public Property IsLastSegment As Boolean
    End Class

End Module
