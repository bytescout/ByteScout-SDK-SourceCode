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
