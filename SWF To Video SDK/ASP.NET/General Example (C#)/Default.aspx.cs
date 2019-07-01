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
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing;
using System.Diagnostics;
using System.IO;

using BytescoutSWFToVideo;

namespace Simple
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

	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			String inputSwfFile = Server.MapPath("SlideShowWithEffects.swf");
			String outputAviFile = Path.GetTempPath() + "result.avi";

			// Create an instance of SWFToVideo ActiveX object
			SWFToVideo converter = new SWFToVideo();

			// Set debug log
			//converter.SetLogFile("log.txt");

			// Register SWFToVideo
			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";

			// set input SWF file
			converter.InputSWFFileName = inputSwfFile;

	        	// set output AVI video filename
        		converter.OutputVideoFileName = outputAviFile;

			// Set output movie dimensions
			converter.OutputWidth = 640;
			converter.OutputHeight = 480;

			// Run conversion
			converter.RunAndWait();

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(converter);
			converter = null;


			// Show filename of result file

			Response.Clear();
			Response.ContentType = "text/html";
			
			Response.Write("Result video file:  <b>" + outputAviFile + "</b>");

			Response.End();
		}
	}
}
