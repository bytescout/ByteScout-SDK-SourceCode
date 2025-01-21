//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
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
