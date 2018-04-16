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


using System;
using System.Drawing;
using System.IO;
using System.Web.UI;
using Bytescout.Watermarking;
using Bytescout.Watermarking.Presets;

namespace HelloWorld
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Create Watermarker instance
			Watermarker waterMarker = new Watermarker();

			// Initialize library
			waterMarker.InitLibrary("demo", "demo");

			// Set input file name
			string inputFilePath = MapPath("my_sample_image.jpg");

			// Create sample input stream
			Stream inputStream = new FileStream(inputFilePath, FileMode.Open);
			// Create image from stream
			Image image = new Bitmap(inputStream);

			// Add image to apply watermarks to
			waterMarker.AddInputFile(image);

			// Create watermark
			TextFitsPage preset = new TextFitsPage();
			preset.Text = "Bytescout Watermarking";
			preset.TextColor = Color.Aqua;
			preset.Transparency = 25;

			// Add watermark to Watermarker
			waterMarker.AddWatermark(preset);

			// Clear http output
			Response.Clear();
			// Set the content type to JPEG
			Response.ContentType = "image/jpeg";
			// Add content type header
			Response.AddHeader("Content-Type", "image/jpeg");
			// Set the content disposition
			Response.AddHeader("Content-Disposition", "inline;filename=my_sample_image.jpg");

			// Set Response.OutputStream as result image destination
			waterMarker.OutputOptions.OutputStream = Response.OutputStream;

			// Execute watermarking
			waterMarker.Execute(0);

			// Cleanup
			image.Dispose();
			inputStream.Dispose();

			Response.End();
		}
	}
}
