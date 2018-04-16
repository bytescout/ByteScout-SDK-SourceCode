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
using System.Diagnostics;
using BytescoutImageToVideo;

namespace AddImageFromBuffer
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

				// Add images from memory and set the duration for every slide:

				Slide slide;
				byte[] bytes;

				bytes = System.IO.File.ReadAllBytes("..\\..\\..\\..\\slide1.jpg");
				slide = converter.AddImageFromBuffer(bytes);
				slide.Duration = 3000;

				bytes = System.IO.File.ReadAllBytes("..\\..\\..\\..\\slide3.jpg");
				slide = converter.AddImageFromBuffer(bytes);
				slide.Duration = 3000;

				bytes = System.IO.File.ReadAllBytes("..\\..\\..\\..\\slide3.jpg");
				slide = converter.AddImageFromBuffer(bytes);
				slide.Duration = 3000;

				// Set output video size
				converter.OutputWidth = 640;
				converter.OutputHeight = 480;

				// Set output video file name
				converter.OutputVideoFileName = "result.wmv";

				// Run the conversion
				converter.RunAndWait();

				// Release resources
				System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
				converter = null;

				Console.WriteLine("Done. Press any key to continue..");
				Console.ReadKey();

				// Open the result video file in default media player
				Process.Start("result.wmv");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error: " + e.ToString());
				Console.WriteLine("\nPress any key to exit");
				Console.ReadKey();
			}
		}
	}
}
