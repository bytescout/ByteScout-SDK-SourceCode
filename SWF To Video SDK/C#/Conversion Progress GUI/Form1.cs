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

using BytescoutSWFToVideo;

namespace ConversionProgressGUI
{
    public partial class Form1 : Form
    {
		public const int WM_APP = 0x8000;
		public const int WM_CONVERSION_PROGRESS = WM_APP + 1; 

        SWFToVideoClass swf = new SWFToVideoClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (!swf.IsRunning)
            {
                swf.SWFConversionMode = SWFConversionModeType.SWFAnimation;
                swf.ConversionTimeOut = 5000;

                swf.InputSWFFileName = "test.swf";
                swf.OutputVideoFileName = "test.wmv";

				swf.SetProgressNotifyWindow(Handle.ToInt32(), WM_CONVERSION_PROGRESS, 0);

                swf.Run();
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
