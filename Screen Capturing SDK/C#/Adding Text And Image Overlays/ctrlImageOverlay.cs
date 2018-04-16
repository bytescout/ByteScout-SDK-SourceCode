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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BytescoutScreenCapturingLib;

namespace ScreenCapturingClient
{
    public partial class ctrlImageOverlay : UserControl
    {
        ImageOverlay _imageOverlay = null;
        ICapturer _capturer = null;
        int _index = -1;
        bool _isLoaded = false;

        public ctrlImageOverlay()
        {
            InitializeComponent();
        }

        public ctrlImageOverlay(ImageOverlay imageOverlay, int index, ICapturer capturer)
        {
            InitializeComponent();

            _imageOverlay = imageOverlay;
            _index = index;
            _capturer = capturer;

            nmLeft.Value = _imageOverlay.Left;
            nmTop.Value = _imageOverlay.Top;
            txtFileName.Text = _imageOverlay.FileName;
            chkVisible.Checked = _imageOverlay.Visible;

            txtFileName.Enabled = false;
            btnBrowseFile.Enabled = false;

            _isLoaded = true;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Bitmap Files (*.bmp)|*.bmp|Png Files (*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = dlg.FileName;
            }
        }

        private void nmLeft_ValueChanged(object sender, EventArgs e)
        {
            if (_imageOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayPosition(_index, (int)nmLeft.Value, (int)nmTop.Value);
                _imageOverlay.Left = (int)nmLeft.Value;
            }
        }

        private void nmTop_ValueChanged(object sender, EventArgs e)
        {
            if (_imageOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayPosition(_index, (int)nmLeft.Value, (int)nmTop.Value);
                _imageOverlay.Top = (int)nmTop.Value;
            }
        }

        public ImageOverlay GetImageOverlay()
        {
            if (_imageOverlay == null)
            {
                _imageOverlay = new ImageOverlay();
                _imageOverlay.Left = (int)nmLeft.Value;
                _imageOverlay.Top = (int)nmTop.Value;
                _imageOverlay.Visible = chkVisible.Checked;
                _imageOverlay.FileName = txtFileName.Text;
            }

            return _imageOverlay;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (_imageOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayVisibility(_index, chkVisible.Checked);
                _imageOverlay.Visible = chkVisible.Checked;
            }
        }
    }
}
