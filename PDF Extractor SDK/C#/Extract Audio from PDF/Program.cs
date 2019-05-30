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
            // (!) We do not provide the sample document, please load your own.
            extractor.LoadDocumentFromFile(@"sample-audio.pdf");

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

			// Cleanup
			extractor.Dispose();
		}
	}
}
