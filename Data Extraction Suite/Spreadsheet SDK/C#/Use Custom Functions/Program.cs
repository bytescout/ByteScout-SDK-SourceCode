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

using Bytescout.Spreadsheet;

namespace CustomFunctions
{
    /// <summary>
    /// This example demonstrates the calculation of custom functions.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create Spreadsheet instance
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.RegistrationName = "demo";
            spreadsheet.RegistrationKey = "demo";

            // Load document
            spreadsheet.LoadFromFile(@"CustomFuncExample.xlsx");

            // Add custom formula handler
            spreadsheet.CustomFunctionsCallback = new CustomFunctionsCallback(MyFunctions);
            
            // Calculate the first worksheet
            Worksheet worksheet = spreadsheet.Workbook.Worksheets[0];
            worksheet.Calculate();

            // Save calculated values to neighbor cells to demonstrate custom functions are calculated
            worksheet["C2"].Value = worksheet["B2"].Value;
            worksheet["C3"].Value = worksheet["B3"].Value;
            worksheet["C4"].Value = worksheet["B4"].Value;

            // Save modified spreadsheet
            spreadsheet.SaveAs(@"result.xlsx");

            // Cleanup
            spreadsheet.Dispose();

            // Open saved spreadsheet in associated application (for demo purpose)
            Process.Start("result.xlsx");
        }

        public static object MyFunctions(string funcName, object[] args, ref bool handled)
        {
            // Handle "CUSTOMFUNC_FACTORIAL" function
            if (String.Compare(funcName, "CUSTOMFUNC_FACTORIAL", StringComparison.OrdinalIgnoreCase) == 0)
            {
                handled = true;

                // Compute factorial
                if (args.Length > 0)
                {
                    int value = (int)(double) args[0];

                    if (value == 0 || value == 1)
                        return 1;

                    int f = 1;
                    for (int i = 1; i <= value; i++)
                        f = f * i;

                    return f;
                }

                return null;
            }

            // Handle "CUSTOMFUNC_SUM" function
            if (string.Compare(funcName, "CUSTOMFUNC_SUM", StringComparison.OrdinalIgnoreCase) == 0)
            {
                handled = true;

                // Compute the sum of values
                if (args.Length > 0)
                {
                    double sum = 0;
                    foreach (var o in args)
                        sum += (double)o;

                    return sum;
                }

                return null;
            }

            return null;
        }
    }
}
