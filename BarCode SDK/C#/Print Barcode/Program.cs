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

using Bytescout.BarCode;

namespace printBarcodeCSharp2008
{
    class Program
    {
        static void Main(string[] args)
        {
            BarcodePrinter bPrinter = new BarcodePrinter();
            bPrinter.Print(SymbologyType.Code39, "0123456789", "Case Number", 3.5f, 1f);
        }
    }
}
