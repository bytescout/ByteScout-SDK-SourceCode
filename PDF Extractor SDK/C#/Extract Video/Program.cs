//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


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
            extractor.LoadDocumentFromFile(@"sample.pdf");

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
        }
    }
}
