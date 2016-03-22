//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using Bytescout.PDFExtractor;

namespace ExtractAudio
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

			// Initialize sound clips enumeration
			if (extractor.GetFirstAudio())
			{
				do
				{
					string outputFileName = "audio" + i + extractor.GetCurrentAudioExtension();

					// Save sound clip to file
					extractor.SaveCurrentAudioToFile(outputFileName);

					i++;

				}
				while (extractor.GetNextAudio()); // Advance sounds enumeration
			}
		}
	}
}
