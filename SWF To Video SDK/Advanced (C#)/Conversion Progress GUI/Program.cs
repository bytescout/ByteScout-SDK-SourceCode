//*******************************************************************
//       ByteScout SWF To Video SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

// x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode. WHY? Because flash is not supported on x64 platform currently at all
using System;
using System.Windows.Forms;

namespace ConversionProgressGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
