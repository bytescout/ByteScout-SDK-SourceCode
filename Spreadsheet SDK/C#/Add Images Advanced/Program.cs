//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.MSODrawing;

namespace AddImages
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create spreadsheet
			Spreadsheet doc = new Spreadsheet();
			// Add worksheet
			Worksheet worksheet = doc.Worksheets.Add();

			// Put an image to "C3" cell
			PictureShape shape = worksheet.Pictures.Add(2, 2, "image1.jpg");

            // Make the picture "floating". It will be not moved if you move or resize the "C3" cell
			shape.PlacementType = Placement.FreeFloating;

			// Make the picture brighter
			shape.Brightness = 0.8f;

			// Put second image to "K11" cell
			shape = worksheet.Pictures.Add(10, 10, "image2.jpg");

			// Make the picture bound to the cell. It will be moved alonf with the "K11" cell
			shape.PlacementType = Placement.Move;

			// Crop 10% from left and right side of the image
			shape.CropFromLeft = 0.1f;
			shape.CropFromRight = 0.1f;

			// Delete output file if exists
			if (File.Exists("output.xls"))
			{
				File.Delete("output.xls");
			}

			// Save document
			doc.SaveAs("output.xls");

			// Close spreadsheet
			doc.Close();

			// Open generated XLS document in default application
			Process.Start("output.xls");

			doc.Dispose();
		}
	}
}
