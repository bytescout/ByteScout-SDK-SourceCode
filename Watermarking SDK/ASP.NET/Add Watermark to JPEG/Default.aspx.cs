//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Drawing;
using System.Web.UI;
using Bytescout.Watermarking;
using Bytescout.Watermarking.Presets;

namespace HelloWorld
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
			// Create Watermarker instance
			Watermarker waterMarker = new Watermarker();

			// Initialize library
			waterMarker.InitLibrary("demo", "demo");

			// Set input file name
			string inputFilePath = MapPath("my_sample_image.jpg");

			// Add image to apply watermarks to
			waterMarker.AddInputFile(inputFilePath);

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

			Response.End();
		}
	}
}
