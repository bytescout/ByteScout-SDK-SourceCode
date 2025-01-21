//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using System.Drawing.Printing;
using Bytescout.PDF.Converters;

// IMPORTANT: This functionality is outdated! Please try Web API version for better results. Free signup: https://pdf.co/
namespace ConvertDocxToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DocxToPdfConverter converter = new DocxToPdfConverter())
            {
                converter.PageSize = PaperKind.A4;
                converter.Orientation = PaperOrientation.Portrait;
                converter.Footer = "<p style=\"color: blue;\">FOOTER TEXT</p>";
                
                converter.ConvertDocxToPdf("sample.docx", "result.pdf");
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
