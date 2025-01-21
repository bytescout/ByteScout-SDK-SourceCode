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
using Bytescout.PDF.Converters;

namespace ConvertHtmlToDocx
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HtmlToDocxConverter converter = new HtmlToDocxConverter())
            {
                converter.ConvertHtmlToDocx("sample.html", "result.docx");
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.docx");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
