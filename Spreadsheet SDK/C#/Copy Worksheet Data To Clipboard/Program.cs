//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.Spreadsheet;
using System;
using System.IO;
using System.Text;

namespace CopyWorksheetDataToClipboard
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            // Spreadsheet document
            using (Spreadsheet document = new Spreadsheet())
            {
                // Load Input File
                document.LoadFromFile("SimpleReport.xls");

                // Create stream and export CSV data to stream
                MemoryStream ms = new MemoryStream();
                document.Worksheets[0].SaveAsCSV(ms, "\t");

                // Convert memory stream to string
                var tabSeparatedData = Encoding.UTF8.GetString(ms.ToArray());

                // Copy data to clipboard
                System.Windows.Forms.Clipboard.SetText(tabSeparatedData);
            }

            Console.WriteLine("Data copied to clipboard!");
            Console.ReadLine();
        }
    }
}
