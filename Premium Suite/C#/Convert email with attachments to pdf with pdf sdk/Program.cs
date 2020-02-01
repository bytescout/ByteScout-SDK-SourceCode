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
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using Bytescout.PDF;
using Bytescout.PDF.Converters;

using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;

namespace EmailToPDF_EmailWithAttachment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Parse MessageContents using MsgReader Library
                // MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
                using (var msg = new MsgReader.Outlook.Storage.Message("EmailWithAttachments.msg"))
                {
                    // Get Sender information
                    var from = msg.GetEmailSender(false, false);

                    // Message sent datetime
                    var sentOn = msg.SentOn;
                    
                    // Recipient To information
                    var recipientsTo = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.To, false, false);
                    
                    // Recipient CC information
                    var recipientsCc = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.Cc, false, false);

                    // Recipient BCC information
                    var recipientBcc = msg.GetEmailRecipients(MsgReader.Outlook.RecipientType.Bcc, false, false);

                    // Message subject
                    var subject = msg.Subject;
                    
                    // Get Message Body
                    var msgBody = msg.BodyHtml;

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

                        if (!string.IsNullOrEmpty(recipientBcc))
                        {
                            page.Canvas.DrawString($"BCC: {recipientBcc}", font, brush, 20, (topMargin += 20));
                        }

                        page.Canvas.DrawString($"Subject: {subject}", font, brush, 20, (topMargin += 20));
                        page.Canvas.DrawString("Message body in next page.", font, brush, 20, (topMargin += 20));

                        // Convert Html body to PDF in order to retain all formatting.
                        using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
                        {
                            converter.PageSize = PaperKind.A4;
                            converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait;

                            // Get all inline attachment, and replace them
                            foreach (MsgReader.Outlook.Storage.Attachment itmAttachment in msg.Attachments)
                            {
                                if (itmAttachment.IsInline)
                                {
                                    var oData = itmAttachment.Data;
                                    var dataBase64 = Convert.ToBase64String(oData);

                                    // Replace within email
                                    msgBody = msgBody.Replace($"src=\"{itmAttachment.FileName}\"", $"src=\"{ "data:image/jpeg;base64," + dataBase64}\"");
                                }
                            }

                            // Convert input HTML to stream
                            byte[] byteArrayBody = Encoding.UTF8.GetBytes(msgBody);
                            MemoryStream inputStream = new MemoryStream(byteArrayBody);

                            // Create output stream to store generated PDF file
                            using (var outputStream = new MemoryStream())
                            {
                                // Convert HTML to PDF
                                converter.ConvertHtmlToPdf(inputStream, outputStream);

                                // Create new document from generated output stream
                                Document docContent = new Document(outputStream);

                                // Append all pages to main PDF
                                foreach (Page item in docContent.Pages)
                                {
                                    outputDocument.Pages.Add(item);
                                }

                                // Apped all other attachments
                                foreach (MsgReader.Outlook.Storage.Attachment itmAttachment in msg.Attachments)
                                {
                                    if (!itmAttachment.IsInline)
                                    {
                                        // Attachment is image, so adding accordingly
                                        var pageAttachment = new Page(PaperFormat.A4);
                                        Canvas canvas = pageAttachment.Canvas;

                                        var oAttachmentStream = new MemoryStream(itmAttachment.Data);
                                        Image imageAttachment = new Image(oAttachmentStream);

                                        canvas.DrawImage(imageAttachment, 20, 20);

                                        // Add attachment
                                        outputDocument.Pages.Add(pageAttachment);
                                    }
                                }

                                // Save output file
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
}
