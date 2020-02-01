//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright Â© 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Diagnostics;
using Bytescout.PDF;

namespace FillFormExample
{
    /// <summary>
    /// This example demonstrates how to fill PDF form programmatically.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Map of form fields and sample values to set
            Dictionary<string, object> fieldMap = new Dictionary<string, object>()
            {
               { "c2_1[0]", true }, // VOID
               { "c2_1[1]", true }, // CORRECTED
               { "f2_1[0]", "John Smith, 12 Palm st., Hill Valley, CA 12345" }, // PAYER’S name, street address, city or town, ...
               { "f2_2[0]", "123456" }, // PAYER’S TIN
               { "f2_3[0]", "234567" }, // RECIPIENT’S TIN 
               { "f2_4[0]", "John Doe" }, // RECIPIENT’S name
               { "f2_5[0]", "23 Elm st., 345" }, // Street address (including apt. no.)
               { "f2_6[0]", "Hill Valley, CA 12345" }, // City or town, state or province, country, and ZIP or foreign postal code
               { "c2_2[0]", true }, // FATCA filing requirement
               { "f2_7[0]", "345678" }, // Account number (see instructions)
               { "f2_8[0]", "456789" }, // Payer's RTN (optional)
               { "f2_9[0]", "1000.00" }, // 1 Interest income
               { "f2_10[0]", "11.00" }, // 2 Early withdrawal penalty
               { "f2_11[0]", "12.00" }, // 3 Interest on U.S. Savings Bonds and Treas. obligations
               { "f2_12[0]", "13.00" }, // 4 Federal income tax withheld
               { "f2_13[0]", "14.00" }, // 5 Investment expenses
               { "f2_14[0]", "15.00" }, // 6 Foreign tax paid
               { "f2_15[0]", "16.00" }, // 7 Foreign country or U.S. possession
               { "f2_16[0]", "17.00" }, // 8 Tax-exempt interest
               { "f2_17[0]", "18.00" }, // 9  Specified private activity bond interest
               { "f2_18[0]", "19.00" }, // 10 Market discount
               { "f2_19[0]", "20.00" }, // 11 Bond premium
               { "f2_20[0]", "21.00" }, // 12 Bond premium on Treasury obligations
               { "f2_21[0]", "22.00" }, // 13 Bond premium on tax-exempt bond 
               { "f2_22[0]", "567890" }, // 14 Tax-exempt and tax credit bond CUSIP no.
               { "f2_23[0]", "AA" }, // 15 State [field 1] 
               { "f2_24[0]", "BB" }, // 15 State [field 2]
               { "f2_25[0]", "33" }, // 16 State identification no. [field 1]
               { "f2_26[0]", "44" }, // 16 State identification no. [field 2]
               { "f2_27[0]", "30.00" }, // 17 State tax withheld [field 1]
               { "f2_28[0]", "40.00" } // 17 State tax withheld [field 2]
            };
            
            // Load PDF form
            Document pdfDocument = new Document(@".\f1099int.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Get second page ("Copy 1")
            Page page = pdfDocument.Pages[1];

            // Get widget by its name and change value
            foreach (KeyValuePair<string, object> keyValuePair in fieldMap)
            {
                Annotation annotation = page.Annotations[keyValuePair.Key];

                if (annotation is CheckBox)
                {
                    ((CheckBox) annotation).Checked = (bool) keyValuePair.Value;
                }
                else if (annotation is EditBox)
                {
                    ((EditBox) annotation).Text = (string) keyValuePair.Value;
                }
            }

            // Save modified document
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
