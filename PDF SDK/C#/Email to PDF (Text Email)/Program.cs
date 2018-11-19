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
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;

namespace EmailToPDF_TextEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please wait while PDF is being created...");

                // Parse MessageContents using MsgReader Library
                // MsgReader library can be obtained from: https://github.com/Sicos1977/MSGReader
                using (var msg = new MsgReader.Outlook.Storage.Message("TxtSampleEmail.msg"))
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
                        page.Canvas.DrawString("Message body in next page.", font, brush, 20, (topMargin += 20));

                        // Get string splitted so that it can be fit properly into page canvas.
                        var splittedStringList = _GetStringMeasuredAndSplitted(msgBody, font);
                        foreach (var itmString in splittedStringList)
                        {
                            Page pageBody = new Page(PaperFormat.A4);
                            pageBody.Canvas.DrawString(itmString, font, brush, 20, 20);

                            // Add new page
                            outputDocument.Pages.Add(pageBody);
                        }

                        // Save output file
                        outputDocument.Save("result.pdf");

                        // Open output file
                        Process.Start("result.pdf");
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


        /// <summary>
        /// Gets string measured and splitted properly
        /// </summary>
        private static List<string> _GetStringMeasuredAndSplitted(string msgBody, Font font)
        {
            List<string> lstStringRet = new List<string>();

            KeyValuePair<string, string> oMeasuredString = new KeyValuePair<string, string>();

            while (!string.IsNullOrEmpty(msgBody))
            {
                oMeasuredString = _MeasuredString(msgBody, font);

                lstStringRet.Add(oMeasuredString.Key);

                msgBody = oMeasuredString.Value;
            }
            
            return lstStringRet;
        }

        /// <summary>
        /// Measure string
        /// </summary>
        private static KeyValuePair<string, string> _MeasuredString(string msgBody, Font font)
        {
            Page pageBody = new Page(PaperFormat.A4);

            var msgBodySplitted = msgBody.Split("\n".ToCharArray());

            string strTemp = "";
            for (int i = 0; i < msgBodySplitted.Length; i++)
            {
                // Here, using Canvas.MeasureString method which measures string against canvas, so we can split to multiple pages it if text is big
                var sizeF = pageBody.Canvas.MeasureString(strTemp + "" + msgBodySplitted[i], font);

                // Page height should be below 800 in-order to fit into page properly
                if (sizeF.Height > 800)
                {
                    var lstRetString_Value = string.Join("\n", msgBodySplitted.Skip(i));

                    // return splittd string and remained of it
                    return new KeyValuePair<string, string>(strTemp, lstRetString_Value);
                }

                strTemp += msgBodySplitted[i];
            }

            // No need to split more
            return new KeyValuePair<string, string>(msgBody, "");
        }

    }
}
