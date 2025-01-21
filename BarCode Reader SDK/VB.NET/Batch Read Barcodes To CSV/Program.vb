'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.BarCodeReader

Module Program

    Sub Main()

        Try
            'Read Barcode Process
            Dim reader As Reader = New Reader
            reader.RegistrationKey = "demo"
            reader.RegistrationName = "demo"

            ' Set Barcode type to find
            reader.BarcodeTypesToFind.SetAll()

            ' Output list
            Dim lstCSVOutput As New List(Of CSVOutputFormat)

            ' Get all files in folder, and iterate through each file
            Dim files = System.IO.Directory.GetFiles("BarcodeFiles")
            For Each fileName As String In files

                ' -----------------------------------------------------------------------
                ' NOTE: We can read barcodes from specific page to increase performance .
                ' For sample please refer to "Decoding barcodes from PDF by pages" program.
                ' ----------------------------------------------------------------------- 

                ' Read barcodes
                Dim FoundBarcodes As FoundBarcode() = reader.ReadFrom(fileName)

                For Each code As FoundBarcode In FoundBarcodes
                    lstCSVOutput.Add(
                        New CSVOutputFormat With {
                        .barcodeType = code.Type.ToString(),
                        .barcodeValue = code.Value,
                        .scanDateTime = DateTime.Now.ToString(),
                        .fileName = fileName
                        })
                Next

            Next

            Console.WriteLine("Total {0} barcode found in {1} file.", lstCSVOutput.Count, files.Length)

            ' Export to CSV
            ExportToCsv(lstCSVOutput)
			
			' Cleanup
			reader.Dispose()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("Press enter key to exit...")
        Console.ReadLine()

    End Sub

    Sub ExportToCsv(ByVal lstCSVOutput As List(Of CSVOutputFormat))

        Dim csvOutputContent As New System.Text.StringBuilder(String.Empty)

        csvOutputContent.Append("Barcode Value,Barcode Type,Scan DateTime,File Name")

        For Each item As CSVOutputFormat In lstCSVOutput

            csvOutputContent.AppendFormat("{0}{1},{2},{3},{4}",
                                          Environment.NewLine,
                                          item.barcodeValue,
                                          item.barcodeType,
                                          item.scanDateTime,
                                          item.fileName
                                          )

        Next

        System.IO.File.WriteAllText("output.csv", csvOutputContent.ToString())

        Process.Start("output.csv")

    End Sub


    Class CSVOutputFormat
        Public Property barcodeValue As String
        Public Property barcodeType As String
        Public Property scanDateTime As String
        Public Property fileName As String
    End Class

End Module
