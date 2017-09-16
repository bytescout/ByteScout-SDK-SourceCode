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


using System;
using System.IO;
using System.Threading;
using Bytescout.BarCodeReader;

namespace ParallelDecoding
{
    class Program
    {
        const string InputFile = "example.pdf";

        static void Main()
        {
            ThreadPool.SetMaxThreads(8, 8);

            const int numberOfRuns = 10;
            ManualResetEvent[] doneEvents = new ManualResetEvent[numberOfRuns];


            for (int i = 0; i < numberOfRuns; i++)
            {
                doneEvents[i] = new ManualResetEvent(false);

                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state)
                {
                    int threadIndex = (int) state;

                    Reader reader = new Reader();
                    reader.RegistrationName = "demo";
                    reader.RegistrationKey = "demo";

                    // Set barcode type to find
                    reader.BarcodeTypesToFind.Code128 = true;

                    // Read barcodes
                    FoundBarcode[] barcodes = reader.ReadFrom(InputFile);

                    foreach (FoundBarcode barcode in barcodes)
                    {
                        Console.WriteLine("Thread #{0}\r\n  Found barcode with type '{1}' and value '{2}'", threadIndex, barcode.Type, barcode.Value);
                    }

                    doneEvents[threadIndex].Set();
                }), i);
            }

            WaitHandle.WaitAll(doneEvents);

            Console.WriteLine("All threads done.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
