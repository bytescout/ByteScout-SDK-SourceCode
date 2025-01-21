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

        ' Replace barcode input file path here
        Const InputFile As String = "InputBarcodeImage.jpg"

        Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(InputFile))

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Set barcode type to find
        reader.BarcodeTypesToFind.PDF417 = True

        ' -----------------------------------------------------------------------
        ' NOTE: We can read barcodes from specific page to increase performance .
        ' For sample please refer to "Decoding barcodes from PDF by pages" program.
        ' ----------------------------------------------------------------------- 

        ' Read barcodes
        Dim barcodes As FoundBarcode() = reader.ReadFrom(InputFile)

        If barcodes.Length > 0 Then

            Dim barcode As FoundBarcode = barcodes(0)

            ' Get specific fields

            Dim identificationCard As IdentificationCard = barcode.Metadata

            If Not identificationCard Is Nothing Then

                Console.WriteLine("ID Numer: " + identificationCard.IdNumber)
                Console.WriteLine("First Name: " + identificationCard.Name.First)
                Console.WriteLine("Middle Name: " + identificationCard.Name.Middle)
                Console.WriteLine("Last Name: " + identificationCard.Name.Last)
                Console.WriteLine("Sex: " + identificationCard.Sex.ToString())
                Console.WriteLine("Date Of Birth: " + identificationCard.DateOfBirth)
                Console.WriteLine("Address: " + identificationCard.Address.ToString())

                If TypeOf identificationCard Is DriversLicense Then
                    Dim driverLicense As DriversLicense = identificationCard

                    Console.WriteLine("Vehicle Class: " + driverLicense.Jurisdiction.VehicleClass)
                    Console.WriteLine("Endorsement Codes: " + driverLicense.Jurisdiction.EndorsementCodes)
                    Console.WriteLine("Restriction Codes: " + driverLicense.Jurisdiction.RestrictionCodes)
                End If

            Else
                Console.WriteLine("Could not retrieve AAMVA data from this barcode. Raw value: " + Environment.NewLine + barcode.Value)
            End If

            ' ... Or get the full information as JSON
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "-----------------" + Environment.NewLine)

            Dim jsonString = reader.ExportFoundBarcodesToJSON()
            Console.WriteLine(jsonString)

        Else
            Console.WriteLine("No barcodes found!")
        End If

        ' Cleanup
        reader.Dispose()

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module
