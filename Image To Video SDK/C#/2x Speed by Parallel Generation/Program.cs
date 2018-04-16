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


// You can speed up the conversion using the following technique:
// 1) Generate video parts in parallel threads;
// 2) Combine these parts into final video.
// Let us say you have 20 slides.
// Then you can run a thread to convert 1-10 slides and another one to convert 11-20 slides.
// Finally combine these parts into a single one using .JoinWMVFiles(part1, part2, output) 
// or .JoingAVIFiles(part1, part2, output) functions.

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using BytescoutImageToVideo;

namespace MultiThreadProcessing
{
	class ThreadData
	{
		public string[] InputFiles;
		public string OutputFile;

		public ThreadData(string[] inputFiles, string outputFile)
		{
			InputFiles = inputFiles;
			OutputFile = outputFile;
		}
	}

	class Program
	{
		private static int _numBusy;
		private static ManualResetEvent _doneEvent;

		static void Main(string[] args)
		{
			_doneEvent = new ManualResetEvent(false);
			_numBusy = 2;

            // variable to store video file extension
            string sVideoFileExt;

            // are we using WMV or AVI video format for output
            bool isWMV = false;

            // if is WMV then use .wmv extension
            if (isWMV) 
            {
                sVideoFileExt = ".wmv";
            }
			else // else use AVI
            {
                sVideoFileExt = ".avi";
            }

			// Start two conversion threads
			Console.WriteLine("Start first thread...");
            ThreadData threadData1 = new ThreadData(new string[] { "slide1.jpg", "slide2.jpg", "slide3.jpg" }, "Part1" + sVideoFileExt);
			ThreadPool.QueueUserWorkItem(DoWork, threadData1);
			
			Console.WriteLine("Start second thread...");
            ThreadData threadData2 = new ThreadData(new string[] { "slide4.jpg", "slide5.jpg", "slide6.jpg" }, "Part2" + sVideoFileExt);
			ThreadPool.QueueUserWorkItem(DoWork, threadData2);
			
			// Wait for both threads finished
			_doneEvent.WaitOne();

			// Join generates parts
			Console.WriteLine("Join parts into the final video file...");
			ImageToVideo converter = new ImageToVideo();
            
			if (isWMV)
            {
                converter.JoinWMVFiles("Part1" + sVideoFileExt, "Part2" + sVideoFileExt, "Result" + sVideoFileExt);
            }
            else
            {
                converter.JoinAVIFiles("Part1" + sVideoFileExt, "Part2" + sVideoFileExt, "Result" + sVideoFileExt);
            }

			// Open the output video file in default media player
            Process.Start("Result" + sVideoFileExt);

			Console.WriteLine("Done. Press any key to continue...");
			Console.ReadKey();
		}

		static void DoWork(object data)
		{
			ThreadData threadData = (ThreadData) data;

			try
			{
				// Create BytescoutImageToVideoLib.ImageToVideo object instance
				ImageToVideo converter = new ImageToVideo();

				// Activate the component
				converter.RegistrationName = "demo";
				converter.RegistrationKey = "demo";

				// Add slides
				foreach (string file in threadData.InputFiles)
				{
					Slide slide = converter.AddImageFromFileName(file);
					slide.Duration = 3000; // 3000ms = 3s
					slide.Effect = SlideEffectType.seEaseIn;
				}

				// Set output video size
				converter.OutputWidth = 640;
				converter.OutputHeight = 480;

				// Set output video file name
				converter.OutputVideoFileName = threadData.OutputFile;

				// Run the conversion
				converter.RunAndWait();

				// Release resources
				Marshal.ReleaseComObject(converter);

				Console.WriteLine("Thread finished.");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			if (Interlocked.Decrement(ref _numBusy) == 0)
			{
				_doneEvent.Set();
			}
		}
	}
}
