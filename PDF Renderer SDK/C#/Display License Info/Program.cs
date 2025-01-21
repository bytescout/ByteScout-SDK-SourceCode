//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDFRenderer;
using System;

namespace DisplayLicenseInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // LicenseInfo can be retrieved by createing instance of any renderer class,
            // Because all of them are derived from BaseRenderer
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Get License Info
            var licenseInfo = renderer.LicenseInfo;

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
