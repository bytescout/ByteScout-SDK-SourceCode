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


using System.Diagnostics;
using Bytescout.PDF;

namespace CheckBoxes
{
    /// <summary>
    /// This example demonstrates how to create checkboxes.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";
            // Add page
            Page page = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page);

            // Add unchecked checkbox
            CheckBox checkBox1 = new CheckBox(20, 20, 15, 15, "checkBox1");
            page.Annotations.Add(checkBox1);
            
            // Add checked checkbox
            CheckBox checkBox2 = new CheckBox(20, 40, 15, 15, "checkBox2");
            checkBox2.Checked = true;
            page.Annotations.Add(checkBox2);
            
            // Add readonly checkbox
            CheckBox checkBox3 = new CheckBox(20, 60, 15, 15, "checkBox3");
            checkBox3.Checked = true;
            checkBox3.ReadOnly = true;
            page.Annotations.Add(checkBox3);
            
            // Draw text labels
            Font font = new Font(StandardFonts.Times, 12);
            Brush brush = new SolidBrush();
            page.Canvas.DrawString("Unchecked box", font, brush, 45, 20);
            page.Canvas.DrawString("Checked box", font, brush, 45, 40);
            page.Canvas.DrawString("Read-only checked box", font, brush, 45, 60);
            
            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
