//*******************************************************************
//       ByteScout Image To Video SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Diagnostics;
using BytescoutImageToVideo;

namespace SetMp3Audiotrack
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


				// set input video file
				converter.InputVideoFileName = "..\\..\\..\\..\\input.wmv";

				// set input audio file
				converter.ExternalAudioTrackFromFileName = "..\\..\\..\\..\\11k16bitpcm.wav";

				// Set output video file name
				converter.OutputVideoFileName = "ReplacedAudio.wmv";

				// Run the conversion
				converter.RunAndWait();

				// Release resources
				System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);

				// Open the result video file in default media player
				Process.Start("ReplacedAudio.wmv");

				Console.WriteLine("Done. Press any key to continue...");
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
