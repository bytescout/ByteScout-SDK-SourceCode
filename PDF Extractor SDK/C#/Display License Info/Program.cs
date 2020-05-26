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
using Bytescout.PDFExtractor;

namespace DisplayLicenseInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // LicenseInfo can be retrieved by createing instance of any extractor class,
            // Because all of them are derived from BaseExtractor
            TextExtractor extractor = new TextExtractor();
            extractor.RegistrationName = "demo";
            extractor.RegistrationKey = "demo";

            // Get License Info
            var licenseInfo = extractor.LicenseInfo;

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
