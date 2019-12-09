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


using Bytescout.PDF;
using System;
using System.Diagnostics;

namespace RemovePdfProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Document pdfDocument = new Document())
                {
                    pdfDocument.RegistrationName = "demo";
                    pdfDocument.RegistrationKey = "demo";

                    pdfDocument.Load("sample.pdf");

                    Page page = pdfDocument.Pages[0];

                    // copy page content as template
                    GraphicsTemplate template = page.SaveAsTemplate();

                    // create new page of required size
                    Page newPage = new Page(PaperFormat.A4);
                    // draw the stored template on the new page with required offset
                    newPage.Canvas.DrawTemplate(template, 50, 50);

                    // replace the old page with the new one
                    pdfDocument.Pages.Remove(0);
                    pdfDocument.Pages.Add(newPage);
                    
                    //Save output file
                    pdfDocument.Save("result.pdf");
                }

                // Open result document in default associated application (for demo purpose)
                ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
                processStartInfo.UseShellExecute = true;
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
