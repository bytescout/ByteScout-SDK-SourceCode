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
using Bytescout.PDFExtractor;

namespace DetectLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.LineDetector instance
            LineDetector lineDetector = new LineDetector();
            lineDetector.RegistrationName = "demo";
            lineDetector.RegistrationKey = "demo";
            
            // Load sample PDF document
            lineDetector.LoadDocumentFromFile(@".\sample2.pdf");

            FoundLinesCollection foundLines = lineDetector.FindLines(1, LineOrientationsToFind.HorizontalAndVertical);

            Console.WriteLine("Number of lines found: " + foundLines.Count);
            
            for (int i = 0; i < foundLines.Count; i++)
            {
                FoundLine line = foundLines[i];

                Console.WriteLine("Line # " + i);
                
                // Line Orientation
                Console.WriteLine("LineOrientation: " + line.LineOrientation);

                // Starting point of the line
                Console.WriteLine("From point: " + line.From);

                // Ending point of the line
                Console.WriteLine("To point: " + line.To);

                // Line width
                Console.WriteLine("Width: " + line.Width);
            }

            Console.ReadLine();
        }
    }
}
