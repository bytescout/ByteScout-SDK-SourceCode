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

			// Enable trasparency - set BEFORE setting swf filename
			converter.RGBAMode = true;

			// set input SWF file
			converter.InputSWFFileName = "Shapes.swf";

			// Select 20th frame
			converter.StartFrame = 20;
			converter.StopFrame = 20;
			
			// set output large image size
			converter.OutputWidth = 2500;
			converter.OutputHeight = 2500;

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
