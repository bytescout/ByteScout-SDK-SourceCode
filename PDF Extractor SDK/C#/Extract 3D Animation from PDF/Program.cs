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

namespace Extract3DAnimation
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
            extractor.LoadDocumentFromFile(@"sample.pdf");

            int i = 0;

            // Initialize 3D animations enumeration
            if (extractor.GetFirst3D())
            {
                do
                {
                    string outputFileName = "3d_animation" + i + extractor.GetCurrent3DExtension();

                    // Save 3D animation to file
                    extractor.SaveCurrent3DToFile(outputFileName);

                    i++;
                } 
                while (extractor.GetNext3D()); // Advance enumeration
            }

            // Cleanup
			extractor.Dispose();
        }
    }
}
