'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO
Imports System.Linq
Imports System.Text
Imports Bytescout.BarCodeReader


Module Module1

    Sub Main()

        ' Input Image files
        Dim ImageFiles = New String() {"MacroPDFBarcode-part1.png", "MacroPDFBarcode-part2.png", "MacroPDFBarcode-part3.png"}

        ' Create Instance of Macro PDF 417 class
        Dim oMacroPDF417Values = New MacroPDF417Values()

        ' Loop through input files to get value
        For Each itmInput As String In ImageFiles
            Using reader = New Reader("demo", "demo")

                ' -----------------------------------------------------------------------
                ' NOTE: We can read barcodes from specific page to increase performance.
                ' For sample please refer To "Decoding barcodes from PDF by pages" program.
                '  -----------------------------------------------------------------------

                ' Set barcode type to find
                reader.BarcodeTypesToFind.PDF417 = True

                ' Read barcodes
                Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(itmInput))
                Dim barcodes As FoundBarcode() = reader.ReadFrom(itmInput)

                For Each barcode As FoundBarcode In barcodes
                    Console.WriteLine("Found Value: " & barcode.Value & vbLf)
                    oMacroPDF417Values.AddValue(barcode.Value)
                Next

            End Using
        Next

        ' Get MacroPDF417 output value
        Dim outputValue = oMacroPDF417Values.GetValue()
        Console.WriteLine(vbLf & vbLf & "Consolidated Output Value: " & outputValue)

        Console.WriteLine(vbLf & vbLf & "Press any key to exit..")
        Console.ReadKey()

    End Sub


    Public Class MacroPDF417Values

        Public Sub New()
            lstSegments = New List(Of MacroPDFSegmment)()
        End Sub

        Public Property lstSegments As List(Of MacroPDFSegmment)

        ''' <summary>
        ''' Add Value
        ''' </summary>
        Public Sub AddValue(ByVal strValue As String)
            lstSegments.Add(New MacroPDFSegmment(strValue))
        End Sub

        ''' <summary>
        ''' Get value
        ''' </summary>
        Public Function GetValue() As String
            Dim retValue = New StringBuilder("")

            For Each itmSegment As MacroPDFSegmment In lstSegments.Where(Function(x) x.SegmentNo > 0).OrderBy(Function(x) x.SegmentNo)
                retValue.Append(itmSegment.SegmentValue)
            Next

            Return retValue.ToString()
        End Function

    End Class

    Public Class MacroPDFSegmment

        Public Sub New()
        End Sub

        Public Sub New(ByVal inpValue As String)
            If Not String.IsNullOrEmpty(inpValue) Then
                Segments = inpValue.Split("\"c)
            End If
        End Sub

        Private Property Segments As String()

        ''' <summary>
        ''' Get Segment Index
        ''' </summary>
        Public ReadOnly Property SegmentNo As Integer
            Get
                Dim retSegmentValue As Integer = -1
                Dim segmentVal = GetSegmentValue(2)

                If Not String.IsNullOrEmpty(segmentVal) Then
                    Integer.TryParse(segmentVal, retSegmentValue)
                End If

                Return retSegmentValue
            End Get
        End Property

        ''' <summary>
        ''' Get Segment Value
        ''' </summary>
        Public ReadOnly Property SegmentValue As String
            Get
                Return GetSegmentValue(1)
            End Get
        End Property

        ''' <summary>
        ''' Get Segment Value
        ''' </summary>
        Public Function GetSegmentValue(ByVal segmentNo As Integer) As String
            If Segments IsNot Nothing AndAlso Segments.Length >= segmentNo Then
                Return Segments(segmentNo - 1)
            End If

            Return ""
        End Function
    End Class


End Module
