//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Windows.Forms;

namespace ScreenCapturing
{
	static class Program
	{
		public static Config Cfg = null;

		public static string RegistryKey = "Software\\Screen Capturing";
		public static string PostCommand = String.Empty;

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Cfg = new Config();

			MainForm mainForm = new MainForm();

			Application.Run(mainForm);
		}
	}
}
