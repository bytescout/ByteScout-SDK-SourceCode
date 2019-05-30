//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Text;
using Bytescout.PDFExtractor;

namespace ReadHindiText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Files
                string fileName = "hindiText.pdf";
                string destFileName = "extractedText.txt";

                //Read all text from pdf file
                using (TextExtractor extractor = new TextExtractor())
                {
                    // Load PDF document
                    extractor.LoadDocumentFromFile(fileName);

                    //Option 1: Extract all text and write to destination file
                    extractor.SaveTextToFile(destFileName, encoding: Encoding.Unicode);

                    Console.WriteLine("All extracted text (hindi) written successfully to destination text file.");

                    //Option 2: Read all text to string variable
                    //string allText = extractor.GetText();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
