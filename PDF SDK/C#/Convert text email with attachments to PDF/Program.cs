//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDF;
using System;
using System.Diagnostics;
using System.IO;
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;

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

                    // Message subject
                    var subject = msg.Subject;

                    // Get Message Body
                    var msgBody = msg.BodyText;

                    // Prepare PDF docuemnt
                    using (Document outputDocument = new Document())
                    {
                        // Add registration keys
                        outputDocument.RegistrationName = "demo";
                        outputDocument.RegistrationKey = "demo";

                        // Add page
                        Page page = new Page(PaperFormat.A4);
                        outputDocument.Pages.Add(page);

                        // Add sample content
                        Font font = new Font(StandardFonts.Times, 12);
                        Brush brush = new SolidBrush();

                        // Add Email contents
                        int topMargin = 20;
                        page.Canvas.DrawString($"File Name: {msg.FileName}", font, brush, 20, (topMargin += 20));
                        page.Canvas.DrawString($"From: {from}", font, brush, 20, (topMargin += 20));
                        page.Canvas.DrawString($"Sent On: {(sentOn.HasValue ? sentOn.Value.ToString("MM/dd/yyyy HH:mm") : "")}", font, brush, 20, (topMargin += 20));
                        page.Canvas.DrawString($"To: {recipientsTo}", font, brush, 20, (topMargin += 20));

                        if (!string.IsNullOrEmpty(recipientsCc))
                        {
                            page.Canvas.DrawString($"CC: {recipientsCc}", font, brush, 20, (topMargin += 20));
                        }

                        page.Canvas.DrawString($"Subject: {subject}", font, brush, 20, (topMargin += 20));
                        page.Canvas.DrawString("Message body and attachments in next page.", font, brush, 20, (topMargin += 20));

                        Page pageBody = new Page(PaperFormat.A4);
                        pageBody.Canvas.DrawString(msgBody, font, brush, 20, 20);
                        outputDocument.Pages.Add(pageBody);

                        // Get attachments from message (if any, and append to document)
                        if (msg.Attachments.Count > 0)
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
                        }

                        // Save output file
                        outputDocument.Save("result.pdf");

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
}
