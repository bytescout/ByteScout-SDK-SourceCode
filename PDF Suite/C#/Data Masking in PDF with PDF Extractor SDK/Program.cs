//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace RepairText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Generate CSVExtractor instance
                using (CSVExtractor extractor = new CSVExtractor("demo", "demo"))
                {
                    // Load PDF document
                    extractor.LoadDocumentFromFile("sample.pdf");

                    // Get all data
                    string allData = extractor.GetCSV();

                    // Regular expressions and replacements
                    string ssnRegex = @"\d{3}[-]?\d{2}[-]?\d{4}";
                    string ssnReplace = "***-**-****";

                    string phoneRegex = @"\d{3}[-]?\d{3}[-]?\d{4}";
                    string phoneReplace = "***-***-****";

                    // Find and mask SSN and phone numbers
                    allData = Regex.Replace(allData, ssnRegex , ssnReplace);
                    allData = Regex.Replace(allData, phoneRegex, phoneReplace);

                    // Write as CSV
                    File.WriteAllText("output.csv", allData);

                    // Open file
                    ProcessStartInfo processStartInfo = new ProcessStartInfo("output.csv");
                    processStartInfo.UseShellExecute = true;
                    Process.Start(processStartInfo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to close...");
            Console.ReadLine();
        }
    }
}
