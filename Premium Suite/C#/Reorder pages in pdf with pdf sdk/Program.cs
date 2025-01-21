//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDF;
using System;
using System.Diagnostics;

namespace RemovePdfProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Document doc = new Document())
                {
                    doc.Load("sample.pdf");

                    // Swap first and second pages:
                    Page tmp = doc.Pages[1];
                    doc.Pages.Remove(1);
                    doc.Pages.Insert(0, tmp);

                    //Save output file
                    doc.Save("result.pdf");
                }

                // Open result document in default associated application (for demo purpose)
                ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
                processStartInfo.UseShellExecute = true;
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
