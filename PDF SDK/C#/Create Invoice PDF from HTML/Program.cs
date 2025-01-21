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
using System.Drawing.Printing;
using Bytescout.PDF.Converters;

namespace Tables
{
    /// <summary>
    /// This example demonstrates how to create invoice from HTML.
    /// </summary>
    class Program
    {
        static void Main()
        {
            using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
            {
                converter.PageSize = PaperKind.Letter;
                converter.Orientation = PaperOrientation.Portrait;

                // Convert input HTML to output pdf
                converter.ConvertHtmlToPdf("invoice.html", "result.pdf");
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
