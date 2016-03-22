//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Bytescout.Spreadsheet;

namespace Reading_data_from_XLS_into_dataset
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open Spreadsheet
            Spreadsheet document = new Spreadsheet();
	document.LoadFromFile("AdvancedReport.xls");

            DataSet dataSet = new DataSet("AdvancedReport");

            for (int i = 0; i < document.Workbook.Worksheets.Count; i++)
            {
                Worksheet worksheet = document.Workbook.Worksheets[i];

                DataTable table = dataSet.Tables.Add(worksheet.Name);

                for (int column = 0; column <= worksheet.UsedRangeColumnMax; column++)
                {
                    table.Columns.Add(string.Format("Column{0}", column));
                }

                for (int row = 0; row <= worksheet.UsedRangeRowMax; row++)
                {
                    object[] data = new object[worksheet.UsedRangeColumnMax + 1];

                    for (int column = 0; column <= worksheet.UsedRangeColumnMax; column++)
                    {
                        data[column] = worksheet.Cell(row, column).Value;
                    }

                    table.Rows.Add(data);
                }
            }

            // Close Spreadsheet
            document.Close();

            PrintDataSet(dataSet);
        }

        private static void PrintDataSet(DataSet ds)
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
