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

            // Add a data for Surface chart
            int count = 10;
            double step = 2 * Math.PI / (count - 1);
            for (int i = 0; i < count; i++)
                for (int j = 0; j < count; j++)
                    sheet[i, j].Value = Math.Sin(step * Math.Sqrt(i * i + j * j));

            // Add charts to worksheet
            Chart surfaceChart = sheet.Charts.AddChartAndFitInto(11, 1, 28, 8, ChartType.Surface);
            for (int i = 0; i < count; i++)
                surfaceChart.SeriesCollection.Add(new Series(sheet.Range(0, i, 9, i)));

            surfaceChart = sheet.Charts.AddChartAndFitInto(11, 10, 28, 17, ChartType.SurfaceWireframe);
            for (int i = 0; i < count; i++)
                surfaceChart.SeriesCollection.Add(new Series(sheet.Range(0, i, 9, i)));

            surfaceChart = sheet.Charts.AddChartAndFitInto(29, 1, 46, 8, ChartType.SurfaceTopView);
            for (int i = 0; i < count; i++)
                surfaceChart.SeriesCollection.Add(new Series(sheet.Range(0, i, 9, i)));

            surfaceChart = sheet.Charts.AddChartAndFitInto(29, 10, 46, 17, ChartType.SurfaceTopViewWireframe);
            for (int i = 0; i < count; i++)
                surfaceChart.SeriesCollection.Add(new Series(sheet.Range(0, i, 9, i)));

            // Save it as XLS
            spreadsheet.SaveAs("Output.xls");

            // Close the document
            spreadsheet.Close();

            // Open generated XLS file in default associated application
            Process.Start("Output.xls");
        }
    }
}
