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

// IMPORTANT: This functionality is outdated! Please try Web API version for better results. Free signup: https://pdf.co/
namespace ConvertDocxToHtml
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DocxToHtmlConverter converter = new DocxToHtmlConverter())
            {
                converter.IndentHtmlCode = true;
                converter.WriteByteOrderMark = true;
                
                converter.ConvertDocxToHtml("sample.docx", "result.html", true);
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.html");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
