//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
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
            extractor.LoadDocumentFromFile(@".\audio.pdf");

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
