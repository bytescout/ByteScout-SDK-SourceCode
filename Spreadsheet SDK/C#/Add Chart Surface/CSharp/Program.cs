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

                // add a data for Surface chart
                int count = 10;
                double step = 2 * Math.PI / (count - 1);
                for (int i = 0; i < count; i++)
                    for (int j = 0; j < count; j++)
                    {
                        sheet[i, j].Value = Math.Sin(step * Math.Sqrt(i * i + j * j));
                    }                    

                // add charts to worksheet
                Chart surfaceChart = sheet.Charts.AddChartAndFitInto(11, 1, 28, 8, ChartType.Surface);
                for (int i = 0; i < count; i++)
                {
                    surfaceChart.SeriesCollection.Add(new Series(sheet.Range(0, i, 9, i)));
                }

                surfaceChart = sheet.Charts.AddChartAndFitInto(11, 10, 28, 17, ChartType.SurfaceWireframe);
                for (int i = 0; i < count; i++)
                {
                    surfaceChart.SeriesCollection.Add(new Series(sheet.Range(0, i, 9, i)));
                }

                surfaceChart = sheet.Charts.AddChartAndFitInto(29, 1, 46, 8, ChartType.SurfaceTopView);
                for (int i = 0; i < count; i++)
                {
                    surfaceChart.SeriesCollection.Add(new Series(sheet.Range(0, i, 9, i)));
                }

                surfaceChart = sheet.Charts.AddChartAndFitInto(29, 10, 46, 17, ChartType.SurfaceTopViewWireframe);
                for (int i = 0; i < count; i++)
                {
                    surfaceChart.SeriesCollection.Add(new Series(sheet.Range(0, i, 9, i)));
                }

                if (File.Exists("Output.xls"))
                {
                    File.Delete("Output.xls");
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
