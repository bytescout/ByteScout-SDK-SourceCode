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

using System;
using System.IO;

using BytescoutSWFToVideo;

namespace SwfToPng
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			String inputSwfFile = Server.MapPath("Shapes.swf");

			// Create an instance of SWFToVideo ActiveX object
			SWFToVideo converter = new SWFToVideo();

			// Set debug log
			//converter.SetLogFile("log.txt");

			// Register SWFToVideo
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";


			// Enable trasparency - set BEFORE setting SWF filename
			converter.RGBAMode = true;

			// set input SWF file
			converter.InputSWFFileName = inputSwfFile;


			// Select the frame to extract (20th)
			converter.StartFrame = 20;
			converter.StopFrame = 20;

			// Run conversion.
			// Empty parameter means conversion to binary stream instead of file.
			converter.ConvertToPNG("");

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Display the extracted image:

			Response.Clear();
			// Add content type header 
			Response.ContentType = "image/png";
			// Set the content disposition 
			Response.AddHeader("Content-Disposition", "inline;filename=result.png");

			// Write the image bytes into the Response output stream 
			Response.BinaryWrite((byte[]) converter.BinaryImage);
			
			Response.End();
		}
	}
}
