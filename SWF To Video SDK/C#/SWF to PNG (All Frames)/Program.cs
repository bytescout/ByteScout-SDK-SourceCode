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

namespace SwfToPngAll
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
			converter.InputSWFFileName = "Shapes.swf";

			// Enable trasparency
			converter.RGBAMode = true;

			// Extract all frames to .\Output sub-folder
			converter.ConvertAllToPNG(".\\Output");

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Open the first extracted frame in default application
			Process.Start("frame0.png");
		}
	}
}
