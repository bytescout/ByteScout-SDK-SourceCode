//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFExtractor;
using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDocument = Path.GetFullPath(@".\UnicodeSample.pdf");
            string csvFilePath = Path.ChangeExtension(inputDocument, ".csv");
            string csvFileName = Path.GetFileName(csvFilePath);
            string csvDirectory = Path.GetDirectoryName(Path.GetFullPath(csvFilePath));

            // Create Bytescout.PDFExtractor.CSVExtractor instance
            using (CSVExtractor extractor = new CSVExtractor("demo", "demo"))
            {
                extractor.LoadDocumentFromFile(inputDocument);

                extractor.CSVSeparatorSymbol = ",";

                string csvText = extractor.GetCSV();
            
                // Save csv text in UTF-8 encoding without BOM (byte order mark):
                File.WriteAllText(csvFilePath, csvText);
            }

            // Please Note: Target the project to x86 because Microsoft.Jet.OLEDB.4.0 driver is 32-bit only.
            using (OleDbConnection connection = new OleDbConnection($@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""{csvDirectory}"";Extended Properties=""Text;FMT=$;HDR=No;CharacterSet=65001"""))
            {
                using (OleDbCommand command = new OleDbCommand($"select * from [{csvFileName}]", connection))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        table.Locale = CultureInfo.CurrentCulture;
                        adapter.Fill(table);

                        Console.WriteLine($"Loaded {table.Rows.Count} lines.");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
