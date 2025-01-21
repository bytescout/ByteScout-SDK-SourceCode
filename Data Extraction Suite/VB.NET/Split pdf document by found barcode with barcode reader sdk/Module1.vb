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
Imports System.Text
Imports Bytescout.BarCodeReader

Module Module1

    Sub Main()

        Const inputFile As String = "Barcodes.pdf"

        Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(inputFile))

        ' Create Bytescout.BarCodeReader.Reader instance
        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Set barcode type to find
        reader.BarcodeTypesToFind.Code39 = True

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

        ' Find barcode in PDF document
        reader.ReadFrom(inputFile)


        ' Method 1: Split PDF document in two parts by found barcode
        ' NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only

        reader.SplitDocument("barcodes.pdf", "part1.pdf", "part2.pdf", reader.FoundBarcodes(0).Page + 1)


        ' Method 2: Extract page containing the barcode from PDF document
        ' NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only

        reader.ExtractPageFromDocument("barcodes.pdf", "extracted_page.pdf", reader.FoundBarcodes(0).Page + 1)


        ' Method 3: Split PDF document into parts in one pass.
        ' NOTE: In Full version of the SDK this method is unlocked in "PRO" license type only.

        Dim pageRanges As StringBuilder = New StringBuilder()

        ' Create string containing page ranges to extract in the form "1-4,6-8,10-11,12-". Page numbers are 1-based!
        For i As Integer = 0 To reader.FoundBarcodes.Length - 1

            Dim barcode As FoundBarcode = reader.FoundBarcodes(i)

            ' Add pages before the first barcode found
            If i = 0 And barcode.Page > 0 Then
                pageRanges.Append("1")
                If barcode.Page > 1 Then
                    pageRanges.Append("-")
                    pageRanges.Append(barcode.Page)
                End If
                pageRanges.Append(",")
            End If

            ' Add page with barcode
            pageRanges.Append(barcode.Page + 1) ' +1 because we skip the page with barcode and another +1 because need 1-based page numbers

            ' Add range untill the next barcode
            If i < reader.FoundBarcodes.Length - 1 Then
                If reader.FoundBarcodes(i + 1).Page - barcode.Page > 1 Then
                    pageRanges.Append("-")
                    pageRanges.Append(reader.FoundBarcodes(i + 1).Page)
                End If
                pageRanges.Append(",")
            Else
                ' for the last found barcode add ending "-" meaning "to the last page"
                pageRanges.Append("-")
            End If
        Next

        ' Split document 
        Dim splittedParts As String() = reader.SplitDocument("barcodes.pdf", pageRanges.ToString())
        ' The method returns array of file names. Rename files as desired.

        ' Cleanup
        reader.Dispose()

        For Each fileName As String In splittedParts
            Console.WriteLine(fileName)
        Next

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

End Module
