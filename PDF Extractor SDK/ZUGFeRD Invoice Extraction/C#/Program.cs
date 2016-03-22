//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDFExtractor;

namespace ExtractInfo
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Bytescout.PDFExtractor.AttachmentExtractor instance
			AttachmentExtractor extractor = new AttachmentExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
			extractor.LoadDocumentFromFile("Beispielrechnung_ZUGFeRD_RC_COMFORT_neu.pdf");

			// extracting XML invoice which is stored as an attachment
			for (int i = 0; i < extractor.Count; i++)
			{
				Console.WriteLine("Saving XML invoice attachment:\t" + extractor.GetFileName(i));
				
				// save file into the current folder
				extractor.Save(i, extractor.GetFileName(i));

				Console.WriteLine("Done.");
			}

			
			Console.WriteLine();
			Console.WriteLine("Press any key to open the XML invoice extracted...");
			Console.ReadLine();


		        // Open the invoice in default XML viewer
		        System.Diagnostics.Process.Start("ZUGFeRD-invoice.xml");



		}
	}
}
