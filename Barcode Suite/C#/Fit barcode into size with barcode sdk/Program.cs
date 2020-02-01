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


using System.Diagnostics;
using Bytescout.BarCode;

namespace FitInto
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create new barcode
			Barcode barcode = new Barcode();

			// Set symbology
			barcode.Symbology = SymbologyType.Code39;
			// Set value
			barcode.Value = "Sample";

			// Specify barcode size by bounds to fit into.
			// You can use any measure units.
			barcode.FitInto(5, 3, UnitOfMeasure.Inch);

			// Save barcode to image
			barcode.SaveImage("result.png");

			// Show image in default image viewer
			Process.Start("result.png");
		}
	}
}
