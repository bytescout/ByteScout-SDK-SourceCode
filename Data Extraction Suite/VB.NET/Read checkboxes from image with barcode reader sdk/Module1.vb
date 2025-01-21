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
Imports Bytescout.BarCodeReader

Module Module1

    Sub Main()

        Dim ImageFile As String = "checkboxes-checked.png"

        Console.WriteLine("Reading checkboxes from image {0}", Path.GetFullPath(ImageFile))

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Enable check boxes recognition
        reader.BarcodeTypesToFind.Checkbox = True

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

        ' Find check boxes
        Dim barcodes = reader.ReadFrom(ImageFile)

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Found checkbox with type '{0}' and value '{1}'", barcode.Type, barcode.Value)
        Next

        ' Cleanup
        reader.Dispose()

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module
