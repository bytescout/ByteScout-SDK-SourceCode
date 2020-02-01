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

namespace ExtractVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.MultimediaExtractor instance
            MultimediaExtractor extractor = new MultimediaExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";
            
            // Load PDF document
            // (!) We do not provide the sample document, please load your own.
            extractor.LoadDocumentFromFile(@"sample-video.pdf");

            int i = 0;

            // Initialize movies enumeration
            if (extractor.GetFirstVideo())
            {
                do
                {
                    string outputFileName = "movie" + i + extractor.GetCurrentVideoExtension();

                    // Save movie to file
                    extractor.SaveCurrentVideoToFile(outputFileName);

                    i++;

                } 
                while (extractor.GetNextVideo()); // Advance movies enumeration
            }

            // Cleanup
			extractor.Dispose();
        }
    }
}
