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
using System.Diagnostics;
using System.Drawing.Printing;
using Bytescout.PDF.Converters;

namespace ConvertSvgToPdf
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // HtmlToPdfConverter can convert HTML files with SVG content, or SVG files directly.
            using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
            {
                converter.PageSize = PaperKind.A4;
                
                converter.ConvertHtmlToPdf("drawing.svg", "result.pdf");
                
                // You can also pass a link instead of the input file:  
                //converter.ConvertHtmlToPdf("http://somesite.com/files/drawing.svg", "result.pdf");
            }

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
