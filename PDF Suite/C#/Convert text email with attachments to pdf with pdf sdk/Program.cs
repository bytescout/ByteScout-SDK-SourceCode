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


using Bytescout.PDF;
using Bytescout.PDF.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Text;

namespace EmailToPDF_TextEmailWithAttachments
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Parse MessageContents using MsgReader Library
                // MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
                using (var msg = new MsgReader.Outlook.Storage.Message("TxtSampleEmailWithAttachment.msg"))
                {
                    // Get Sender information
                    var from = msg.GetEmailSender(false, false);

                    // Message sent datetime
                    var sentOn = msg.SentOn;

                    // Recipient To information
                    var recipientsTo = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.To, false, false);

                    // Recipient CC information
                    var recipientsCc = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.Cc, false, false);

                    #region Generate and save html

                    // Get Html
                    HtmlGenerator oHtmlGenerator = new HtmlGenerator();
                    oHtmlGenerator.Title = $"Subject: {msg.Subject}";

                    oHtmlGenerator.AddParagraphBodyItem($"File Name: {msg.FileName}");
                    oHtmlGenerator.AddParagraphBodyItem($"From: {from}");
                    oHtmlGenerator.AddParagraphBodyItem($"Sent On: {(sentOn.HasValue ? sentOn.Value.ToString("MM/dd/yyyy HH:mm") : "")}");
                    oHtmlGenerator.AddParagraphBodyItem($"To: {recipientsTo}");
                    oHtmlGenerator.AddParagraphBodyItem($"Subject: {msg.Subject}");

                    if (!string.IsNullOrEmpty(recipientsCc))
                    {
                        oHtmlGenerator.AddParagraphBodyItem($"CC: {recipientsCc}");
                    }

                    oHtmlGenerator.AddRawBodyItem("<hr/>");

                    var msgBodySplitted = msg.BodyText.Split("\n".ToCharArray());

                    foreach (var itmBody in msgBodySplitted)
                    {
                        oHtmlGenerator.AddParagraphBodyItem(itmBody);
                    }

                    // Generate Html
                    oHtmlGenerator.SaveHtml("result.html");

                    #endregion

                    using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
                    {
                        converter.PageSize = PaperKind.A4;
                        converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait;

                        converter.ConvertHtmlToPdf("result.html", "result.pdf");

                        // Get attachments from message (if any, and append to document)
                        if (msg.Attachments.Count > 0)
                        {
                            using (Document outputDocument = new Document("result.pdf"))
                            {
                                foreach (MsgReader.Outlook.Storage.Attachment itmAttachment in msg.Attachments)
                                {
                                    // Get Memory Stream
                                    MemoryStream attachmentMemoryStream = new MemoryStream(itmAttachment.Data);

                                    // Append Attachment
                                    Document docAttachment = new Document(attachmentMemoryStream);

                                    // Append all pages to main PDF
                                    foreach (Page item in docAttachment.Pages)
                                    {
                                        outputDocument.Pages.Add(item);
                                    }
                                }
                                outputDocument.Save("result.pdf");
                            }
                        }

                        // Open result document in default associated application (for demo purpose)
                        ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
                        processStartInfo.UseShellExecute = true;
                        Process.Start(processStartInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter key to exit...");
                Console.ReadLine();
            }
        }
    }



    /// <summary>
    /// Html Generator class
    /// </summary>
    class HtmlGenerator
    {
        #region Constructor

        public HtmlGenerator()
        {
            this.StrBodyItems = new List<string>();
        }

        #endregion

        #region Variable Declarations

        public string Title { get; set; }
        private List<string> StrBodyItems { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Add Body Item
        /// </summary>
        public void AddRawBodyItem(string strBodyItem)
        {
            StrBodyItems.Add(strBodyItem);
        }

        /// <summary>
        /// Add Paragraph body item
        /// </summary>
        /// <param name="strText"></param>
        public void AddParagraphBodyItem(string strText)
        {
            StrBodyItems.Add(string.Format("<p style=''>{0}</p>", strText));
        }

        /// <summary>
        /// Gets Generated Html
        /// </summary>
        /// <returns></returns>
        public string GetHtml()
        {
            StringBuilder oRetHtml = new StringBuilder(string.Empty);

            oRetHtml.Append("<html>");

            oRetHtml.Append("<head>");
            oRetHtml.AppendFormat("<title>{0}</title>", Title);
            oRetHtml.Append(@"<style>p {
                                    line-height: 107.9 %;
                                    margin-bottom: 13pt;
                                    font-family: 'Arial', 'sans-serif';
                                    font-size: 15pt;
                                    margin-top: 0;
                                    margin-left: 0;
                                    margin-right: 0;
                            }</style>");
            oRetHtml.Append("</head>");

            oRetHtml.Append("<body>");
            foreach (var itemBody in StrBodyItems)
            {
                oRetHtml.Append(itemBody);
            }
            oRetHtml.Append("</body>");

            oRetHtml.Append("</html>");

            return oRetHtml.ToString();
        }

        /// <summary>
        /// Save all Html
        /// </summary>
        /// <param name="fileName"></param>
        public void SaveHtml(string fileName)
        {
            var allHtml = GetHtml();
            System.IO.File.WriteAllText(fileName, allHtml);
        }

        #endregion

    }

}
