//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace GenerateInvoice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // STEP-1: Get Invoice Data
                var oInvoiceData = GetInvoiceData();

                // STEP-2: Generate Invoice in memory
                var document = _GetSpreadsheet(oInvoiceData);

                // Step-3: Export to XLS, XLSX and PDF
                document.SaveAsXLSX("Invoice.xlsx");
                document.SaveAsXLS("Invoice.xls");
                document.SaveAsPDF("Invoice.pdf");

                // Open output file
                Process.Start("Invoice.xlsx");
                Process.Start("Invoice.pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Get Spreadsheet
        /// </summary>
        private static Spreadsheet _GetSpreadsheet(InvoiceData oInvoiceData)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();
            document.Workbook.AutoCalculation = true;
            document.Workbook.DefaultFont = new SpreadsheetFont("Arial", 10);

            // Add new worksheet
            Worksheet Sheet = document.Workbook.Worksheets.Add("Invoice");

            int startRow = 0;

            // 1. Write Company Name
            Sheet.Cell(startRow, 0).Value = oInvoiceData.CompanyName;
            Sheet.Cell(startRow, 0).Font = new Font("Arial", 15, FontStyle.Bold | FontStyle.Italic);

            // 2. Write Company Address
            Sheet.Cell((++startRow), 0).Value = oInvoiceData.CompanyAddress1;
            Sheet.Cell((++startRow), 0).Value = oInvoiceData.CompanyAddress2;

            startRow++;

            // 3. Write Invoice Info
            Sheet.Cell((++startRow), 2).Value = "Invoice No.";
            Sheet.Cell(startRow, 2).Font = new Font("Arial", 10, FontStyle.Bold);
            Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;

            Sheet.Cell(startRow, 3).Value = oInvoiceData.InvoiceNo;

            Sheet.Cell((++startRow), 2).Value = "Invoice Date.";
            Sheet.Cell(startRow, 2).Font = new Font("Arial", 10, FontStyle.Bold);
            Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;

            Sheet.Cell(startRow, 3).ValueAsDateTime = oInvoiceData.InvoiceDate;
            Sheet.Cell(startRow, 3).NumberFormatString = "mm/dd/yyyy";

            // 4. Write Client Info
            Sheet.Cell((++startRow), 0).Value = oInvoiceData.ClientName;
            Sheet.Cell(startRow, 0).Font = new Font("Arial", 12, FontStyle.Bold);

            Sheet.Cell((++startRow), 0).Value = oInvoiceData.ClientAddress1;
            Sheet.Cell((++startRow), 0).Value = oInvoiceData.ClientAddress2;
            startRow++;

            // 5. Write Notes
            Sheet.Cell((++startRow), 0).Value = "Notes";
            Sheet.Cell(startRow, 0).Font = new Font("Arial", 12, FontStyle.Bold);

            Sheet.Cell((++startRow), 0).Value = oInvoiceData.Notes;
            startRow += 2;

            // 6. Add Product Listing
            string startAddress = "";
            string endAddress = "";

            Sheet.Cell((++startRow), 0).Value = "Item";
            _AddAllBorders(Sheet.Cell(startRow, 0));
            Sheet.Cell(startRow, 0).Font = new Font("Arial", 11, FontStyle.Bold);

            Sheet.Cell(startRow, 1).Value = "Quantity";
            _AddAllBorders(Sheet.Cell(startRow, 1));
            Sheet.Cell(startRow, 1).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
            Sheet.Cell(startRow, 1).Font = new Font("Arial", 11, FontStyle.Bold);

            Sheet.Cell(startRow, 2).Value = "Price";
            _AddAllBorders(Sheet.Cell(startRow, 2));
            Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
            Sheet.Cell(startRow, 2).Font = new Font("Arial", 11, FontStyle.Bold);

            Sheet.Cell(startRow, 3).Value = "Total";
            _AddAllBorders(Sheet.Cell(startRow, 3));
            Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
            Sheet.Cell(startRow, 3).Font = new Font("Arial", 11, FontStyle.Bold);


            for (int i = 0; i < oInvoiceData.lstProducts.Count; i++)
            {
                Sheet.Cell((++startRow), 0).Value = oInvoiceData.lstProducts[i].ProductName;
                _AddAllBorders(Sheet.Cell(startRow, 0));

                Sheet.Cell(startRow, 1).Value = oInvoiceData.lstProducts[i].Quantity;
                Sheet.Cell(startRow, 1).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
                _AddAllBorders(Sheet.Cell(startRow, 1));

                Sheet.Cell(startRow, 2).Value = oInvoiceData.lstProducts[i].Price;
                Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
                _AddAllBorders(Sheet.Cell(startRow, 2));

                // Calculated cell
                string formulaMultiplication = string.Format("={0}*{1}", Sheet.Cell(startRow, 1).GetAddress().ToString(), Sheet.Cell(startRow, 2).GetAddress().ToString());
                Sheet.Cell(startRow, 3).Formula = formulaMultiplication;
                Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
                _AddAllBorders(Sheet.Cell(startRow, 3));

                // Address to be used for total sum
                if (i == 0)
                {
                    startAddress = Sheet.Cell(startRow, 3).GetAddress().ToString();
                }
                endAddress = Sheet.Cell(startRow, 3).GetAddress().ToString();
            }

            Sheet.Cell((++startRow), 2).Value = "TOTAL";
            Sheet.Cell(startRow, 2).Font = new Font("Arial", 11, FontStyle.Bold);
            Sheet.Cell(startRow, 2).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;

            string formulaTotalSum = string.Format("=SUM({0}:{1})", startAddress, endAddress);
            Sheet.Cell(startRow, 3).Formula = formulaTotalSum;
            Sheet.Cell(startRow, 3).Font = new Font("Arial", 11, FontStyle.Bold);
            Sheet.Cell(startRow, 3).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;

            // AutoFit all columns
            Sheet.Columns[0].AutoFit();
            Sheet.Columns[1].AutoFit();
            Sheet.Columns[2].AutoFit();
            Sheet.Columns[3].AutoFit();

            // Return all formatted document
            return document;
        }

        /// <summary>
        /// Add borders to cell
        /// </summary>
        private static void _AddAllBorders(Cell cell)
        {
            cell.LeftBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin;
            cell.RightBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin;
            cell.TopBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin;
            cell.BottomBorderStyle = Bytescout.Spreadsheet.Constants.LineStyle.Thin;
        }

        /// <summary>
        /// Gets Sample invoice data
        /// </summary>
        private static InvoiceData GetInvoiceData()
        {
            var oRet = new InvoiceData
            {
                CompanyName = "Your Company Name",
                CompanyAddress1 = "Your Address",
                CompanyAddress2 = "City, State Zip",

                ClientName = "Client Name",
                ClientAddress1 = "Address",
                ClientAddress2 = "City, State Zip",

                InvoiceNo = "123456",
                InvoiceDate = DateTime.Now,

                Notes = "Some notes...",

                lstProducts = new List<InvoiceProduct> {
                    new InvoiceProduct{ ProductName = "Product 1", Price = 30, Quantity = 10 },
                    new InvoiceProduct{ ProductName = "Product 2", Price = 40, Quantity = 30 },
                    new InvoiceProduct{ ProductName = "Product 3", Price = 50, Quantity = 15 },
                    new InvoiceProduct{ ProductName = "Product 4", Price = 20, Quantity = 20 }
                }
            };


            return oRet;
        }

    }

    #region Invoice Class

    /// <summary>
    /// Invoice Data class
    /// </summary>
    public class InvoiceData
    {
        #region  Constructors

        public InvoiceData()
        {
            lstProducts = new List<InvoiceProduct>();
        }

        #endregion

        public string CompanyName { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }

        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }

        public string ClientName { get; set; }
        public string ClientAddress1 { get; set; }
        public string ClientAddress2 { get; set; }

        public string Notes { get; set; }

        public List<InvoiceProduct> lstProducts { get; set; }
    }

    /// <summary>
    /// Invoice Product class
    /// </summary>
    public class InvoiceProduct
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    #endregion

}
