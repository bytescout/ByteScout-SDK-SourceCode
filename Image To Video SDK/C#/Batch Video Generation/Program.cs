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
using BytescoutImageToVideo;

namespace BatchVideoGeneration
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
            	Console.WriteLine("Converting JPG slides to video, please wait...");

				for (int i = 0; i < 5; i++)
				{
					// Create BytescoutImageToVideoLib.ImageToVideo object instance
					ImageToVideo converter = new ImageToVideo();

					// Activate the component
					converter.RegistrationName = "demo";
					converter.RegistrationKey = "demo";

					// Set output video size
					converter.OutputWidth = 640;
					converter.OutputHeight = 480;

					// Add images and set duration and effects for every slide
					Slide slide;
					slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide1.jpg");
					slide.Duration = 3000; // 3000ms = 3s
					slide.InEffect = TransitionEffectType.teFade;
					slide.OutEffect = TransitionEffectType.teFade;
					Release(slide); // useful to decrease memory consumption during the batch conversion but not critical

					slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide2.jpg");
					slide.Duration = 3000;
					slide.InEffect = TransitionEffectType.teWipeLeft;
					slide.OutEffect = TransitionEffectType.teWipeRight;
					Release(slide);

					slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide3.jpg");
					slide.Duration = 3000;
					slide.InEffect = TransitionEffectType.teWipeLeft;
					slide.OutEffect = TransitionEffectType.teWipeRight;
					Release(slide);

					// Set output video file name
					converter.OutputVideoFileName = "result" + i + ".wmv";

					// Run the conversion
					converter.RunAndWait();

					Console.WriteLine("Created " + converter.OutputVideoFileName);

					// CRITICAL! 
					// Releases all resources consumed during the conversion
					Release(converter);
				}

				Console.WriteLine("Done. Press any key to continue..");
				Console.ReadKey();
			}
			catch (Exception e)
			{
                Console.WriteLine("Error: " + e.ToString());
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey();
            }
		}

		static void Release(object o)
		{
			try
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(o);
			}
			catch
			{
			}
			finally
			{
				o = null;
			}
		}
	}
}
