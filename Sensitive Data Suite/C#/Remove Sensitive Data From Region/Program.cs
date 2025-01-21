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
using System.Diagnostics;
using System.Drawing;
using Bytescout.PDFExtractor;

namespace RemoveSensitiveDataFromRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.Remover instance
            Remover remover = new Remover("demo", "demo");

            // Load sample PDF document
            remover.LoadDocumentFromFile(@"sample1.pdf");

            // Remove text objects contained in the specified rectangle or intersecting with it.
            // NOTE: The removed text might be larger than the specified rectangle. Currently the Remover is unable 
            // to split PDF text objects.
            remover.RemoveText(0, new RectangleF(45f, 101f, 183f, 310f), @"result1.pdf");

            // Open output file in default application
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result1.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);

            // Clean up.
            remover.Dispose();
        }
    }
}
