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

' This example demonstrates the use of profiles. Profiles are set of properties 
' allowing to apply them to Reader in any combination quickly. You can use 
' predefined profiles or create you own in JSON format like in this example.

Class Program
    Friend Shared Sub Main(args As String())

        ' Create Bytescout.BarCodeReader.Reader instance
        Using reader As Reader = New Reader()

            reader.RegistrationName = "demo"
            reader.RegistrationKey = "demo"

            ' Apply predefined profiles:
            ' enable Code39;
            ' enable EAN-13;
            ' render PDF at 150 DPI resoultion.
            reader.Profiles = "code39, ean13, pdf150dpi"

            ' -----------------------------------------------------------------------
            ' NOTE: We can read barcodes from specific page to increase performance .
            ' For sample please refer to "Decoding barcodes from PDF by pages" program.
            ' ----------------------------------------------------------------------- 

            ' Decode and show barcodes from sample1.pdf
            reader.ReadFrom("sample1.pdf")
            For Each foundBarcode As FoundBarcode In reader.FoundBarcodes
                Console.WriteLine("Found ""{0}"" barcode with value ""{1}""", foundBarcode.Type, foundBarcode.Value)
            Next

        End Using

        Using reader As Reader = New Reader()

            reader.RegistrationName = "demo"
            reader.RegistrationKey = "demo"

            ' Load and apply custom profiles
            reader.LoadProfiles("profiles.json")
            reader.Profiles = "negative-distorted-datamatrix"

            ' Decode and show barcodes from sample2.png
            reader.ReadFrom("sample2.png")

            For Each foundBarcode As FoundBarcode In reader.FoundBarcodes
                Console.WriteLine("Found ""{0}"" barcode with value ""{1}""", foundBarcode.Type, foundBarcode.Value)
            Next

        End Using

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub
End Class
