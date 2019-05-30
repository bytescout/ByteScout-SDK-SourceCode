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
using System.Windows.Forms;

using BytescoutImageToVideo;

namespace ConversionProgressGUI
{
    public partial class Form1 : Form
    {
		public const int WM_APP = 0x8000;
		public const int WM_CONVERSION_PROGRESS = WM_APP + 1;

		ImageToVideo converter = new ImageToVideo();

        public Form1()
        {
            InitializeComponent();

			converter.RegistrationName = "demo";
			converter.RegistrationKey = "demo";
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (!converter.IsRunning)
            {
                // Add images and set the duration for every slide
				Slide slide;
				slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide1.jpg");
				slide.Duration = 3000; // 3000ms = 3s
				slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide2.jpg");
				slide.Duration = 3000;
				slide = converter.AddImageFromFileName("..\\..\\..\\..\\slide3.jpg");
				slide.Duration = 3000;

				// Set output video size
				converter.OutputWidth = 400;
				converter.OutputHeight = 300;

				// Set output video file name
				converter.OutputVideoFileName = "result.wmv";

				// Set progress notification target window
				converter.SetProgressNotifyWindow(Handle.ToInt32(), WM_CONVERSION_PROGRESS, 0);

				// Run the conversion
				converter.Run();
            }
        }

		protected override void WndProc(ref Message m)
		{
			if (m.HWnd == Handle && m.Msg == WM_CONVERSION_PROGRESS)
			{
				progressBar1.Value = m.WParam.ToInt32();
			}

			base.WndProc(ref m);
		}
    }
}
