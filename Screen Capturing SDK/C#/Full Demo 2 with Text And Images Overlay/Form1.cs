//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BytescoutScreenCapturingLib;

namespace ScreenCapturingClient
{
    public partial class Form1 : Form
    {
        ICapturer _capturer;
        int _previewHdc;
        Graphics _previewGraphics;
        private bool _isPaused = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitCapturer()
        {
            _capturer = new CapturerClass();
            _capturer.RegistrationName = "demo";
            _capturer.RegistrationKey = "demo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                InitCapturer();

                cmbWebCam.Items.Clear();
                for (int i = 0; i < _capturer.WebCamCount; i++)
                {
                    cmbWebCam.Items.Add(_capturer.GetWebCamName(i));
                }
                if (cmbWebCam.Items.Count > 0)
                    cmbWebCam.SelectedIndex = 0;

                cmbVideoCodec.Items.Clear();
                for (int i = 0; i < _capturer.VideoCodecsCount; i++)
                {
                    cmbVideoCodec.Items.Add(_capturer.GetVideoCodecName(i));
                }
                if (cmbVideoCodec.Items.Count > 0)
                    cmbVideoCodec.SelectedIndex = 0;

                cmbAudioDevices.Items.Clear();
                for (int i = 0; i < _capturer.AudioDeviceCount; i++)
                {
                    cmbAudioDevices.Items.Add(_capturer.GetAudioDeviceName(i));
                }
                if (cmbAudioDevices.Items.Count > 0)
                    cmbAudioDevices.SelectedIndex = 0;

                cmbAudioCodecs.Items.Clear();
                for (int i = 0; i < _capturer.AudioCodecsCount; i++)
                {
                    cmbAudioCodecs.Items.Add(_capturer.GetAudioCodecName(i));
                }
                if (cmbAudioCodecs.Items.Count > 0)
                    cmbAudioCodecs.SelectedIndex = 0;

                cmbCaptureAreaType.Items.Clear();
                cmbCaptureAreaType.DataSource = Enum.GetValues(typeof(CaptureAreaType));
                cmbCaptureAreaType.SelectedIndex = 0;

                cmbMotionDetection.Items.Clear();
                cmbMotionDetection.DataSource = Enum.GetValues(typeof(RecordingModeType));
                cmbMotionDetection.SelectedIndex = 0;

                cmbCurrentMonitor.Items.Add(-1);
                cmbCurrentMonitor.Enabled = false;
                if (_capturer.MonitorCount > 1)
                {
                    cmbCurrentMonitor.Enabled = true;
                    for (int i = 0; i < _capturer.MonitorCount; i++)
                    {
                        cmbCurrentMonitor.Items.Add(i);
                    }
                }
                cmbCurrentMonitor.SelectedIndex = 0;

                HandleMonitors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkEnableAudio_CheckedChanged(object sender, EventArgs e)
        {
            cmbAudioDevices.Enabled = chkEnableAudio.Checked;
            cmbAudioCodecs.Enabled = chkEnableAudio.Checked;
        }

        private void chkEnableWebcam_CheckedChanged(object sender, EventArgs e)
        {
            _capturer.AddWebCamVideo = chkEnableWebcam.Checked;

            cmbWebCam.Enabled = chkEnableWebcam.Checked;
            nmWebCamLeft.Enabled = chkEnableWebcam.Checked;
            nmWebCamTop.Enabled = chkEnableWebcam.Checked;
            nmWebCamWidth.Enabled = chkEnableWebcam.Checked;
            nmWebCamHeight.Enabled = chkEnableWebcam.Checked;
        }

        private void btnOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Windows Media Video (*.wmv)|*.wmv| AVI video (*.avi)|*.avi";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = dlg.FileName;
            }
        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files (*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLogFile.Text = dlg.FileName;
            }
        }

        bool _captureStarted = false;
        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (_capturer.IsRunning)
                {
                    _capturer.Stop();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(_capturer);
                    _capturer = null;
                    InitCapturer();

                    // lstOverlays.Items.Clear();
                    btnRecord.Text = "Record";
                    tabControl1.Enabled = true;
                    lblStatus.Text = "Stopped";
                    timer1.Stop();
                    _captureStarted = false;

                    btnPause.Enabled = false;
                    _isPaused = false;
                }
                else
                {
                    if (!_isPaused)
                    {
                        _capturer.AudioEnabled = chkEnableAudio.Checked;
                        if (chkEnableAudio.Checked)
                        {
                            _capturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString();
                            //_capturer.CurrentAudioCodecName = cmbAudioCodecs.SelectedItem.ToString();
                        }

                        _capturer.AddWebCamVideo = chkEnableWebcam.Checked;
                        if (chkEnableWebcam.Checked)
                        {
                            _capturer.SetWebCamVideoRectangle((int)nmWebCamLeft.Value, (int)nmWebCamTop.Value, (int)nmWebCamWidth.Value, (int)nmWebCamHeight.Value);
                            _capturer.CurrentWebCamName = cmbWebCam.SelectedItem.ToString();
                        }

                        //_capturer.CurrentVideoCodecName = cmbVideoCodec.SelectedItem.ToString();

                        if (!string.IsNullOrEmpty(txtLogFile.Text) && cbWriteLog.Checked)
                        {
                            _capturer.SetLogFile(txtLogFile.Text);
                        }

                        _capturer.OutputFileName = txtOutputFile.Text;

                        _capturer.CapturingType = (CaptureAreaType)cmbCaptureAreaType.SelectedItem;

                        _previewGraphics = pnlPreview.CreateGraphics();
                        _previewHdc = _previewGraphics.GetHdc().ToInt32();
                        _capturer.SetFullPreviewContext(_previewHdc, 0, 0, pnlPreview.Width, pnlPreview.Height, 5);

                        _capturer.CaptureRectLeft = (int)nmCaptureLeft.Value;
                        _capturer.CaptureRectTop = (int)nmCaptureTop.Value;
                        _capturer.CaptureRectWidth = (int)nmCaptureWidth.Value;
                        _capturer.CaptureRectHeight = (int)nmCaptureHeight.Value;

                        _capturer.OutputWidth = (int)nmOutputWidth.Value;
                        _capturer.OutputHeight = (int)nmOutputHeight.Value;


                        foreach (ListViewItem item in lstOverlays.Items)
                        {
                            Overlay overlay = item.Tag as Overlay;
                            if (overlay is TextOverlay)
                            {
                                TextOverlay textOverlay = overlay as TextOverlay;

                                int a = (int)textOverlay.BackColor.A;
                                //_capturer.AddTextOverlay(textOverlay.Left, textOverlay.Top, textOverlay.Text, textOverlay.Font.Name,
                                //                        (int)textOverlay.Font.Size,textOverlay.Font.Bold, textOverlay.Font.Italic,
                                //                        textOverlay.Font.Underline, (uint)ColorTranslator.ToOle(textOverlay.Color));
                                _capturer.AddTextOverlayWithBackground2(textOverlay.Left, textOverlay.Top, textOverlay.Text, textOverlay.Font.Name,
                                                        (int)textOverlay.Font.Size, textOverlay.Font.Bold, textOverlay.Font.Italic,
                                                        textOverlay.Font.Underline,
                                                        textOverlay.Color.R, textOverlay.Color.G, textOverlay.Color.B, textOverlay.Color.A,
                                                        textOverlay.BackColor.R, textOverlay.BackColor.G, textOverlay.BackColor.B, textOverlay.BackColor.A);
                            }
                            else if (overlay is ImageOverlay)
                            {
                                ImageOverlay imageOverlay = overlay as ImageOverlay;
                                _capturer.AddImageOverlay(imageOverlay.Left, imageOverlay.Top, imageOverlay.FileName);
                            }
                        }

                        _capturer.RecordingMode = (RecordingModeType)cmbMotionDetection.SelectedItem;
                        _capturer.NoMotionDetectedActionInterval = (int)nmMotionInterval.Value;
                        _capturer.NoMotionDetectedActionSensitivity = (double)nmMotionSensitivity.Value;

                        _capturer.MonitorIndex = (int)cmbCurrentMonitor.SelectedItem;
                    }

                    _capturer.Run();
                    

                    btnRecord.Text = "Stop";
                    tabControl1.Enabled = false;
                    lblStatus.Text = "Running";
                    _captureStarted = true;
                    timer1.Start();

                    _isPaused = false;
                    btnPause.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddTextOverlay_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewOverlay frm = new frmNewOverlay(true);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    TextOverlay textOverlay = frm.GetOverlay() as TextOverlay;
                    if (_capturer.IsRunning)
                    {
                        //_capturer.AddTextOverlay(overlay.Left, overlay.Top, overlay.Text, overlay.Font.Name, (int)overlay.Font.Size,
                        //                        overlay.Font.Bold, overlay.Font.Italic, overlay.Font.Underline, (uint)ColorTranslator.ToOle(overlay.Color));
                        _capturer.AddTextOverlayWithBackground2(textOverlay.Left, textOverlay.Top, textOverlay.Text, textOverlay.Font.Name,
                                                   (int)textOverlay.Font.Size, textOverlay.Font.Bold, textOverlay.Font.Italic,
                                                   textOverlay.Font.Underline,
                                                   textOverlay.Color.R, textOverlay.Color.G, textOverlay.Color.B, textOverlay.Color.A,
                                                   textOverlay.BackColor.R, textOverlay.BackColor.G, textOverlay.BackColor.B, textOverlay.BackColor.A);
                    }

                    ListViewItem item = new ListViewItem();
                    item.Text = textOverlay.ToString();
                    item.Tag = textOverlay;
                    lstOverlays.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddImageOverlay_Click(object sender, EventArgs e)
        {
            try
            {
                frmNewOverlay frm = new frmNewOverlay(false);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ImageOverlay overlay = frm.GetOverlay() as ImageOverlay;

                    if (_capturer.IsRunning)
                    {
                        _capturer.AddImageOverlay(overlay.Left, overlay.Top, overlay.FileName);
                    }

                    ListViewItem item = new ListViewItem();
                    item.Text = overlay.ToString();
                    item.Tag = overlay;
                    lstOverlays.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveOverlay_Click(object sender, EventArgs e)
        {
            pnlCurrentOverlay.Controls.Clear();
            if (lstOverlays.SelectedItems.Count > 0)
            {
                if (_capturer.IsRunning)
                {
                    _capturer.RemoveOverlay(lstOverlays.Items.IndexOf(lstOverlays.SelectedItems[0]));
                }
                lstOverlays.Items.Remove(lstOverlays.SelectedItems[0]);

            }
        }

        private void lstOverlays_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCurrentOverlay.Controls.Clear();
            if(lstOverlays.SelectedItems.Count > 0)
            {
                Overlay overlay = lstOverlays.SelectedItems[0].Tag as Overlay;
                if (overlay is TextOverlay)
                {
                    ctrlTextOverlay ctrl = new ctrlTextOverlay(overlay as TextOverlay, lstOverlays.Items.IndexOf(lstOverlays.SelectedItems[0]), _capturer);
                    ctrl.Dock = DockStyle.Fill;

                    pnlCurrentOverlay.Controls.Add(ctrl);
                }
                else if (overlay is ImageOverlay)
                {
                    ctrlImageOverlay ctrl = new ctrlImageOverlay(overlay as ImageOverlay, lstOverlays.Items.IndexOf(lstOverlays.SelectedItems[0]), _capturer);
                    ctrl.Dock = DockStyle.Fill;

                    pnlCurrentOverlay.Controls.Add(ctrl);
                }
            }
        }

        private void cmbMotionDetection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecordingModeType rmt = (RecordingModeType)cmbMotionDetection.SelectedItem;
            bool enabled = rmt != RecordingModeType.rmtMonitor && rmt != RecordingModeType.rmtRecord;
            nmMotionInterval.Enabled = enabled;
            nmMotionSensitivity.Enabled = enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_isPaused)
            {
                lblStatus.Text = _capturer.IsRunning ? "Running" : "Stopped";
            }
            else
            {
                lblStatus.Text = "Paused";
            }

            if (_captureStarted && !_capturer.IsRunning && !_isPaused)
            {
                lblStatus.Text = "Restarting capturer...";

                System.Runtime.InteropServices.Marshal.ReleaseComObject(_capturer);
                _capturer = null;
                InitCapturer();

                lstOverlays.Items.Clear();
                btnRecord.Text = "Record";
                tabControl1.Enabled = true;
                lblStatus.Text = "Stopped";
                timer1.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_capturer.IsRunning)
            {
                _capturer.Stop();
            }
            System.Runtime.InteropServices.Marshal.ReleaseComObject(_capturer);
            _capturer = null;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_capturer.IsRunning)
            {
                _capturer.Pause();
                btnPause.Enabled = false;
                btnRecord.Text = "Run";
                _isPaused = true;
            }
        }

        private void HandleMonitors()
        {
            txtMonitorCount.Text = _capturer.MonitorCount.ToString();
            txtMonitorLeft.Text = _capturer.MonitorLeft.ToString();
            txtMonitorTop.Text = _capturer.MonitorTop.ToString();
            txtMonitorWidth.Text = _capturer.MonitorWidth.ToString();
            txtMonitorHeight.Text = _capturer.MonitorHeight.ToString();
        }

        private void cmbCurrentMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_capturer != null)
            {
                _capturer.MonitorIndex = cmbCurrentMonitor.SelectedIndex - 1;
                HandleMonitors();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtOutputFile.Text.Trim()))
            { 
                System.Diagnostics.Process.Start(txtOutputFile.Text.Trim());
            }
        }

        
    }
}
