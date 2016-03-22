//*******************************************************************
//       ByteScout SWF To Video SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. 

using System.Diagnostics;
using BytescoutSWFToVideo;

namespace SwfWithDataToPng
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

			// Add SWF file
			converter.InputSWFFileName = "http://bytescout.com/demo/swfscout_VideoSample.swf";

			// Enable trasparency
			converter.RGBAMode = true;

			// Select 20th frame
			converter.StartFrame = 20;
			converter.StopFrame = 20;
			// Save it to file
			converter.ConvertToPNG("frame20.png");

			// Select 50th frame
			converter.StartFrame = 50;
			converter.StopFrame = 50;
			// Save it to file
			converter.ConvertToPNG("frame50.png");

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Open the result in default media player
			Process.Start("frame20.png");
		}
	}
}
