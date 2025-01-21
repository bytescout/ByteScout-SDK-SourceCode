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

using Bytescout.PDFRenderer;


namespace SilentPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PrinterName = "Microsoft Print to PDF";

            // Create an instance of Bytescout.PDFRenderer.DocumentPrinter object and register it.
            DocumentPrinter documentPrinter = new DocumentPrinter();
            documentPrinter.RegistrationName = "demo";
            documentPrinter.RegistrationKey = "demo";

            // Load PDF document.
            documentPrinter.LoadDocumentFromFile("multipage.pdf");

            // Change some printing options for demo purposes 
            // (note, some options might be not supported by the printer):

            // Change paper orientation
            documentPrinter.Landscape = true;
            // Set number of copies
            documentPrinter.Copies = 2;
            // Set collation
            documentPrinter.Collate = true;
            // Force black and white printing
            documentPrinter.Color = false;

            // Print all document pages to the specified printer
            documentPrinter.PrintDocument(PrinterName);

            // To print specific pages use overridden methods allowing to define pages to print:
            //documentPrinter.PrintDocument(PrinterName, 2, 4); // printer pages from 3 to 5
            //documentPrinter.PrintDocument(PrinterName, new int[] {0, 2, 3, 4, 6}); // print specific pages
            //documentPrinter.PrintDocument(PrinterName, "1,3-5,7-");

            documentPrinter.Dispose();
        }
    }
}
