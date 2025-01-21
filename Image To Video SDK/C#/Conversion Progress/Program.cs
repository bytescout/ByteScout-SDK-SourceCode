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
using System.Diagnostics;
using System.Threading;
using BytescoutImageToVideo;

namespace ConversionProgress
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Converting JPG slides to video, please wait...");

			// Create BytescoutImageToVideoLib.ImageToVideo object instance
			ImageToVideo converter = new ImageToVideo();

			// Activate the component
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";

			// Add images and set the duration for every slide
			Slide slide;
			slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide1.jpg");
			slide.Duration = 3000; // 3000ms = 3s
			slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide2.jpg");
			slide.Duration = 3000;
			slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide3.jpg");
			slide.Duration = 3000;

			// Set output video size
			converter.OutputWidth = 640;
			converter.OutputHeight = 480;

			// Set output video file name
			converter.OutputVideoFileName = "result.wmv";

			Console.WriteLine("Conversion started. Hit a key to abort...");

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

			// Release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);

			// Open the result video file in default media player
			Process.Start("result.wmv");

			Console.WriteLine("\nPress any key to exit...");
			Console.ReadKey();
		}
	}
}
