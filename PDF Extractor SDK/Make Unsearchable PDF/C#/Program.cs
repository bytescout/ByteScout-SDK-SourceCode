//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using Bytescout.PDFExtractor;

namespace MakeUnsearchablePDF
{
    class Program
    {
        static void Main()
        {
            // Create Bytescout.PDFExtractor.UnsearchablePDFMaker instance
            UnsearchablePDFMaker unsearchablePDFMaker = new UnsearchablePDFMaker();
            unsearchablePDFMaker.RegistrationName = "demo";
            unsearchablePDFMaker.RegistrationKey = "demo";

            // Load sample PDF document
            unsearchablePDFMaker.LoadDocumentFromFile("sample1.pdf");

            // Set PDF rendering resolution to 150 DPI. Higher value - better quality, but larger output file.
            unsearchablePDFMaker.RenderingResolution = 150;
            // Set embedded images format
            unsearchablePDFMaker.ImageFormat = EmbeddedImageFormat.PNG;

            // Process the document 
            unsearchablePDFMaker.MakePDFUnsearchable("result.pdf");

            // Open the result PDF file in default associated application
            System.Diagnostics.Process.Start("result.pdf");
        }
    }
}
