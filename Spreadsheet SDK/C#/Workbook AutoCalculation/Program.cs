//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace WorkbookAutoCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Data to be written in spreadsheet
                var lstProducts = new List<InvoiceProduct> {
                    new InvoiceProduct{ ProductName = "Product 1", Price = 30, Quantity = 10 },
                    new InvoiceProduct{ ProductName = "Product 2", Price = 40, Quantity = 30 },
                    new InvoiceProduct{ ProductName = "Product 3", Price = 50, Quantity = 15 },
                    new InvoiceProduct{ ProductName = "Product 4", Price = 20, Quantity = 20 }
                };

                // Generate Workbook in memory
                var document = _GetSpreadsheet(lstProducts);

                // Export to XLSX
                document.SaveAsXLSX("Invoice.xlsx");
                //document.SaveAsXLS("Invoice.xls");

                // Open output file
                Process.Start("Invoice.xlsx");
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
        private static Spreadsheet _GetSpreadsheet(List<InvoiceProduct> lstProducts)
        {
            // Create new Spreadsheet
            Spreadsheet document = new Spreadsheet();

            // Enable auto-calculation of formulas
            document.Workbook.AutoCalculation = true;

            document.Workbook.DefaultFont = new SpreadsheetFont("Arial", 10);

            // Add new worksheet
            Worksheet Sheet = document.Workbook.Worksheets.Add("Invoice");

            int startRow = 0;

            // Add Product Listing
            string startAddress = "";
            string endAddress = "";

            Sheet.Cell((startRow), 0).Value = "Item";
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


            for (int i = 0; i < lstProducts.Count; i++)
            {
                Sheet.Cell((++startRow), 0).Value = lstProducts[i].ProductName;
                _AddAllBorders(Sheet.Cell(startRow, 0));

                Sheet.Cell(startRow, 1).Value = lstProducts[i].Quantity;
                Sheet.Cell(startRow, 1).AlignmentHorizontal = Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right;
                _AddAllBorders(Sheet.Cell(startRow, 1));

                Sheet.Cell(startRow, 2).Value = lstProducts[i].Price;
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

}
