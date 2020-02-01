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
using System.Drawing.Printing;
using System.IO;

namespace PDFSDKSamples
{
    public partial class Default : System.Web.UI.Page
    {

        /*
        IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

        Temporary folder access is required for web application when you use ByteScout SDK in it.
        If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

        SOLUTION:

        If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

        If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

        In this case
        - check the User or User Group your web application is running under
        - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
        - restart your web application and try again

        */

        #region Events

        /// <summary>
        /// Handle HTML to PDF conversation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPDFConversionFromHtml_Click(object sender, EventArgs e)
        {
            try
            {
                // HTML to PDF Conversion
                using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
                {
                    converter.PageSize = PaperKind.A4;
                    converter.Orientation = Bytescout.PDF.Converters.PaperOrientation.Portrait;
                    converter.Footer = "<p style=\"color: blue;\">FOOTER TEXT</p>";

                    // Get html document in input stream
                    FileStream inputFileStream = new FileStream(Server.MapPath("~/SampleFiles/sample.html"), FileMode.Open);

                    // Define output stream
                    MemoryStream outputStream = new MemoryStream();

                    // Get converted PDF docuement in output stream
                    converter.ConvertHtmlToPdf(inputFileStream, outputStream);

                    // Download converted document
                    Response.Clear();
                    Response.ClearHeaders();

                    Response.AppendHeader("Content-Length", outputStream.Length.ToString());
                    Response.ContentType = "text/pdf";
                    Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_ConvertedFromHTML.pdf\"");

                    Response.BinaryWrite(outputStream.ToArray());
                    Response.End();
                }
            }
            catch (Exception ex)
            {
                lblPDFConversationFromHTML.Text = "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Handle Table Creation with PDF SDK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnTableCreation_Click(object sender, EventArgs e)
        {
            try
            {
                // Create new document
                Document pdfDocument = new Document();
                pdfDocument.RegistrationName = "demo";
                pdfDocument.RegistrationKey = "demo";

                // Add page
                Bytescout.PDF.Page page = new Bytescout.PDF.Page(PaperFormat.A4);
                pdfDocument.Pages.Add(page);

                DeviceColor lightGrayColor = new ColorGray(200);
                DeviceColor whiteColor = new ColorGray(255);
                DeviceColor lightBlueColor = new ColorRGB(200, 200, 250);
                DeviceColor lightRedColor = new ColorRGB(255, 200, 200);

                // Create a table and set default background color
                Bytescout.PDF.Table table = new Bytescout.PDF.Table();
                table.BackgroundColor = lightGrayColor;

                // Add row headers column and set its color
                table.Columns.Add(new TableColumn("RowHeaders"));
                table.Columns[0].BackgroundColor = lightGrayColor;

                // Add columns A, B, C, ...
                for (int c = 0; c < 10; c++)
                {
                    string columnName = Convert.ToChar('A' + c).ToString();
                    table.Columns.Add(new TableColumn(columnName, columnName));
                }

                // Add rows
                for (int r = 0; r < 10; r++)
                {
                    // Create new row and set its background color
                    Bytescout.PDF.TableRow row = table.NewRow();
                    row.BackgroundColor = whiteColor;

                    // Set row header text
                    row["RowHeaders"].Text = (r + 1).ToString();

                    // Set cell text
                    for (int c = 0; c < 10; c++)
                    {
                        string columnName = Convert.ToChar('A' + c).ToString();
                        row[columnName].Text = columnName + (r + 1);
                    }

                    // Add the row to the table
                    table.Rows.Add(row);
                }

                // Decorate the table
                table.Rows[1]["B"].BackgroundColor = lightRedColor;
                table.Columns[2].BackgroundColor = lightBlueColor;
                table.Rows[1].BackgroundColor = lightBlueColor;
                table.Rows[1]["RowHeaders"].BackgroundColor = lightBlueColor;

                // Draw the table on canvas
                page.Canvas.DrawTable(table, 20, 20);

                // Save created PDF to memory stream
                MemoryStream memoryStream = new MemoryStream();
                pdfDocument.Save(memoryStream);

                // Perform download of file
                Response.Clear();
                Response.ClearHeaders();

                Response.AppendHeader("Content-Length", memoryStream.Length.ToString());
                Response.ContentType = "text/pdf";
                Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_PDFWithTable.pdf\"");

                Response.BinaryWrite(memoryStream.ToArray());
                Response.End();
            }
            catch (Exception ex)
            {
                lblTableCreation.Text = "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Demonstrate Splitting PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSplitPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Open Document
                Document document = new Document(Server.MapPath("~/SampleFiles/sample.pdf"));
                document.RegistrationName = "demo";
                document.RegistrationKey = "demo";

                // Create Split PDF Document
                Document documentSplitPDF = new Document();
                documentSplitPDF.RegistrationName = "demo";
                documentSplitPDF.RegistrationKey = "demo";

                // Get page 1&2 to Split PDF document
                for (int i = 0; i < 2; i++)
                {
                    documentSplitPDF.Pages.Add(document.Pages[i]);
                }

                // Save splitted PDF to memory stream
                MemoryStream memoryStream = new MemoryStream();
                documentSplitPDF.Save(memoryStream);

                // Perform download of file
                Response.Clear();
                Response.ClearHeaders();

                Response.AppendHeader("Content-Length", memoryStream.Length.ToString());
                Response.ContentType = "text/pdf";
                Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_splitPDF.pdf\"");

                Response.BinaryWrite(memoryStream.ToArray());
                Response.End();
            }
            catch (Exception ex)
            {
                lblSplitPDF.Text = "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Handle Merging PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnMergePDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Open first document
                Document document1 = new Document(Server.MapPath("~/SampleFiles/sample.pdf"));
                document1.RegistrationName = "demo";
                document1.RegistrationKey = "demo";

                // Open second document
                Document document2 = new Document(Server.MapPath("~/SampleFiles/sample2.pdf"));
                document2.RegistrationName = "demo";
                document2.RegistrationKey = "demo";

                // Add pages from document2 to document1
                for (int i = 0; i < document2.Pages.Count; ++i)
                {
                    document1.Pages.Add(document2.Pages[i]);
                }

                // Save merged PDF to memory stream
                MemoryStream memoryStream = new MemoryStream();
                document1.Save(memoryStream);

                // Perform download of file
                Response.Clear();
                Response.ClearHeaders();

                Response.AppendHeader("Content-Length", memoryStream.Length.ToString());
                Response.ContentType = "text/pdf";
                Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_mergedPDF.pdf\"");

                Response.BinaryWrite(memoryStream.ToArray());
                Response.End();
            }
            catch (Exception ex)
            {
                lblMergePDF.Text = "Error: " + ex.Message;
            }
        }

        /// <summary>
        /// Handle Protecting PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnProtectingPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (Document pdfDocument = new Document())
                {
                    // Set registration key and password
                    pdfDocument.RegistrationKey = "demo";
                    pdfDocument.RegistrationName = "demo";

                    // PDF file path
                    string pdfFilePath = Server.MapPath("~/SampleFiles/sample.pdf");

                    // Load pdf file
                    pdfDocument.Load(pdfFilePath);

                    // Set document encryption algorythm
                    pdfDocument.Security.EncryptionAlgorithm = EncryptionAlgorithm.RC4_40bit;

                    // Set various user permissions
                    pdfDocument.Security.AllowPrintDocument = false;
                    pdfDocument.Security.AllowContentExtraction = false;
                    pdfDocument.Security.AllowModifyAnnotations = false;
                    pdfDocument.Security.PrintQuality = PrintQuality.LowResolution;

                    // PDF format supports two kinds of passwords: owner and user password.
                    // User password allows to view document and perform allowed actions.
                    // Owner password allows everything, including changing passwords and permissions.

                    // Set owner password
                    // pdfDocument.Security.OwnerPassword = "ownerpassword";

                    // Set user password
                    pdfDocument.Security.UserPassword = "password1";

                    // Extract PDF document to Stream
                    MemoryStream memoryStream = new MemoryStream();
                    pdfDocument.Save(memoryStream);

                    // Perform download of file
                    Response.Clear();
                    Response.ClearHeaders();

                    Response.AppendHeader("Content-Length", memoryStream.Length.ToString());
                    Response.ContentType = "text/pdf";
                    Response.AppendHeader("Content-Disposition", "attachment;filename=\"sample_protectedPDF.pdf\"");

                    Response.BinaryWrite(memoryStream.ToArray());
                    Response.End();
                }
            }
            catch (Exception ex)
            {
                lblProtectingPDF.Text = "Error: " + ex.Message;
            }

        }

        #endregion
    }
}
