//*******************************************************************
//       ByteScout Image To Video SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
			String file1 = Server.MapPath("slide1.jpg");
			String file2 = Server.MapPath("slide2.jpg");
			String file3 = Server.MapPath("slide3.jpg");

			String outputVideoFile = Path.GetTempPath() + "result.wmv";

			// Create BytescoutImageToVideoLib.ImageToVideo object instance
			ImageToVideo converter = new ImageToVideo();

			// Activate the component
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";

			// Add images and set the duration for every slide
			Slide slide;
			slide = (Slide) converter.AddImageFromFileName(file1);
			slide.Duration = 3000; // 3000ms = 3s
			slide = (Slide) converter.AddImageFromFileName(file2);
			slide.Duration = 3000;
			slide = (Slide) converter.AddImageFromFileName(file3);
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
