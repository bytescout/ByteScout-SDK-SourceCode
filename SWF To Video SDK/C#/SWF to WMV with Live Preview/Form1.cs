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
using System.Drawing;
using System.Windows.Forms;

using BytescoutSWFToVideo;

namespace PreviewContext
{
    public partial class Form1 : Form
    {
        Graphics m_g;
        IntPtr m_hdc;
        SWFToVideoClass swf = new SWFToVideoClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (!swf.IsRunning)
            {
                swf.SWFConversionMode = SWFConversionModeType.SWFWithLiveData;
                swf.ConversionTimeOut = 15000;

                swf.InputSWFFileName = "test.swf";

		// you may calculate output video duration using information about the the source swf movie
		// WARNING #1: this method to calculate the output video duration is not working for movies with dynamic scenes 
		// and interactive scripts as in these movies it is not possible to calculate the precise duration of the movie 
		// WARNING #2: you should set the input swf or flv filename (or url) before this calculation

		// So the movie duration is calculated as the following:
		// as swf frame count (number of frames in the swf) / movieFPS (frames per second defined in swf)
		// and then multiplied by 1000 (as we are setting the .ConverstionTimeout in milliseconds)
		// as the following (uncomment if you want to set the length of the output video to the same as the original swf)
		// or as the following source code (uncomment to enable):

		// swf.ConversionTimeout = 1000 * (swf.FrameCount / swf.MovieFPS)

                swf.OutputVideoFileName = "test.wmv";
                swf.OutputWidth = 640;
                swf.OutputHeight = 480;

				swf.SetPreviewContext(m_hdc.ToInt32(), 0, 0, pictureBox1.Width, pictureBox1.Height, 30);
                swf.Run();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            m_g = pictureBox1.CreateGraphics();
            m_hdc = m_g.GetHdc();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_g.ReleaseHdc(m_hdc);
            m_g.Dispose();

			// release resources
			System.Runtime.InteropServices.Marshal.ReleaseComObject(swf);
			swf = null;

        }
    }
}
