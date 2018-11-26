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

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.html");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
