//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace RotateDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "sample1.pdf";

            using (DocumentRotator rotator = new DocumentRotator("demo", "demo"))
            {
                rotator.Rotate(inputFile, "result.pdf", RotationAngle.Deg90);
            }

            Process.Start("result.pdf");
        }
    }
}
