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
using Bytescout.PDF;

namespace TextFields
{
    /// <summary>
    /// This example demonstrates how text fields and theirs variations.
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

            // Add simple text field with default properties
            EditBox edit1 = new EditBox(20, 20, 120, 25, "editBox1");
            edit1.Text = "One two three";
            page.Annotations.Add(edit1);
            
            // Add password box
            EditBox edit2 = new EditBox(20, 50, 120, 25, "editBox2");
            edit2.Text = "password";
            edit2.Password = true;
            page.Annotations.Add(edit2);
            
            // Add multiline text field
            EditBox edit3 = new EditBox(20, 80, 120, 50, "editBox3");
            edit3.Multiline = true;
            edit3.Text = "The quick brown fox jumps over, the lazy dog.";
            page.Annotations.Add(edit3);
            
            // Demonstrate various decoration properties 
            EditBox edit4 = new EditBox(20, 135, 120, 30, "editBox4");
            edit4.Text = "Decorated text field";
            edit4.TextAlign = TextAlign.Right;
            edit4.BackgroundColor = new ColorRGB(255, 240, 240);
            edit4.BorderWidth = 2;
            edit4.BorderStyle = BorderStyle.Dashed;
            edit4.BorderColor = new ColorRGB(128, 0, 0);
            edit4.FontColor = new ColorRGB(128, 0, 0);
            edit4.Font.Size = 9;
            page.Annotations.Add(edit4);
            
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
