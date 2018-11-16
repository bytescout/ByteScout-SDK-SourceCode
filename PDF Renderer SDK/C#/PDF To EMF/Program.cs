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

using Bytescout.PDFRenderer;


namespace PDF2EMF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Bytescout.PDFRenderer.VectorRenderer object and register it.
            VectorRenderer renderer = new VectorRenderer();
            renderer.RegistrationName = "demo";
            renderer.RegistrationKey = "demo";

            // Load PDF document.
            renderer.LoadDocumentFromFile("vector_drawing.pdf");

            for (int i = 0; i < renderer.GetPageCount(); i++)
            {
                // Render document page to EMF image file
                renderer.Save("image" + i + ".emf", i, 300);
            }

            // Cleanup
            renderer.Dispose();

            // Open the first output file in default image viewer.
            System.Diagnostics.Process.Start("image0.emf");
        }
    }
}
