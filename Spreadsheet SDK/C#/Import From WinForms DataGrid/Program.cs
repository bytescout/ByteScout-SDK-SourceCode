//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Windows.Forms;

namespace ImportExportFromWinFormsDataGrid.CSharp
{
    class Program
    {
		[STAThread]
        static void Main(string[] args)
        {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
        }
    }
}
