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
        #region Declarations

        private enum PageNoStyle
        {
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight
        }

        #endregion

        static void Main(string[] args)
        {
            try
            {
                using (Document doc = new Document())
                {
                    // Add registration keys
                    doc.RegistrationName = "demo";
                    doc.RegistrationKey = "demo";

                    // Load document
                    doc.Load("sample.pdf");

                    // Write template in each pages
                    for (int i = 0; i < doc.Pages.Count; i++)
                    {
                        Page currentPage = doc.Pages[i];
                        _AddPageNo(currentPage, "Page #" + (i + 1), PageNoStyle.BottomRight);
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
                Console.WriteLine("Press enter key to exit...");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Add Page No
        /// </summary>
        private static void _AddPageNo(Page currentPage, string pageNoText, PageNoStyle pageNoStyle)
        {
            float float_left = 10;
            float float_top = 10;

            switch (pageNoStyle)
            {
                case PageNoStyle.TopRight:
                    float_left = currentPage.Width - 60;
                    break;
                case PageNoStyle.BottomLeft:
                    float_top = currentPage.Height - 20;
                    break;
                case PageNoStyle.BottomRight:
                    float_top = currentPage.Height - 20;
                    float_left = currentPage.Width - 60;
                    break;
                case PageNoStyle.TopLeft:
                default:
                    break;
            }

            // Draw/Write page no
            currentPage.Canvas.DrawString(pageNoText,
                new Font(StandardFonts.CourierBold, 12),
                new SolidBrush(),
                float_left,
                float_top);
        }

    }
}
