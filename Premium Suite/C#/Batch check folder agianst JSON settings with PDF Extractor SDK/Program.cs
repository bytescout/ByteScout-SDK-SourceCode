//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using BatchCheckFolderAgainstJsonSettings;
using Bytescout.PDFExtractor;
using Newtonsoft.Json;
using System;
using System.IO;

namespace FindUsAddressRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Get all settings VM
                var allSettings = GetSettingsVM("settings.json");

                // Create Bytescout.PDFExtractor.TextExtractor instance
                TextExtractor extractor = new TextExtractor();
                extractor.RegistrationName = "demo";
                extractor.RegistrationKey = "demo";

                foreach (var fileName in Directory.GetFiles("InputFiles"))
                {
                    // Load sample PDF document
                    extractor.LoadDocumentFromFile(fileName);

                    // Enable regex search
                    extractor.RegexSearch = true;

                    // Get Number of pages PDF contains
                    int pageCount = extractor.GetPageCount();

                    for (int iPage = 0; iPage < pageCount; iPage++)
                    {
                        // Loop through all search settings
                        foreach (var itmSearchSetting in allSettings.Settings)
                        {
                            // If found, then copy file to sub-category folder
                            if(extractor.Find(iPage, itmSearchSetting.regex, false))
                            {
                                // If Directory does not exists, then create them
                                if (!Directory.Exists($"{allSettings.MainFolderName}/{itmSearchSetting.category}"))
                                {
                                    Directory.CreateDirectory($"{allSettings.MainFolderName}/{itmSearchSetting.category}");
                                }

                                // Copy File
                                File.Copy(fileName, $"{allSettings.MainFolderName}/{itmSearchSetting.category}/{Path.GetFileName(fileName)}", true);
                            }
                        }
                    }
                }
				
				// Cleanup
				extractor.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Get Settings VM
        /// </summary>
        private static SettingsVM GetSettingsVM(string settingsFileName)
        {
            var allJson = File.ReadAllText(settingsFileName);

            return JsonConvert.DeserializeObject<SettingsVM>(allJson);
        }
    }
}
