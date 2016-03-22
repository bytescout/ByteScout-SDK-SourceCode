//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
