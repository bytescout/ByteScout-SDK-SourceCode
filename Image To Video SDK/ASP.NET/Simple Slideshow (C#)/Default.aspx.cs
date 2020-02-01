//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.Web.UI;
using BytescoutImageToVideo;
namespace SimpleSlideshow
{
	public partial class _Default : Page
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
			// These test files will be copied to the project directory on the pre-build event (see the project properties).
			String file1 = Server.MapPath("bin\\slide1.jpg");
            String file2 = Server.MapPath("bin\\slide2.jpg");
            String file3 = Server.MapPath("bin\\slide3.jpg");

			String outputVideoFile = Path.GetTempPath() + "result.wmv";

			// Create BytescoutImageToVideoLib.ImageToVideo object instance
			ImageToVideo converter = new ImageToVideo();

			// Activate the component
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";

			// Add images and set the duration for every slide
			Slide slide  = converter.AddImageFromFileName(file1);
			slide.Duration = 3000; // 3000ms = 3s
			slide = converter.AddImageFromFileName(file2);
			slide.Duration = 3000;
			slide = converter.AddImageFromFileName(file3);
			slide.Duration = 3000;

			// Set output video size
			converter.OutputWidth = 400;
			converter.OutputHeight = 300;

			// Set output video file name
			converter.OutputVideoFileName = outputVideoFile;

			// Run the conversion
			converter.RunAndWait();

			// Release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Show filename of result file

			Response.Clear();
			Response.ContentType = "text/html";

			if (File.Exists(outputVideoFile))
			{
				Response.Write("Result video file:  <b>" + outputVideoFile + "</b>");
			}
			else
			{
				Response.Write("Conversion failed. Error information: " + converter.LastError);
			}

			Response.End();
		}
	}
}
