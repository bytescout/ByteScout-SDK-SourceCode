//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace MergeDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputFiles = new string[] {"sample1.pdf", "sample2.pdf", "sample3.pdf"};

            using (DocumentMerger merger = new DocumentMerger("demo", "demo"))
            {
                merger.Merge(inputFiles, "result.pdf");
            }

            Process.Start("result.pdf");
        }
    }
}
