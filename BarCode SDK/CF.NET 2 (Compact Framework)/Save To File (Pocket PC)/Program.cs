//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.BarCode;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Barcode bc = new Barcode(SymbologyType.DataMatrix);
            bc.Value = "012345test";
            bc.SaveImage("TestBarcode.gif");

        }
    }
}
