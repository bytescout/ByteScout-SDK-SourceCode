//*******************************************************************
//       ByteScout Screen Capturing SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
