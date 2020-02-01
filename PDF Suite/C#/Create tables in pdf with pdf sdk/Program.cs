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
using Bytescout.PDF;

namespace Tables
{
    /// <summary>
    /// This example demonstrates how to create tables.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";
            // Add page
            Page page = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page);


            DeviceColor lightGrayColor = new ColorGray(200);
            DeviceColor whiteColor = new ColorGray(255);
            DeviceColor lightBlueColor = new ColorRGB(200, 200, 250);
            DeviceColor lightRedColor = new ColorRGB(255, 200, 200);

            // Create a table and set default background color
            Table table = new Table();
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
                TableRow row = table.NewRow();
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

            
            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
