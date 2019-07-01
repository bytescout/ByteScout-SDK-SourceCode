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


// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode.

using System;
using System.IO;

using BytescoutSWFToVideo;

namespace SwfToPng
{
	public partial class _Default : System.Web.UI.Page
	{

		/*
		IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

		Temporary folder access is required for web application when you use ByteScout SDK in it.
		If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

		SOLUTION:

		If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

		If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

		In this case
		- check the User or User Group your web application is running under
		- then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
		- restart your web application and try again

		*/

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
