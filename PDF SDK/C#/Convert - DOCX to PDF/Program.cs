//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


using System.Diagnostics;
using System.Drawing.Printing;
using Bytescout.PDF.Converters;

namespace ConvertDocxToPdf
{
	class Program
	{
		static void Main(string[] args)
		{
			using (DocxToPdfConverter converter = new DocxToPdfConverter())
			{
				converter.PageSize = PaperKind.A4;
				converter.Orientation = PaperOrientation.Portrait;
				converter.Footer = "<p style=\"color: blue;\">FOOTER TEXT</p>";
				
				converter.ConvertDocxToPdf("sample.docx", "result.pdf");
			}

			// Open result file in default PDF viewer
			Process.Start("result.pdf");
		}
	}
}
