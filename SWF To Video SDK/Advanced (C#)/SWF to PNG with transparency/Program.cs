//*******************************************************************
//       ByteScout SWF To Video SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. WHY? Because flash is not supported on x64 platform currently at all

using System.Diagnostics;
using BytescoutSWFToVideo;

namespace SwfToPng
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

            // Enable trasparency - BEFORE setting input file
            converter.RGBAMode = true;

            // set input SWF file
            converter.InputSWFFileName = "circles.swf";


			// Select 20th frame
			converter.StartFrame = 20;
			converter.StopFrame = 20;

			// Run conversion
			converter.ConvertToPNG("result.png");

			// Open the result in default application
			Process.Start("result.png");
		}
	}
}
