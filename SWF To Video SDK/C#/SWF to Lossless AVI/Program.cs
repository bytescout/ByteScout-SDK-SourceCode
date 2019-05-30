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

using System.Diagnostics;
using BytescoutSWFToVideo;

namespace SwfToLosslessAvi
{
	class Program
	{
		static void Main(string[] args)
		{
			// Please make sure the Bytescout Lossless Video Codec is installed on the computer 
			// Bytescout lossless video codec is available for free from 
			// http://bytescout.com/lossless_video_codec_for_avi.html


			// Create an instance of SWFToVideo ActiveX object
			SWFToVideo converter = new SWFToVideo();

			// Set debug log
			//converter.SetLogFile("log.txt");

			// Register SWFToVideo
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";

			// Set empty video codec name to get the output video uncompressed
			converter.CurrentVideoCodecName = "bytescout lossless";

			// set input SWF file
			converter.InputSWFFileName = "Shapes.swf";

			// you may calculate output video duration using information about the the source swf movie
			// WARNING #1: this method to calculate the output video duration is not working for movies with dynamic scenes 
			// and interactive scripts as in these movies it is not possible to calculate the precise duration of the movie 
			// WARNING #2: you should set the input swf or flv filename (or url) before this calculation

			// So the movie duration is calculated as the following:
			// as swf frame count (number of frames in the swf) / movieFPS (frames per second defined in swf)
			// and then multiplied by 1000 (as we are setting the .ConverstionTimeout in milliseconds)
			// as the following (uncomment if you want to set the length of the output video to the same as the original swf)
			// or as the following source code (uncomment to enable):

			// converter.ConversionTimeout = 1000 * (converter.FrameCount / converter.MovieFPS)


	        	// set output AVI video filename
        		converter.OutputVideoFileName = "result.avi";

			
			// Set output movie dimensions
			converter.OutputWidth = 320;
			converter.OutputHeight = 240;

			// Run conversion
			converter.RunAndWait();

			// Open the result movie in default media player
			Process.Start("result.avi");
		}
	}
}
