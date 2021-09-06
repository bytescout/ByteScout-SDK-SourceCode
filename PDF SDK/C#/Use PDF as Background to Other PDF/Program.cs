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


using Bytescout.PDF;
using System;
using System.Diagnostics;

namespace UsePDFAsBkgdToOtrPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            var PDFSDK_RegName = "demo";
            var PDFSDK_RegKey = "demo";

            Document templateDoc = new Document { RegistrationName = PDFSDK_RegName, RegistrationKey = PDFSDK_RegKey };
            Document mainDoc = new Document { RegistrationName = PDFSDK_RegName, RegistrationKey = PDFSDK_RegKey };
            Document resultDoc = new Document { RegistrationName = PDFSDK_RegName, RegistrationKey = PDFSDK_RegKey };

            templateDoc.Load(@"./background.pdf");
            mainDoc.Load(@"./sample.pdf");

            // Create GraphicsTemplate object from the first page of the template document
            GraphicsTemplate template = templateDoc.Pages[0].SaveAsTemplate();
            
            for (int i = 0; i < mainDoc.Pages.Count; i++)
            {
                // Create empty page 
                Page resultPage = new Page(mainDoc.Pages[i].Width, mainDoc.Pages[i].Height);

                // Draw the template page as a background before the main content
                resultPage.Canvas.DrawTemplate(template, 0, 0);

                // Draw main content
                GraphicsTemplate mainContentAsTemplate = mainDoc.Pages[i].SaveAsTemplate();
                resultPage.Canvas.DrawTemplate(mainContentAsTemplate, 0, 0);
                
                // Add the created page to the result document
                resultDoc.Pages.Add(resultPage);
            }

            // Save result document
            resultDoc.Save(@"./result.pdf");

            resultDoc.Dispose();
            templateDoc.Dispose();
            mainDoc.Dispose();

            Console.WriteLine("Result file 'result.pdf' generated!");
            Process.Start(@"result.pdf");
            Console.ReadLine();
        }
    }
}
