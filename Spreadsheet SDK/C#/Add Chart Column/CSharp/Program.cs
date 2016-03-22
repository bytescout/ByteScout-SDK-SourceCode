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
                Chart columnChart = sheet.Charts.AddChartAndFitInto(1, 3, 16, 9, ChartType.ColumnClustered);
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

                columnChart = sheet.Charts.AddChartAndFitInto(1, 10, 16, 16, ChartType.ColumnStacked);
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

                columnChart = sheet.Charts.AddChartAndFitInto(1, 17, 16, 23, ChartType.ColumnStacked100);
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

                columnChart = sheet.Charts.AddChartAndFitInto(17, 3, 32, 9, ChartType.ColumnClustered3D);
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

                columnChart = sheet.Charts.AddChartAndFitInto(17, 10, 32, 16, ChartType.ColumnStacked3D);
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

                columnChart = sheet.Charts.AddChartAndFitInto(17, 17, 32, 23, ChartType.ColumnStacked1003D);
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));

                columnChart = sheet.Charts.AddChartAndFitInto(33, 10, 48, 16, ChartType.Column3D);
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 0, length - 1, 0)));
                columnChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1)));
			
                if(File.Exists("Output.xls")){
                    File.Delete("Output.xls");
                }
                
                // Save it as XLS
                spreadsheet.SaveAs("Output.xls");

                // close the document
                spreadsheet.Close();

                // open output XLS
                Process.Start("Output.xls");


            }
            catch(Exception e){
                Console.WriteLine("CAN NOT EXECUTE: " + e.ToString());
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey();
            }

        }
    }
}
