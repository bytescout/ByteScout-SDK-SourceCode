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
using System.Data;
using System.IO;
using Bytescout.Spreadsheet;

namespace Bytescout.Spreadsheet.Utils
{
    /// <summary>
    /// class for simple XLS to XML and XML to XLS conversion
    /// </summary>
    public class SimpleXMLConverter
    {
        private readonly Spreadsheet document;

        public SimpleXMLConverter(Spreadsheet document)
        {
            this.document = document;
        }

        public void LoadXML(string path)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(path);

            foreach (DataTable table in dataSet.Tables)
            {
                Worksheet worksheet = document.Workbook.Worksheets.Add(table.TableName);

                // Add columns
                worksheet.Columns.Insert(0, table.Columns.Count);

                /*// Add row for header
                worksheet.Rows.Insert(0);

                // Fill headers
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    worksheet.Cell(1, i).Value = table.Columns[i].ColumnName;
                }*/

                // Add rows for data
                worksheet.Rows.Insert(0, table.Rows.Count);

                // Fill data
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 1, j).Value = table.Rows[i][j].ToString();
                    }
                }
            }
        }

        public void SaveXML(string path)
        {
            DataSet dataSet = new DataSet();

            for (int i = 0; i < document.Workbook.Worksheets.Count; i++)
            {
                Worksheet worksheet = document.Workbook.Worksheets[i];

                DataTable table = dataSet.Tables.Add(worksheet.Name);

                #region Add Columns

                for (int column = 0; column <= worksheet.UsedRangeColumnMax; column++)
                {
                    table.Columns.Add(
                        string.Format("Column_{0}", column));
                }

                #endregion

                #region Add rows

                for (int row = 0; row <= worksheet.UsedRangeRowMax; row++)
                {
                    object[] data = new object[worksheet.UsedRangeColumnMax + 1];

                    for (int column = 0; column <= worksheet.UsedRangeColumnMax; column++)
                    {
                        if (worksheet.Cell(row, column).Value != null &&
                            worksheet.Cell(row, column).Value.ToString().Trim() == "")
                            data[column] = null;
                        else
                            data[column] = worksheet.Cell(row, column).Value;
                    }

                    table.Rows.Add(data);
                }

                #endregion
            }

            dataSet.WriteXml(path);
        }

        private void PrintDataSet(DataSet ds)
        {
            Console.WriteLine("DataSet name: {0}", ds.DataSetName);
            foreach (DataTable table in ds.Tables)
            {
                int rowCount = table.Rows.Count;
                int columnCount = table.Columns.Count;

                Console.WriteLine("\nTable: {0} ({1} rows)", table.TableName, rowCount);
                foreach (DataColumn column in table.Columns)
                {
                    Console.Write("{0}\t", column.ColumnName);
                }
                Console.WriteLine();

                for (int i = 0; i < rowCount; i++)
                {
                    for (int column = 0; column < columnCount; column++)
                    {
                        Console.Write("{0}\t", table.Rows[i][column]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
