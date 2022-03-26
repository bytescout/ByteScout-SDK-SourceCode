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


using Microsoft.SharePoint;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ByteScout.DocumentParser;
using System.Text;

namespace ExtractDataWebPart.VisualWebPart1
{
    /// <summary>
    /// Extract data from PDF invoices using PDF.co Document 
    /// Parser (and its default invoice parser template) 
    /// on a SharePoint folder and then put them back
    /// as CSV files on the same SharePoint folder.
    /// </summary>
    public partial class VisualWebPart1UserControl : UserControl
    {
        public SPWeb CurrentWeb { get; set; }

        // Destination PDF file name
        const string DestinationLibName = "Shared Documents";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void StartButton_Click(object sender, EventArgs e)
        {
            //string DestinationLibName = FolderTextBox.Text;

            SPSite site = SPContext.Current.Site;
            SPWeb web = CurrentWeb;

            SPSecurity.RunWithElevatedPrivileges(delegate ()
            {
                using (SPSite ElevatedSite = new SPSite(site.ID))
                {
                    using (SPWeb ElevatedWeb = ElevatedSite.OpenWeb(web.ID))
                    {
                        ConvertDocuments(ElevatedWeb);
                    }
                }
            });


            LogTextBox.Text += "\n";
            LogTextBox.Text += "Done...\n";
        }

        private void ConvertDocuments(SPWeb web)
        {
            try
            {
                var spLibrary = web.Folders[DestinationLibName];
                var spfileColl = spLibrary.Files;

                foreach (SPFile file in spfileColl)
                {
                    string inputDocument = file.Name;
                    // Create InvoiceParser instance
                    using (DocumentParser documentParser = new DocumentParser("demo", "demo"))
                    {
                        // Add an internal generic template for typical invoices.
                        // Note, if it does not parse all required fields, you should create
                        // own template using Template Editor application.
                        documentParser.AddTemplate("internal://invoice");

                        LogTextBox.Text += $"Parsing \"{inputDocument}\"...";
                        Console.WriteLine();

                        // Parse document data in JSON format
                        string ret = documentParser.ParseDocument(file.OpenBinaryStream(), OutputFormat.CSV);

                        // Display parsed data in console
                        LogTextBox.Text += "Parsing results in CSV format:";
                        LogTextBox.Text += ret;

                        var DestinationFile = inputDocument.Split('.')[0] + ".csv";
                        SaveToSharePoint(ret, DestinationFile);

                        LogTextBox.Text += String.Format("Generated CSV file saved as \"{0}\\{1}\" file. \n", DestinationLibName, DestinationFile);
                    }
                }
            }
            catch (Exception ex)
            {
                LogTextBox.Text += ex.ToString() + " \n";
            }
        }

        private void SaveToSharePoint(string data, string DestinationFile)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(data);

            //Upload file to SharePoint document linrary
            //Read create stream
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                //Get handle of library
                SPFolder spLibrary = CurrentWeb.Folders[DestinationLibName];

                //Replace existing file
                var replaceExistingFile = true;

                //Upload document to library
                SPFile spfile = spLibrary.Files.Add(DestinationFile, stream, replaceExistingFile);
                spLibrary.Update();
            }
        }

    }
}
