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
using Bytescout.PDFExtractor;

namespace MergeAllDocumentsWithinFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            var SourceFolder = "PDFDocs";
            var DestinationFile = "result.pdf";
            var IncludeSubFolder = true;

            using (DocumentMerger merger = new DocumentMerger("demo", "demo"))
            {
                merger.MergeFolder(SourceFolder, DestinationFile, IncludeSubFolder);
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo(DestinationFile);
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
