//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.IO;
using Bytescout.Watermarking;
using Bytescout.Watermarking.Presets;

namespace ProgressIndicator
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Watermarker instance
			Watermarker waterMarker = new Watermarker();

			// Initialize library
			waterMarker.InitLibrary("demo", "demo");

			// Add images to apply watermarks to
			waterMarker.AddInputFile("image1.jpg", "image1_watermarked.jpg");
			waterMarker.AddInputFile("image2.jpg", "image2_watermarked.jpg");
			waterMarker.AddInputFile("image3.jpg", "image3_watermarked.jpg");
				
			// Create new watermark
			TextFitsPage preset = new TextFitsPage();

			// Set watermark text
			preset.Text = "My Watermark (c) Me 2010";

			// Add watermark to watermarker
			waterMarker.AddWatermark(preset);

			// Add Progress event handler
			waterMarker.Progress += new ProgressEventHandler(waterMarker_Progress);

			// Apply watermarks
			waterMarker.Execute();

			Console.WriteLine();
			Console.WriteLine("Hit any key...");
			Console.ReadKey();
		}

		static void waterMarker_Progress(double percent, string status, string processedFile, ref bool abort)
		{
			string message;

			if (!String.IsNullOrEmpty(processedFile))
			{
				message = String.Format("{0}: {1}: {2:f02}%", Path.GetFileName(processedFile), status, percent);
			}
			else
			{
				message = String.Format("{0}: {1:f02}%", status, percent);
			}

			Console.WriteLine(message.PadRight(Console.WindowWidth));
		}
	}
}
