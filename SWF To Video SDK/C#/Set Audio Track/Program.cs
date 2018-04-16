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


// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. 

using System.Diagnostics;
using BytescoutSWFToVideo;

namespace SetAudioTrack
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

			// set input SWF file
			converter.InputSWFFileName = "SlideShowWithEffects.swf";
			// set output AVI video filename
			converter.OutputVideoFileName = "result.avi";


			// Set background music
			converter.ExternalAudioTrackFromFileName = "bgmusic.mp3";
			// Set output audio codec
			converter.CurrentAudioCodecName = "ADPCM";

			// Set output movie dimensions
			converter.OutputWidth = 640;
			converter.OutputHeight = 480;

			// Run conversion
			converter.RunAndWait();

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Open the result movie in default media player
			Process.Start("result.avi");
		}
	}
}
