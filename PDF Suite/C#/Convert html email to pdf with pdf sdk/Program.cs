//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
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

namespace EmailToPDF_HTMLEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Parse MessageContents using MsgReader Library
                // MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
                using (var msg = new MsgReader.Outlook.Storage.Message("HtmlSampleEmail.msg"))
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

                        page.Canvas.DrawString($"Subject: {subject}", font, brush, 20, (topMargin += 20));
                        page.Canvas.DrawString("Message body in next page.", font, brush, 20, (topMargin += 20));

                        // Convert Html body to PDF in order to retain all formatting.
                        using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
                        {
                            converter.PageSize = PaperKind.A4;
                            converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait;

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
