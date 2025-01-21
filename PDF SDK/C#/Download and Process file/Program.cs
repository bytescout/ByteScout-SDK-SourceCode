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
using System.IO;

namespace RemovePdfProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Input file Url
                var inputUrl = @"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf";

                // Get Stream for input url
                var oInputStream = GetStreamFromUrl(inputUrl);

                using (Document doc = new Document())
                {
                    // Load input stream
                    doc.Load(oInputStream);

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

        /// <summary>
        /// Get stream from Url
        /// </summary>
        private static Stream GetStreamFromUrl(string url)
        {
            byte[] oData = null;

            using (var wc = new System.Net.WebClient())
                oData = wc.DownloadData(url);

            return new MemoryStream(oData);
        }


    }
}
