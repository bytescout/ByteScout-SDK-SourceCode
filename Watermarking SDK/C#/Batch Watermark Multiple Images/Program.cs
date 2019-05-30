//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
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

            // Add images to apply watermarks to
            waterMarker.AddInputFile("my_sample_image2.jpg", "my_sample_image2_output.jpg");
            waterMarker.AddInputFile("my_sample_image3.jpg", "my_sample_image3_output.jpg");

            // Create new watermark
            TextFitsPage preset = new TextFitsPage();

            // Set watermark text
            preset.Text = "Bytescout Watermarking";

            // Add watermark to watermarker
            waterMarker.AddWatermark(preset);


            // Apply watermarks
            waterMarker.Execute();
        }
    }
}
