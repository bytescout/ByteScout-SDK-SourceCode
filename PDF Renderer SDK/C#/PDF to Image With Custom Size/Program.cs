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
using System.Collections.Generic;
using System.Diagnostics;
using Bytescout.PDFRenderer;


namespace PDF2ImageWithCustomSize
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify Image Generation Inputs
            ImageGenerationInputs imageGenerationInputs = new ImageGenerationInputs();

            imageGenerationInputs.AddCustomSize(width: 320, height: 420);
            imageGenerationInputs.AddCustomSize(width: 600, height: 800);

            imageGenerationInputs.EnableSaveAsPng = true;
            imageGenerationInputs.EnableSaveAsJpeg = true;
            imageGenerationInputs.EnableSaveAsTiff = true;

            // Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
            RasterRenderer renderer = new RasterRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Load PDF document
            renderer.LoadDocumentFromFile("multipage.pdf");

            // Specify Rendering Options to fine tune output generation
            RenderingOptions renderingOptions = new RenderingOptions();
            renderingOptions.TIFFCompression = TIFFCompression.None;
            renderingOptions.VectorSmoothingMode = GraphicsTransformationQuality.HighQuality;

            // Loop through each custom size specified
            foreach (var itmCustomSize in imageGenerationInputs.CustomSizes)
            {
                // Loop through all pages
                for (int pageIndex = 0; pageIndex < renderer.GetPageCount(); pageIndex++)
                {
                    // Perform save as PNG, if specified
                    if (imageGenerationInputs.EnableSaveAsPng)
                    {
                        var pngImageName = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}_page{pageIndex + 1}.png";

                        // Save png image per page, per custom size
                        renderer.Save(
                            destFileName: pngImageName,
                            outputFormat: RasterImageFormat.PNG,
                            pageIndex: pageIndex,
                            width: itmCustomSize.Key,
                            height: itmCustomSize.Value,
                            renderingOptions: renderingOptions
                            );

                        Console.WriteLine(pngImageName + " - Generated");
                    }

                    // Perform save as JPG, if specified
                    if (imageGenerationInputs.EnableSaveAsJpeg)
                    {
                        var jpgImageName = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}_page{pageIndex + 1}.jpg";

                        // Save jpg image per page, per custom size
                        renderer.Save(
                            destFileName: jpgImageName,
                            outputFormat: RasterImageFormat.JPEG,
                            pageIndex: pageIndex,
                            width: itmCustomSize.Key,
                            height: itmCustomSize.Value,
                            renderingOptions: renderingOptions
                            );

                        Console.WriteLine(jpgImageName + " - Generated");
                    }
                }

                // Perform save as TIFF, if specified
                if (imageGenerationInputs.EnableSaveAsTiff)
                {
                    var tiffImageName = $"output_{itmCustomSize.Key}x{itmCustomSize.Value}.tiff";

                    // Save tiff image per page, per custom size
                    renderer.SaveMultipageTiff(
                        destFileName: tiffImageName,
                        startPageIndex: 0,
                        endPageIndex: renderer.GetPageCount() - 1,
                        width: itmCustomSize.Key,
                        height: itmCustomSize.Value,
                        renderingOptions: renderingOptions);

                    Console.WriteLine(tiffImageName + " - Generated");
                }
            }

            // Cleanup
            renderer.Dispose();

            Console.ReadLine();
        }
    }

    class ImageGenerationInputs
    {
        #region Constructor

        public ImageGenerationInputs()
        {
            CustomSizes = new List<KeyValuePair<int, int>>();
            EnableSaveAsPng = true;
        }

        #endregion

        #region Properties

        public List<KeyValuePair<int, int>> CustomSizes { get; set; }

        public bool EnableSaveAsPng { get; set; }

        public bool EnableSaveAsJpeg { get; set; }

        public bool EnableSaveAsTiff { get; set; }

        #endregion

        #region Methods

        public void AddCustomSize(int width, int height)
        {
            this.CustomSizes.Add(new KeyValuePair<int, int>(width, height));
        }

        #endregion
    }

}
