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


using System;
using System.Diagnostics;
using Bytescout.PDF;

namespace SubmitFormActionExample
{
    /// <summary>
    /// This example demonstrates how to submit or reset form.
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

            // Create sample form

            Font font = new Font(StandardFonts.Times, 14);
            Brush brush = new SolidBrush();
            // EditBox
            EditBox editBox = new EditBox(20, 20, 100, 25, "editBox1");
            editBox.Text = "editBox1";
            page.Annotations.Add(editBox);
            // CheckBox
            CheckBox checkBox = new CheckBox(20, 60, 15, 15, "checkBox1");
            page.Annotations.Add(checkBox);
            page.Canvas.DrawString("CheckBox", font, brush, 45, 60);

            // Add Submit button
            PushButton submitButton = new PushButton(20, 120, 80, 25, "buttonSubmit");
            submitButton.Caption = "Submit";
            page.Annotations.Add(submitButton);
            // Add action
            SubmitFormAction submitAction = new SubmitFormAction(new Uri("http://login.live.com"));
            submitAction.SubmitFormat = SubmitDataFormat.HTML;
            submitAction.SubmitMethod = SubmitMethod.Get;
            submitAction.Fields.Add(editBox);
            submitAction.Fields.Add(checkBox);
            submitButton.OnActivated = submitAction;

            // Add Reset button
            PushButton resetButton = new PushButton(120, 120, 80, 25, "butonReset");
            resetButton.Caption = "Reset";
            page.Annotations.Add(resetButton);
            // Add action
            ResetFormAction resetAction = new ResetFormAction();
            resetAction.Fields.Add(editBox);
            resetAction.Fields.Add(checkBox);
            resetButton.OnActivated = resetAction;
            
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
