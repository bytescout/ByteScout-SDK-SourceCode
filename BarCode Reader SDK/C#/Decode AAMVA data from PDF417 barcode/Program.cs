//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using Bytescout.BarCodeReader;

namespace ReadAAMVAInformation
{
    class Program
    {
        // Replace barcode input file path here
        const string InputFile = "InputBarcodeImage.jpg";

        static void Main()
        {
            Console.WriteLine("Reading barcode(s) from image {0}", Path.GetFullPath(InputFile));

            Reader reader = new Reader();
            reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

            // Set barcode type to find
            reader.BarcodeTypesToFind.PDF417 = true;

            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */

            // Read barcodes
            FoundBarcode[] barcodes = reader.ReadFrom(InputFile);

            if(barcodes.Length > 0)
            {
                FoundBarcode barcode = barcodes[0];

                // Get specific fields:

                IdentificationCard identificationCard = barcode.Metadata as IdentificationCard;

                if (identificationCard != null)
                {
                    Console.WriteLine("ID Numer: " + identificationCard.IdNumber);
                    Console.WriteLine("First Name: " + identificationCard.Name.First);
                    Console.WriteLine("Middle Name: " + identificationCard.Name.Middle);
                    Console.WriteLine("Last Name: " + identificationCard.Name.Last);
                    Console.WriteLine("Sex: " + identificationCard.Sex);
                    Console.WriteLine("Date Of Birth: " + identificationCard.DateOfBirth);
                    Console.WriteLine("Address: " + identificationCard.Address);

                    if (identificationCard is DriversLicense)
                    {
                        DriversLicense driverLicense = (DriversLicense)identificationCard;

                        Console.WriteLine("Vehicle Class: " + driverLicense.Jurisdiction.VehicleClass);
                        Console.WriteLine("Endorsement Codes: " + driverLicense.Jurisdiction.EndorsementCodes);
                        Console.WriteLine("Restriction Codes: " + driverLicense.Jurisdiction.RestrictionCodes);
                    }
                }
                else
                {
                    Console.WriteLine("Could not retrieve AAMVA data from this barcode. Raw value: \r\n" + barcode.Value);
                }

                // ... or get the full information as JSON:
                Console.WriteLine("\n\n-----------------\n");

                string jsonString = reader.ExportFoundBarcodesToJSON();
                Console.WriteLine(jsonString);
            }
            else
            {
                Console.WriteLine("No barcodes found!");
            }

			// Cleanup
			reader.Dispose();

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
