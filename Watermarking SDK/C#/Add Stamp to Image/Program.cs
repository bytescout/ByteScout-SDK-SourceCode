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

            foreach (string stampType in Stamp.PresetImages)
            {
                // Set output file title
                string outputFilePath = "my_sample_output_" + stampType + ".jpg";

                // Add image to apply watermarks to
                waterMarker.AddInputFile(inputFilePath, outputFilePath);

                // Set output directory
                waterMarker.OutputOptions.OutputDirectory = ".";

                // Create new watermark
                Stamp preset = new Stamp();

                // Set stamp type
                preset.ImageFile = stampType;

                // Add watermark to watermarker
                waterMarker.AddWatermark(preset);

                // Apply watermarks
                waterMarker.Execute();

                // Clear all settings
                waterMarker.Clear();
            }
        }
    }
}
