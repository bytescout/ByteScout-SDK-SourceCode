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
using Bytescout.PDF;

namespace Tables
{
    /// <summary>
    /// This example demonstrates how to create invoice which can span multiple pages.
    /// </summary>
    class Program
    {
        #region Global Declarations

        const int HeightConsumedByTableRow = 20;

        static int ContentHeightStart = 100;
        static int ContentHeightEnd = 700;

        static int HeightUtilized = 100;

        static int _RowCounter = 1;

        static Document pdfDocument;
        static Page page;

        #endregion

        static void Main()
        {
            #region Declarations and Implementations

            SolidPen solidPen = new SolidPen();

            Brush blackBrush = new SolidBrush(new ColorRGB(0, 0, 0));

            Font headerFont = new Font(StandardFonts.TimesBold, 24);
            Font headerFont2 = new Font(StandardFonts.TimesBold, 16);

            Font contentFont_12 = new Font(StandardFonts.TimesBold, 12);
            Font contentFont_10 = new Font(StandardFonts.Times, 10);


            // Create new document
            pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            #endregion

            // Add new page
            AddNewPage();

            /* 1. Add Content */
            page.Canvas.DrawString("COMPANY NAME", contentFont_12, blackBrush, 50, (HeightUtilized += 20));

            page.Canvas.DrawString("Address", contentFont_10, blackBrush, 50, (HeightUtilized += 20));
            page.Canvas.DrawString("DATE", contentFont_10, blackBrush, 400, HeightUtilized);

            page.Canvas.DrawString("Phone, fax", contentFont_10, blackBrush, 50, (HeightUtilized += 20));
            page.Canvas.DrawString("INVOICE #", contentFont_10, blackBrush, 400, HeightUtilized);

            page.Canvas.DrawString("E-mail", contentFont_10, blackBrush, 50, (HeightUtilized += 20));
            page.Canvas.DrawString("FOR", contentFont_10, blackBrush, 400, HeightUtilized);

            // Add some vertical space
            HeightUtilized += 50;

            /* 2. Add Table which can span multipage */
            Console.WriteLine("Enter the number of rows to add to the table:");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            DrawTable(NumberOfRows: numberOfRows);

            /* 3. Add Signature */
            // Check new page needed for adding signature
            if (CheckNewPageNeeded(70)) { AddNewPage(); }

            page.Canvas.DrawString("Signature", contentFont_12, blackBrush, 400, (HeightUtilized + 57));
            page.Canvas.DrawLine(solidPen, 450, (HeightUtilized + 70), 570, (HeightUtilized + 70));

            /* 4. Add Header And Footer*/

            for (int pageIndex = 0; pageIndex < pdfDocument.Pages.Count; pageIndex++)
            {
                var curPage = pdfDocument.Pages[pageIndex];

                // Add Logo
                Image imageLogo = new Image("logo.png");
                curPage.Canvas.DrawImage(imageLogo, 20, 45, imageLogo.Width / 2, imageLogo.Height / 2);

                // Add requisites
                curPage.Canvas.DrawString("INVOICE", headerFont, blackBrush, 450, 55);

                // Add Page Number
                curPage.Canvas.DrawLine(solidPen, 20, 750, 590, 750);
                curPage.Canvas.DrawString($"Page: {pageIndex + 1} of {pdfDocument.Pages.Count}", contentFont_10, blackBrush, 30, 760);
            }

            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }


        /// <summary>
        /// Checks whether new page is needed
        /// </summary>
        /// <param name="expectedHeight"></param>
        /// <returns></returns>
        static bool CheckNewPageNeeded(int expectedHeight)
        {
            return (HeightUtilized + expectedHeight) > ContentHeightEnd;
        }

        /// <summary>
        /// Adds new page, and also set height utilized
        /// </summary>
        static void AddNewPage()
        {
            // Add page
            page = new Page(PaperFormat.Letter, PaperOrientation.Portrait);
            pdfDocument.Pages.Add(page);

            // Reset Height Utilized
            HeightUtilized = ContentHeightStart;
        }

        /// <summary>
        /// Draw table
        /// </summary>
        /// <param name="NumberOfRows"></param>
        static void DrawTable(int NumberOfRows)
        {
            while (NumberOfRows > 0)
            {
                // Get number of rows can be added in current page
                var NumberOfRowsCanBeAddedInCurrentPage = GetNumberOfRowsCanBeAddedInCurrentPage();

                if (NumberOfRowsCanBeAddedInCurrentPage > 0)
                {
                    var table = GetTable(Math.Min(NumberOfRows, NumberOfRowsCanBeAddedInCurrentPage));
                    page.Canvas.DrawTable(table, 50, HeightUtilized);

                    // Update Height Utilized
                    HeightUtilized += (Math.Min(NumberOfRows, NumberOfRowsCanBeAddedInCurrentPage) * HeightConsumedByTableRow);

                    NumberOfRows -= Math.Min(NumberOfRows, NumberOfRowsCanBeAddedInCurrentPage);
                }
                else
                {
                    // Add new page
                    AddNewPage();
                }
            }
        }

        /// <summary>
        /// Get Table Header with Content
        /// </summary>
        /// <param name="NumberOfRows"></param>
        /// <returns></returns>
        private static Table GetTable(int NumberOfRows)
        {
            Font fontTableHeader = new Font(StandardFonts.TimesBold, 11);
            Font fontTableRow = new Font(StandardFonts.Times, 10);

            Table table = new Table();

            /* 1. Add Table Header */
            table.Columns.Add(new TableColumn("Description", "Description"));
            table.Columns[0].Width = 220;
            table.Columns[0].Font = fontTableHeader;
            table.Columns[0].TextFormat.HorizontalAlign = HorizontalAlign.Left;

            table.Columns.Add(new TableColumn("Quantity", "Quantity"));
            table.Columns[1].Width = 80;
            table.Columns[1].Font = fontTableHeader;
            table.Columns[1].TextFormat.HorizontalAlign = HorizontalAlign.Right;

            table.Columns.Add(new TableColumn("Price", "Price"));
            table.Columns[2].Width = 100;
            table.Columns[2].Font = fontTableHeader;
            table.Columns[2].TextFormat.HorizontalAlign = HorizontalAlign.Right;

            table.Columns.Add(new TableColumn("Amount", "Amount"));
            table.Columns[3].Width = 120;
            table.Columns[3].Font = fontTableHeader;
            table.Columns[3].TextFormat.HorizontalAlign = HorizontalAlign.Right;

            /* 2. Add Table Content */
            for (int index = 0; index < NumberOfRows; index++)
            {
                // Create new row and set its background color
                TableRow row = table.NewRow();

                // Set row header text
                row["Description"].Text = $"Description for item - {_RowCounter++}";
                row["Description"].Font = fontTableRow;
                row["Description"].TextFormat.HorizontalAlign = HorizontalAlign.Left;

                row["Quantity"].Text = "###";
                row["Quantity"].Font = fontTableRow;
                row["Quantity"].TextFormat.HorizontalAlign = HorizontalAlign.Right;

                row["Price"].Text = "$$$.$$";
                row["Price"].Font = fontTableRow;
                row["Price"].TextFormat.HorizontalAlign = HorizontalAlign.Right;

                row["Amount"].Text = "$$$.$$";
                row["Amount"].Font = fontTableRow;
                row["Amount"].TextFormat.HorizontalAlign = HorizontalAlign.Right;

                // Add the row to the table
                table.Rows.Add(row);
            }

            return table;
        }

        /// <summary>
        /// Get number of rows can be added in current page
        /// </summary>
        /// <returns></returns>
        private static int GetNumberOfRowsCanBeAddedInCurrentPage()
        {
            return (ContentHeightEnd - HeightUtilized) / HeightConsumedByTableRow;
        }

    }
}
