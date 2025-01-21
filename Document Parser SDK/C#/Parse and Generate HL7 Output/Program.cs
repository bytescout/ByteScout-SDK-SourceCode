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
using ByteScout.DocumentParser;

// This example demonstrates document data parsing to JSON, YAML and XML formats.

namespace HL7CreationFromJson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Generate Parse PDF File With Template and Generate Json
            string inputPDF = "InputData/Test_Report_Format.pdf";
            string template = "InputData/TestReportFormat.yml";

            // Create Document Parser Instance
            DocumentParser docParser = new DocumentParser("demo", "demo");

            // Add Template
            docParser.AddTemplate(template);

            // Parse document data in JSON format
            string jsonString = docParser.ParseDocument(inputPDF, OutputFormat.JSON);

            // Step 2: Parse Json fileds in class format
            var oInpModel = JsonParserHelper.ParseJsonHL7Fields(jsonString);

            // Step 3: Get Data in HL7 Format
            var oHL7Format = Hl7Helper.GetHL7Format(oInpModel);

            // Store HL7 File and open with default associated program
            var outputFile = "outputHl7.txt";
            System.IO.File.WriteAllText(outputFile, oHL7Format);
            Process.Start(outputFile);
        }
    }
}
