//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using ByteScout.DocumentParser;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ExtractTextFromFoldableBrochure
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample document containing foldable PDF
            string sampleDocument = @".\SampleFoldable.pdf";

            // Sample template
            string sampleTemplate = @".\SampleFoldable.yml";

            // Output 
            var resFile = "result.txt";
            var sOutput = new StringBuilder(string.Empty);

            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                // Add sample template
                documentParser.AddTemplate(sampleTemplate);

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON);

                // Parse json to foldable structure
                var parsedRes = ParseJsonToFoldableStructure(jsonString);

                // Append all parts to return output
                sOutput.AppendLine(parsedRes.Part1);
                sOutput.AppendLine(parsedRes.Part2);
                sOutput.AppendLine(parsedRes.Part3);

                // Write output file
                File.WriteAllText(resFile, sOutput.ToString());

                Console.WriteLine($"Extracted text saved to {resFile}");

                // Open result file with default application
                Process.Start(resFile);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Parse Json to Foldable Structure
        /// </summary>
        static FoldableStructure ParseJsonToFoldableStructure(string jsonData)
        {
            // Get Object data from input file
            JObject jsonObj = JObject.Parse(jsonData);

            var oRet = new FoldableStructure();
            oRet.Part1 = Convert.ToString(jsonObj["fields"]["part1"]["value"]);
            oRet.Part2 = Convert.ToString(jsonObj["fields"]["part2"]["value"]);
            oRet.Part3 = Convert.ToString(jsonObj["fields"]["part3"]["value"]);

            return oRet;
        }
    }

    class FoldableStructure
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }
    }
}
