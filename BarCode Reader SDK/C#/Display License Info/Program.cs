//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.BarCodeReader;
using System;

namespace DisplayLicenseInfo
{
    class Program
    {

        static void Main()
        {
            // Create instance of Barcode Reader
            Reader reader = new Reader();
            reader.RegistrationName = "demo";
			reader.RegistrationKey = "demo";

            // Get License Info
            var licenseInfo = reader.LicenseInfo;

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

            // Cleanup
            reader.Dispose();

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
