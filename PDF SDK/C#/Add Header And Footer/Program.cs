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
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;

namespace AddHeaderAndFooter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (Document doc = new Document())
                {
                    doc.RegistrationName = "demo";
                    doc.RegistrationKey = "demo";

                    doc.Load("sample.pdf");

                    // Prepare simple template (for example, a logo) and draw it on every page
                    // Create template of specified size
                    GraphicsTemplate headerTemplate = new GraphicsTemplate(250, 50);
                    headerTemplate.DrawString("Here is a header text", new Font(StandardFonts.CourierBold, 15), new SolidBrush(), 30, 10);

                    GraphicsTemplate footerTemplate = new GraphicsTemplate(250, 50);
                    footerTemplate.DrawString("Here is the footer text", new Font(StandardFonts.CourierBold, 15), new SolidBrush(), 30, 10);

                    // Write template in each pages
                    for (int i = 0; i < doc.Pages.Count; i++)
                    {
                        Page currentPage = doc.Pages[i];
                        currentPage.Canvas.DrawTemplate(headerTemplate, 40, 10);
                        currentPage.Canvas.DrawTemplate(footerTemplate, 350, (currentPage.Height - 40));
                    }

                    // Save output file
                    doc.Save("result.pdf");
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

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
