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
using System.Diagnostics;
using Bytescout.BarCode;

namespace QRCodeWithCalenderEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create new barcode
                using (Barcode barcode = new Barcode())
                {
                    // Set symbology
                    barcode.Symbology = SymbologyType.QRCode;

                    // Get QRCode value in CalenderEntry format
                    barcode.Value = GetCalenderEntryFormatText();

                    // Save barcode to image
                    barcode.SaveImage("result.png");
                }

                // Show image in default image viewer
                Process.Start("result.png");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

                Console.WriteLine("Press enter key to exit...");
                Console.ReadLine();
            }

        }

        /// <summary>
        /// Return Calender Entry Format
        /// </summary>
        /// <returns></returns>
        private static string GetCalenderEntryFormatText()
        {
            return @"BEGIN:VCALENDAR
BEGIN:VEVENT
DTSTART:20181113T100000Z
DTEND:20181113T150000Z
SUMMARY:New Calendar Entry
DESCRIPTION:Description Text
LOCATION:Chicago
RRULE:FREQ=YEARLY;BYDAY=-1SU;BYMONTH=3
END:VEVENT
END:VCALENDAR";
        }

    }
}
