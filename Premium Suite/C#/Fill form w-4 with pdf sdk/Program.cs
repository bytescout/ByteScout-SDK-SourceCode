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
                               { "f1_01[0]", "John J" }, // FirstName and middle initial
                               { "f1_02[0]", "Smith" }, // LastName
                               { "f1_03[0]", "111-111-3333" }, // Security number
                               { "f1_04[0]", "12 Palm st., Hill Valley" }, // Home address
                               { "f1_05[0]", "CA 12345" }, // City, Town, State and ZIP
                               { "c1_1[1]", "True" }, // Married
                               { "f1_06[0]", "123" }, // Total number of allowance
                               { "f1_07[0]", "443.44" }, // Additional amount
                               { "f1_09[0]", "Google, Somewhere in CA" }, // Employer's name and address
                               { "f1_10[0]", "12-3-2012" }, // First date of employment
                               { "f1_11[0]", "EMP223344" } // Employer identification number
           };

            // Load PDF form
            Document pdfDocument = new Document(@".\W-4.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // Get first page
            Page page = pdfDocument.Pages[0];

            // Get widget by its name and change value
            foreach (KeyValuePair<string, object> keyValuePair in fieldMap)
            {
                Annotation annotation = page.Annotations[keyValuePair.Key];

                if (annotation is CheckBox)
                {
                    ((CheckBox)annotation).Checked = Convert.ToBoolean(keyValuePair.Value);
                }
                else if (annotation is EditBox)
                {
                    ((EditBox)annotation).Text = (string)keyValuePair.Value;
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
