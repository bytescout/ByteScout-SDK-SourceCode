//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Charts;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // create new Spreadsheet object
                Spreadsheet spreadsheet = new Spreadsheet();

                // add new worksheet
                Worksheet sheet = spreadsheet.Workbook.Worksheets.Add("Sample");

                // add a random numbers
                int length = 10;
                Random rnd = new Random();
                for (int i = 0; i < length; i++)
                {
                    sheet.Cell(i, 0).Value = rnd.Next(10);
                    sheet.Cell(i, 1).Value = rnd.Next(10);
                }

                // add charts to worksheet
                Chart columnChart = sheet.Charts.AddChart(5, 4, ChartType.ColumnClustered);
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, 9, 0)));
                Series series = new Series(sheet.Range(0, 1, 9, 1));
                series.ChartType = ChartType.Line;
                columnChart.SeriesCollection.Add(series);

                // Delete output file if exists
                if (File.Exists("output.xls"))
                {
                    File.Delete("output.xls");
                }

                // Save it as XLS
                spreadsheet.SaveAs("Output.xls");

                // close the document
                spreadsheet.Close();

                // open output XLS
                Process.Start("Output.xls");


            }
            catch (Exception e)
            {
                Console.WriteLine("CAN NOT EXECUTE: " + e.ToString());
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey();
            }

        }
    }
}
