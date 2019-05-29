//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using Bytescout.Watermarking;
using Bytescout.Watermarking.Presets;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Watermarker instance
            Watermarker waterMarker = new Watermarker();

            // Initialize library
            waterMarker.InitLibrary("demo", "demo");

            // Set input file name
            string inputFilePath = "my_sample_image.jpg";
            // Set output file title
            string outputFilePath = "my_sample_output.jpg";

            // Add image to apply watermarks to
            waterMarker.AddInputFile(inputFilePath, outputFilePath);

            // Create new watermark
            TextAnnotation preset = new TextAnnotation();

            // Set text with macros
            // complete list of available macros please see in the SDK documentation 
            preset.Text = @"Date Time: {{LOCAL_DATE_LONG}} {{LOCAL_TIME}} "+
            "\nFilename: {{FILENAME}}\n" +
            "Manufacturer: {{EXIF_EQUIPMENT_MANUFACTURER}}\n" +
            "Model: {{EXIF_EQUIPMENT_MODEL}}\n" +
            "Software: {{EXIF_SOFTWARE_USED}}\n" +
            "Date/Time: {{EXIF_ORIGINAL_DATE}}\n" +
            "Exposure Time: {{EXIF_EXPOSURE_TIME}} sec\n" +
            "Exposure Program: {{EXIF_EXPOSURE_PROGRAM}}\n" +
            "Exposure Bias: {{EXIF_EXPOSURE_BIAS}} EV\n" +
            "F Number: F {{EXIF_F_NUMBER}}\n" +
            "ISO Speed Rating: ISO {{EXIF_ISO_SPEED}}\n" +
            "Flash: {{EXIF_FLASH}}\n" +
            "Focal Length: {{EXIF_FOCAL_LENGTH}} mm\n" +
            "Metering Mode: {{EXIF_METERING_MODE}}";


            // Set watermark font
            preset.Font = new WatermarkFont("Tahoma", FontStyle.Regular, FontSizeType.Percents, 2); // set font size to 2% of the image size

            waterMarker.OutputOptions.OutputDirectory = ".";
            // Add watermark to watermarker
            waterMarker.AddWatermark(preset);

            // Apply watermarks
            waterMarker.Execute();

            // open generated image file in default image viewer installed in Windows
            Process.Start(outputFilePath);
        }
    }
}
