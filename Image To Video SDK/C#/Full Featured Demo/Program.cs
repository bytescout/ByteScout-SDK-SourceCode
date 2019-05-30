//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ImageToVideoDemo
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Thread_UnhandledException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject != null)
            {
                ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog((Exception) e.ExceptionObject);

                if (exceptionDialog.ShowDialog() == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }

        private static void Thread_UnhandledException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception != null)
            {
                ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog(e.Exception);

                if (exceptionDialog.ShowDialog() == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }
	}
}
