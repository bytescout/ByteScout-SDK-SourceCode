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


// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. WHY? Because flash is not supported on x64 platform currently at all

using System;
using System.Diagnostics;
using System.Threading;
using BytescoutSWFToVideo;

namespace ConversionProgress
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an instance of SWFToVideo ActiveX object
			SWFToVideo converter = new SWFToVideo();

			// Set debug log
			//converter.SetLogFile("log.txt");

			// Register SWFToVideo
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";

			// Set the converter to the live data conversion mode
			// (it will fully load the embedded video stream before the conversion)
			converter.SWFConversionMode = SWFConversionModeType.SWFWithLiveData;

			// set input SWF file 
			converter.InputSWFFileName = "shapes.swf";

	        // set output AVI or WMV video filename
        	converter.OutputVideoFileName = "result.wmv";
		
			// Don't let it run infinitely
			converter.ConversionTimeOut = 5000; // 5000ms = 5 seconds 

			// set FPS 
			converter.FPS = 29.97f;

			// Set output movie dimensions 
			converter.OutputWidth = 320;
			converter.OutputHeight = 240;

			// Run the conversion
			converter.Run();

			// Show conversion progress:

			int i = 0;
			char[] spin = new char[] { '|', '/', '-', '\\' };

			while (!Console.KeyAvailable && converter.IsRunning)
			{
				float progress = converter.ConversionProgress;
				Console.WriteLine(String.Format("Converting images {0}% {1}", progress, spin[i++]));
				Console.CursorTop--;
				i %= 4;
				Thread.Sleep(50);
			}

			if (converter.IsRunning)
			{
				converter.Stop();
				Console.WriteLine("Conversion aborted by user.");
			}
			else
			{
				Console.WriteLine("Conversion competed successfully.");
			}

			// Open the result in default media player
			Process.Start("result.wmv");

			Console.WriteLine();
			Console.WriteLine("Hit any key...");
			Console.ReadKey();
		}
	}
}
