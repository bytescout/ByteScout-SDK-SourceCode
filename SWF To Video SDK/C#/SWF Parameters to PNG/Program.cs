//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. 
using System.Diagnostics;
using BytescoutSWFToVideo;

namespace SwfParametersToPng
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

			// Set a value for the variable
			// (!) You should call SetVariable() before SetMovie()
			converter.SetVariable("Variable1", "hi this is passed variable");

			// Enable trasparency - BEFORE setting input SWF file
			converter.RGBAMode = true;

			// set input SWF file
			converter.InputSWFFileName = "MovieDisplayPassedVar.swf";

			// Select first frame
			converter.StartFrame = 0;
			converter.StopFrame = 0;

			// Run conversion
			converter.ConvertToPNG("result.png");

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Open the result in default application
			Process.Start("result.png");
		}
	}
}
