//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
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
