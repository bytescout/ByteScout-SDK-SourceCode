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
using System.Text;
using System.Xml;
using Bytescout.BarCodeReader;

namespace ExportResults
{
    class Program
    {
        static void Main()
        {
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

            // Set barcode type to find
            reader.BarcodeTypesToFind.All1D = true;

            /* -----------------------------------------------------------------------
            NOTE: We can read barcodes from specific page to increase performance.
            For sample please refer to "Decoding barcodes from PDF by pages" program.
            ----------------------------------------------------------------------- */

            // Read barcodes
            reader.ReadFromFile("barcodes.pdf");


            // Export to files:
            // ================

            // 1. Export found barcodes to XML
            reader.ExportFoundBarcodesToXML("barcodes.xml");

            // 2a. Export found barcodes to CSV with default delimiter, quotation and character encoding
            reader.ExportFoundBarcodesToCSV("barcodes.csv");

            // 2b. Export found barcodes to CSV with custom delimiter, quotation and character encoding
            reader.ExportFoundBarcodesToCSV("barcodes2.csv", "|", "'", Encoding.UTF8);

            // 3a. Export found barcodes to plain text file in default character encoding
            reader.ExportFoundBarcodesToTXT("barcodes.txt");

            // 3b. Export only values of found barcodes to plain text file in custom character encoding
            reader.ExportFoundBarcodesToTXT("barcodes2.txt", true, Encoding.ASCII);


            // Get formatted result to a variable for further processing
            // =========================================================

            // 1a. Get found barcodes as XmlDocument
            XmlDocument xmlDocument = reader.ExportFoundBarcodesToXMLDocument();

            // 1b. Get found barcodes as XML string
            string xmlString = reader.ExportFoundBarcodesToXML();

            // 2a. Get found barcodes as string in CSV format with default delimiter and quotation
            string csv = reader.ExportFoundBarcodesToCSV();

            // 2b. Get found barcodes as string in CSV format with custom delimiter and quotation
            string csv2 = reader.ExportFoundBarcodesToCSV("|", "'");

            // 3. Get found barcodes as string in plain text format
            string txt = reader.ExportFoundBarcodesToTXT();

            // 4. Get found barcodes as string in JSON format
            string jsonString = reader.ExportFoundBarcodesToJSON();
			
			// Cleanup
			reader.Dispose();
        }
    }
}
