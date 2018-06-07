//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
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
