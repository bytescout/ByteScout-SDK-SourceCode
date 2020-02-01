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
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Charts;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new Spreadsheet object
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.RegistrationName = "demo";
            spreadsheet.RegistrationKey = "demo";

            // Add new worksheet
            Worksheet sheet = spreadsheet.Workbook.Worksheets.Add("Sample");

            // Add few random numbers
            int length = 10;
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                sheet.Cell(i, 0).Value = i;
                sheet.Cell(i, 1).Value = rnd.NextDouble() * 10;
                sheet.Cell(i, 2).Value = rnd.NextDouble() * 10;
            }

            // Add charts to worksheet
            Chart scatterChart = sheet.Charts.AddChartAndFitInto(1, 3, 16, 9, ChartType.XYScatter);
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)));
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 2, length - 1, 2)));

            scatterChart = sheet.Charts.AddChartAndFitInto(1, 10, 16, 16, ChartType.XYScatterSmooth);
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)));
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 2, length - 1, 2)));

            scatterChart = sheet.Charts.AddChartAndFitInto(1, 17, 16, 23, ChartType.XYScatterSmoothNoMarkers);
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)));
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 2, length - 1, 2)));

            scatterChart = sheet.Charts.AddChartAndFitInto(17, 10, 32, 16, ChartType.XYScatterLines);
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)));
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 2, length - 1, 2)));

            scatterChart = sheet.Charts.AddChartAndFitInto(17, 17, 32, 23, ChartType.XYScatterLinesNoMarkers);
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 1, length - 1, 1), sheet.Range(0, 0, length - 1, 0)));
            scatterChart.SeriesCollection.Add(new Series(sheet.Range(0, 2, length - 1, 2)));
            
            // Save it as XLS
            spreadsheet.SaveAs("Output.xls");

            // Close the document
            spreadsheet.Close();

            // Cleanup
            spreadsheet.Dispose();

            // Open generated XLS file in default associated application
            Process.Start("Output.xls");
        }
    }
}
