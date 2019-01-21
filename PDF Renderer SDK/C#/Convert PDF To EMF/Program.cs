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

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("image0.emf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
