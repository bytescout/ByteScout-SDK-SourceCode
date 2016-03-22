//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.IO;
using System.Text;
using Bytescout.PDFExtractor;
using System.Drawing;
using System.Diagnostics;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            TextExtractor extractor = new TextExtractor("demo", "demo");

            // load the document
            extractor.LoadDocumentFromFile("../../sample2.pdf");

            // get page count
            int pageCount = extractor.GetPageCount();
            int count = 0;

            // iterate through pages
            for (int i = 0; i < pageCount; i++)
            {

                // define rectangle location to extract from
                RectangleF location = new RectangleF(0, 0, 200, 200);
                
                // set extraction area
                extractor.SetExtractionArea(location);

                // extract text bounded by the extraction area
                string extractedString = extractor.GetTextFromPage(i);
                
                Console.WriteLine("Extracted from page #" + i + ":\r\n" + extractedString);

                // reset extraction area to full page (by default)
                extractor.ResetExtractionArea();

                Console.WriteLine("\r\n");
            }



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
