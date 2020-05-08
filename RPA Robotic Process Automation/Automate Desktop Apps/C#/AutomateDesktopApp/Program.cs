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


using ByteScout.DocumentParser;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace AutomateDesktopApps
{
    class Program
    {

        static void Main(string[] args)
        {
            // Input Invoice File
            var inputFile = @"Sample_Files\Invoice.pdf";
            // Invoice Template
            var inputTemplate = @"Sample_Files\Invoice.yml";

            // Target executable for invoice data
            // Update following path with your own location of executable
            // Source code of executable is in same solution under "InvoiceSayHello" project
            // One can get EXE by simply building project and from bin\Debug folder
            var targetExecutablePath = @".....InvoiceSayHello\bin\Debug\InvoiceSayHello.exe";

            // Get Invoice Input data
            var invData = GetInvoiceInfo(inputFile, inputTemplate);

            // Automate invoice data entry
            // For output refer to Screenshots\3_Output.png
            AutomateDateEntry(invData, targetExecutablePath);
        }


        /// <summary>
        /// Gets Invoice Data by parsing PDF document
        /// </summary>
        static Invoice GetInvoiceInfo(string inputFile, string inputTemplate)
        {
            // Create Document Parser Instance
            using (var docParser = new DocumentParser("demo", "demo"))
            {
                // Add Template
                docParser.AddTemplate(inputTemplate);

                // Parse document data in JSON format
                string jsonString = docParser.ParseDocument(inputFile, ByteScout.DocumentParser.OutputFormat.JSON);

                // Parser JSON fileds to class format
                return ParseJsonToInvoice(jsonString);
            }
        }

        /// <summary>
        /// Parser input json data to invoice object
        /// </summary>
        static Invoice ParseJsonToInvoice(string jsonData)
        {
            // Get Object data from input file
            JObject jsonObj = JObject.Parse(jsonData);

            // Prepare return object
            var oRet = new Invoice();

            oRet.BillTo = Convert.ToString(jsonObj["fields"]["billTo"]["value"]);
            oRet.BillAddress = Convert.ToString(jsonObj["fields"]["billAddress"]["value"]);
            oRet.InvNo = Convert.ToString(jsonObj["fields"]["invNo"]["value"]);
            oRet.InvDate = Convert.ToString(jsonObj["fields"]["invDate"]["value"]);
            oRet.InvAmt = Convert.ToString(jsonObj["fields"]["invAmt"]["value"]);

            return oRet;
        }

        /// <summary>
        /// Automate data entry to Invoice EXE
        /// </summary>
        static void AutomateDateEntry(Invoice invoice, string targetExecutablePath)
        {
            /*
             Useful resources: 
             https://github.com/microsoft/WinAppDriver/wiki

             // Get Windows 10 SDK from following link
             https://developer.microsoft.com/en-us/windows/downloads/windows-10-sdk/

             // Blog article regarding system requirements, needed software and their usage info
             https://www.synerzip.com/blog/getting-hands-on-with-winappdriver/
             */

            if (invoice == null)
            {
                throw new Exception("Invoice data is null");
            }

            // Note: Make sure you have WinAppDriver installed and running
            // Refer to Screenshots\1_StartingWinAppServer.png
            var WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

            // Create a new session to bring up an instance of the Invoice portable application
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", targetExecutablePath);
            appCapabilities.SetCapability("deviceName", "WindowsPC");

            WindowsDriver<WindowsElement> InvoiceSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);

            // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
            InvoiceSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);

            // Please Note: Use Inspect.exe to know Id or name in order to correctly point to control
            // Can be found in similar location as below
            // C:\Program Files (x86)\Windows Kits\10\bin\10.0.18362.0\x64\inspect.exe
            // Refer to Screenshots\2_InspectingAutomationId.png

            // Set Invoice Data
            InvoiceSession.FindElementByAccessibilityId("txtBillTo").SendKeys(invoice.BillTo);
            InvoiceSession.FindElementByAccessibilityId("txtAddress").SendKeys(invoice.BillAddress);
            InvoiceSession.FindElementByAccessibilityId("txtInvoiceNo").SendKeys(invoice.InvNo);
            InvoiceSession.FindElementByAccessibilityId("txtInvoiceDate").SendKeys(invoice.InvDate);
            InvoiceSession.FindElementByAccessibilityId("txtInvoiceAmount").SendKeys(invoice.InvAmt);

            // Invoke submit
            // Set alarm hour
            InvoiceSession.FindElementByAccessibilityId("btnSubmit").Click();
        }

    }

    class Invoice
    {
        public string BillTo { get; set; }
        public string BillAddress { get; set; }
        public string InvNo { get; set; }
        public string InvDate { get; set; }
        public string InvAmt { get; set; }
    }

}
