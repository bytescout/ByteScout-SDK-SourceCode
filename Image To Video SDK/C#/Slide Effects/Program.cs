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
using BytescoutImageToVideo;

namespace SlideEffects
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
          		Console.WriteLine("Converting JPG slides to video, please wait...");

				// Create BytescoutImageToVideoLib.ImageToVideo object instance
				ImageToVideo converter = new ImageToVideo();

				// Activate the component
				converter.RegistrationName = "demo";
				converter.RegistrationKey = "demo";

				// Add images and set slide durations and effects
				Slide slide;
				slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide1.jpg");
				slide.Duration = 3000; // 3000ms = 3s
				slide.VisualEffect = VisualEffectType.veGrayscale; // make the slide grayscale
				slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide2.jpg");
				slide.Duration = 3000;
				slide.VisualEffect = VisualEffectType.veSepia; // make the slide sepia
				slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide3.jpg");
				slide.Duration = 3000;
				slide.RotationAngle = RotationAngle.raRotate90; // rotate the slide 90 degrees.
				
				// Set output video size
				converter.OutputWidth = 640;
				converter.OutputHeight = 480;

				// Set output video file name
				converter.OutputVideoFileName = "result.wmv";

				// Run the conversion
				converter.RunAndWait();

				// Release resources
				System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);

				// Open the result video file in default media player
				Process.Start("result.wmv");

				Console.WriteLine("Done. Press any key to continue..");
		        Console.ReadKey();
            }
            catch(Exception e)
			{
                Console.WriteLine("Error: " + e.ToString());
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
            }
		}
	}
}
