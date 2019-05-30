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

namespace ReadForm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load PDF form
            Document pdfDocument = new Document(@"f1099int_filled.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Read from second page
            Page page = pdfDocument.Pages[1];

            Console.WriteLine("F1099int_filled Form values are as follows");

            // Is Void
            var lIsVoid = ((CheckBox)page.Annotations["c2_1[0]"]).Checked;
            Console.WriteLine($"Is Void: {lIsVoid}");

            // Payer's info
            var cPayerInfo = ((EditBox)page.Annotations["f2_1[0]"]).Text;
            Console.WriteLine($"Payer Info: {cPayerInfo}");

            // Payer's TIN
            var cPayerTin = ((EditBox)page.Annotations["f2_2[0]"]).Text;
            Console.WriteLine($"Payer TIN: {cPayerTin}");

            // Recipient's TIN
            var cRecipientTin = ((EditBox)page.Annotations["f2_4[0]"]).Text;
            Console.WriteLine($"Recipient TIN: {cRecipientTin}");

            // Street Address 1
            var cStreetAddress1 = ((EditBox)page.Annotations["f2_5[0]"]).Text;
            Console.WriteLine($"Street Address - 1: {cStreetAddress1}");

            // Street Address 2
            var cStreetAddress2 = ((EditBox)page.Annotations["f2_6[0]"]).Text;
            Console.WriteLine($"Street Address - 2: {cStreetAddress2}");

            // Cleanup 
            pdfDocument.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();
        }
    }
}
