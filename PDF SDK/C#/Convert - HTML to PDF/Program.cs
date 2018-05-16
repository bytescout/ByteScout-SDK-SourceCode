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
using System.Diagnostics;
using System.Drawing.Printing;
using Bytescout.PDF.Converters;

namespace ConvertHtmlToPdf
{
	class Program
	{
	    [STAThread]
        static void Main(string[] args)
		{
			using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
			{
				converter.PageSize = PaperKind.A4;
				converter.Orientation = PaperOrientation.Portrait;
				converter.Footer = "<p style=\"color: blue;\">FOOTER TEXT</p>";
				
				converter.ConvertHtmlToPdf("sample.html", "result.pdf");
				
				// You can also pass a link instead of the input file:  
				//converter.ConvertHtmlToPdf("http://google.com", "result.pdf");
			}

			// Open result file in default PDF viewer
			Process.Start("result.pdf");
		}
	}
}
