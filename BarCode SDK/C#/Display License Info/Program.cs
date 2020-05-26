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


using Bytescout.BarCode;
using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create barcode class instance
            Barcode barcode = new Barcode();
            barcode.RegistrationKey = "demo";
            barcode.RegistrationName = "demo";

            // Get License Info
            var licenseInfo = barcode.LicenseInfo;

            // Show Info
            Console.WriteLine("===============================");
            Console.WriteLine("======== License Info =========");
            Console.WriteLine("===============================\n");

            Console.WriteLine($"License type: {licenseInfo.LicenseType}");
            Console.WriteLine($"License limit type: {licenseInfo.LimitType}");
            Console.WriteLine($"Limit of license units: {licenseInfo.Limit}");
            Console.WriteLine($"License limit term: {licenseInfo.LimitTerm}");
            Console.WriteLine($"No of remaining license units: {licenseInfo.Remainder}");
            Console.WriteLine($"Update expires On: {licenseInfo.UpdatesExpireOn}");

            Console.ReadLine();
        }
    }
}
