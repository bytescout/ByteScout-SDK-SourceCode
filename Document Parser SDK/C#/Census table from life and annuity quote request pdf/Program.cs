//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using ByteScout.DocumentParser;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LifeAndAnnuityQuoteRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample document containing life and annuity quote request form
            string sampleDocument = @".\SampleGroupDisabilityForm.pdf";

            // Sample template
            string sampleTemplate = @".\SampleGroupDisabilityForm.yml";

            // Create DocumentParser instance
            using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
            {
                // Add sample template
                documentParser.AddTemplate(sampleTemplate);

                // Parse document data in JSON format
                string jsonString = documentParser.ParseDocument(sampleDocument, OutputFormat.JSON);

                // Parse to Json Fields
                var oRet = ParseJsonFields(jsonString);

                // Display some of data to console
                Console.WriteLine("Parsing Details:\n------------------------");

                Console.WriteLine($"Contact Person: {oRet.ContactPerson}");
                Console.WriteLine($"Business Name: {oRet.BusinessName}");
                Console.WriteLine($"Business Address: {oRet.BusinessAddress}");
                Console.WriteLine($"Business Type: {oRet.BusinessType}");
                Console.WriteLine($"Phone: {oRet.Phone}");
                Console.WriteLine($"Email: {oRet.Email}");

                // Export list of census to csv format
                var csvOutputFile = "result.csv";

                var csvString = ConvertToCsv(oRet.lstCensusTable);
                File.WriteAllText(csvOutputFile, csvString);

                Console.WriteLine($"\n{csvOutputFile} generated successfully!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Parser Json Fields
        /// </summary>
        public static FormVM ParseJsonFields(string jsonInput)
        {
            JObject jsonObj = JObject.Parse(jsonInput);

            var oRet = new FormVM();
            oRet.ContactPerson = Convert.ToString(jsonObj["fields"]["contactPerson"]["value"]);
            oRet.BusinessName = Convert.ToString(jsonObj["fields"]["businessName"]["value"]);
            oRet.BusinessAddress = Convert.ToString(jsonObj["fields"]["businessAddress"]["value"]);
            oRet.BusinessType = Convert.ToString(jsonObj["fields"]["businessType"]["value"]);
            oRet.Phone = Convert.ToString(jsonObj["fields"]["phone"]["value"]);
            oRet.Email = Convert.ToString(jsonObj["fields"]["email"]["value"]);

            var censusTable = jsonObj["tables"].Where(x => x.Value<string>("name") == "CencusTable");

            if(censusTable != null)
            {
                var rows = censusTable.Values("rows").First();

                if(rows != null && rows.Count() > 1)
                {

                    for (int i = 1; i < rows.Count(); i++)
                    {
                        var oCensus = new CensusTableVm();
                        
                        // Parser individual data
                        oCensus.SrNo = rows.ElementAt(i).ElementAt(0).ElementAt(0).Value<string>("value");
                        oCensus.DOB = rows.ElementAt(i).ElementAt(1).ElementAt(0).Value<string>("value");
                        oCensus.Gender = rows.ElementAt(i).ElementAt(2).ElementAt(0).Value<string>("value");
                        oCensus.Occupation = rows.ElementAt(i).ElementAt(3).ElementAt(0).Value<string>("value");
                        oCensus.Salary = rows.ElementAt(i).ElementAt(4).ElementAt(0).Value<string>("value");
                        oCensus.IsShortTermDisability = rows.ElementAt(i).ElementAt(5).ElementAt(0).Value<string>("value");
                        oCensus.IsLongTernDisability = rows.ElementAt(i).ElementAt(6).ElementAt(0).Value<string>("value");
                        oCensus.LifeInsuCoverAmt = rows.ElementAt(i).ElementAt(7).ElementAt(0).Value<string>("value");

                        oRet.lstCensusTable.Add(oCensus);
                    }
                }
            }

            return oRet;
        }

        /// <summary>
        /// Convert to Csv Format
        /// </summary>
        public static string ConvertToCsv(List<CensusTableVm> lstCensusTable)
        {
            var oRet = new StringBuilder(string.Empty);

            // Get Header Row
            oRet.AppendLine(CensusTableVm.getCsvTitleRow());

            // Put Child Rows
            foreach (var item in lstCensusTable)
            {
                oRet.AppendLine(item.ToString());
            }

            return oRet.ToString();
        }

    }

    class FormVM
    {
        public string ContactPerson { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessType { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<CensusTableVm> lstCensusTable { get; set; } = new List<CensusTableVm>();
    }

    class CensusTableVm
    {
        public string SrNo { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Salary { get; set; }
        public string IsShortTermDisability { get; set; }
        public string IsLongTernDisability { get; set; }
        public string LifeInsuCoverAmt { get; set; }

        public override string ToString()
        {
            return $"{SrNo},{DOB},{Gender},{Occupation},{Salary},{IsShortTermDisability},{IsLongTernDisability},{LifeInsuCoverAmt}";
        }

        public static string getCsvTitleRow()
        {
            return $"SrNo,DOB,Gender,Occupation,Salary,IsShortTermDisability,IsLongTermDisability,LifeInsuCoverAmt";
        }

    }

}
