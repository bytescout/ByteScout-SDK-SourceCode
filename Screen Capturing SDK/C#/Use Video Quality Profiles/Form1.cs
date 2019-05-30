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


using BytescoutScreenCapturingLib;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        #region Fields

        private BytescoutScreenCapturingLib.Capturer _capturer;
        private bool _converting = false;
        private bool _paused = false;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load Event Hanlde
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _cmbQuality.DataSource = Enum.GetValues(typeof(VideoQualityProfileType));
                _cmbQuality.SelectedIndex = 0;

                _capturer = new BytescoutScreenCapturingLib.Capturer();
                _capturer.RegistrationName = "demo";
                _capturer.RegistrationKey = "demo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handle screen capture button click
        /// </summary>
        private void _btnScreenCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (_converting)
                {
                    if (_capturer.IsRunning)
                    {
                        _capturer.Stop();
                    }

                    StopCapturer();

                    _btnPauseScreenCapture.Visible = false;
                }
                else
                {
                    _capturer.OutputWidth = (int)_numWidth.Value;
                    _capturer.OutputHeight = (int)_numHeight.Value;
                    _capturer.FPS = (float)_numFramerate.Value;

                    _capturer.SetVideoQualityProfile((BytescoutScreenCapturingLib.VideoQualityProfileType)_cmbQuality.SelectedItem);

                    _lblBitrate.Text = string.Format("Bitrate: {0}[kbps], Wmv Quality: {1}, MinQuantizer: {2}, MaxQuantizer: {3}",
                                            _capturer.WMVVideoBitrate / 1000, _capturer.WmvVideoQuality,
                                            _capturer.WebmMinQuantizer, _capturer.WebmMaxQuantizer);

                    _capturer.AnimateMouseClicks = true;
                    _capturer.AnimateMouseButtons = true;
                    _capturer.CapturingType = BytescoutScreenCapturingLib.CaptureAreaType.catScreen;

                    _capturer.OutputFileName = _txtOutputFile.Text;

                    _capturer.EncoderThreadsCount = (int)_numEncodingThreads.Value;

                    _capturer.AudioEnabled = false;

                    _capturer.Run();

                    _converting = true;
                    _btnScreenCapture.Text = "Stop screen capture";

                    _btnPauseScreenCapture.Visible = true;
                    _paused = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Pause screen capture
        /// </summary>
        private void _btnPauseScreenCapture_Click(object sender, EventArgs e)
        {
            if (_paused)
            {
                _capturer.Run();
                _btnPauseScreenCapture.Text = "Pause Screen Capture";
                _paused = false;
            }
            else
            {
                _capturer.Pause();
                _btnPauseScreenCapture.Text = "Resume Screen Capture";
                _paused = true;
            }
        }

        /// <summary>
        /// Stop Capture
        /// </summary>
        private void StopCapturer()
        {
            _converting = false;
            _btnScreenCapture.Text = "Screen capture video";

            // Open captured video
            Process.Start(_txtOutputFile.Text);
        }

    }
}
