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

namespace ConvertSvgToPdf
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // HtmlToPdfConverter can convert HTML files with SVG content, or SVG files directly.
            using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
            {
                converter.PageSize = PaperKind.A4;
                
                converter.ConvertHtmlToPdf("drawing.svg", "result.pdf");
                
                // You can also pass a link instead of the input file:  
                //converter.ConvertHtmlToPdf("http://somesite.com/files/drawing.svg", "result.pdf");
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
