//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using Bytescout.BarCode;

namespace SaveToNewPDF
{
	class Program
	{
		static void Main()
		{
            // Create new barcode and register it.
            Barcode barcode = new Barcode();
			barcode.RegistrationName = "demo";
			barcode.RegistrationKey = "demo";

            // Set symbology
            barcode.Symbology = SymbologyType.DataMatrix;
            // Set value
            barcode.Value = "Sample barcode";

			// Place barcode at top-right corner of document page
			barcode.DrawToNewPDF("barcode.pdf", 595,842, 500, 50);
			
            // Open output file in default PDF viewer
            System.Diagnostics.Process.Start("barcode.pdf");
		}
	}
}
