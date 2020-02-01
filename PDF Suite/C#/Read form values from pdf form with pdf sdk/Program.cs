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

namespace ReadForm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load PDF form
            Document pdfDocument = new Document(@"form.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            Page page = pdfDocument.Pages[0];

            // Get widget by its name and get value
            string box1 = ((EditBox) page.Annotations["editBox1"]).Text;
            string box2 = ((EditBox) page.Annotations["editBox2"]).Text;
            bool checkBox1 = ((CheckBox) page.Annotations["checkBox1"]).Checked;

            // Cleanup 
            pdfDocument.Dispose();

            // Writing values to console
            Console.WriteLine("Form values are as follows:");
            Console.WriteLine(box1);
            Console.WriteLine(box2);
            Console.WriteLine(checkBox1);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();
        }
    }
}
