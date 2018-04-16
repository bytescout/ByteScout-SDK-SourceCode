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


using System.Diagnostics;
using Bytescout.PDF.Converters;

namespace ConvertDocxToHtml
{
	class Program
	{
		static void Main(string[] args)
		{
			using (DocxToHtmlConverter converter = new DocxToHtmlConverter())
			{
				converter.IndentHtmlCode = true;
				converter.WriteByteOrderMark = true;
				
				converter.ConvertDocxToHtml("sample.docx", "result.html", true);
			}

			// Open result file in default browser
			Process.Start("result.html");
		}
	}
}
