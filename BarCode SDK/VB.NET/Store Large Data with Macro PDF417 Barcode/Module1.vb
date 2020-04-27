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
Imports System.Linq
Imports Bytescout.BarCode

Module Module1

    Sub Main()

        ' Load text file 
        Dim textInput As String = System.IO.File.ReadAllText("InputData.txt")

        ' Split text into chunks
        Dim lstChunks = textInput.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        ' Create new barcode
        Using barcode As New Barcode("demo", "demo")

            ' Keep generated barcode images in the list
            Dim images As New List(Of Image)()

            ' Select Macro PDF417 barcode type
            barcode.Symbology = SymbologyType.MacroPDF417

            Dim macro417SegmentHelper As Macro417SegmentHelper = New Macro417SegmentHelper()
            macro417SegmentHelper.AddValue(lstChunks)

            ' Set FileID. 
            ' FileID Is a number from 0 to 899. It must be same for all barcodes in the set.
            barcode.Options.PDF417FileID = 123

            Dim ctr = 0
            Dim resImgName = ""
            For Each itmSegment As Macro417Segment In macro417SegmentHelper.GetAllSegments()
                ' create the first segment barcode so set SegmentIndex = 1
                barcode.Options.PDF417SegmentIndex = itmSegment.SegmentIndex

                ' Set value            
                barcode.Value = itmSegment.SegmentValue

                ' set that this Is Not the last segment yet
                barcode.Options.PDF417LastSegment = itmSegment.IsLastSegment

                ' Save barcode to image
                ctr = ctr + 1
                resImgName = $"img{ctr}.png"
                barcode.SaveImage(resImgName, Imaging.ImageFormat.Png)

                Console.WriteLine("'{0}' generated!", resImgName)

            Next

        End Using

        Console.ReadLine()

    End Sub


    Public Class Macro417SegmentHelper

        ' Declarations
        Private Property lstValues As List(Of String) = New List(Of String)()

        ' Add segment value
        Public Sub AddValue(ParamArray strValue As String())
            Me.AddValue(strValue.ToList)
        End Sub

        Public Sub AddValue(ByVal strValue As List(Of String))
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
