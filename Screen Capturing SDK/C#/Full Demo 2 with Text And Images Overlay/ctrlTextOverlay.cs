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
    public partial class ctrlTextOverlay : UserControl
    {
        TextOverlay _textOverlay = null;
        ICapturer _capturer = null;
        int _index = -1;
        bool _isLoaded = false;

        public ctrlTextOverlay()
        {
            InitializeComponent();
            pnlBackColor.BackColor = Color.Transparent;

        }
        public ctrlTextOverlay(TextOverlay textOverlay, int index, ICapturer capturer)
        {
            InitializeComponent();

            _textOverlay = textOverlay;
            _index = index;
            _capturer = capturer;

            nmLeft.Value = _textOverlay.Left;
            nmTop.Value = _textOverlay.Top;
            txtText.Text = _textOverlay.Text;
            txtFont.Text = _textOverlay.Font.Name;
            txtFont.Font = _textOverlay.Font;
            pnlColor.BackColor = _textOverlay.Color;
            chkVisible.Checked = _textOverlay.Visible;
            btnUpdate.Visible = true;

            chkBackColor.Checked = _textOverlay.BackColor != Color.Transparent;
            btnBackColor.Enabled = _textOverlay.BackColor != Color.Transparent;
            pnlBackColor.BackColor = _textOverlay.BackColor;

            txtFont.Enabled = false;
            btnFont.Enabled = false;
            pnlColor.Enabled = false;
            btnColor.Enabled = false;
            chkBackColor.Enabled = false;
            btnBackColor.Enabled = false;
            pnlBackColor.Enabled = false;

            _isLoaded = true;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = txtFont.Font;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFont.Font = dlg.Font;
                txtFont.Text = dlg.Font.Name;

                if (_textOverlay != null)
                {
                    _textOverlay.Font = dlg.Font;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;
            dlg.AnyColor = true;
            dlg.FullOpen = true;
            dlg.CustomColors = new int[] { Color.Transparent.ToArgb() };
           
            dlg.Color = pnlColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pnlColor.BackColor = dlg.Color;

                if (_textOverlay != null)
                {
                    _textOverlay.Color = dlg.Color;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_textOverlay != null && _capturer != null && _index != -1)
            {
                _capturer.UpdateTextOverlay(_index, txtText.Text);
                _textOverlay.Text = txtText.Text;
            }
        }

        private void nmLeft_ValueChanged(object sender, EventArgs e)
        {
            if (_textOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayPosition(_index, (int)nmLeft.Value, (int)nmTop.Value);
                _textOverlay.Left = (int)nmLeft.Value; ;
            }
        }

        private void nmTop_ValueChanged(object sender, EventArgs e)
        {
            if (_textOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayPosition(_index, (int)nmLeft.Value, (int)nmTop.Value);
                _textOverlay.Top = (int)nmTop.Value;
            }
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (_textOverlay != null && _capturer != null && _index != -1 && _isLoaded)
            {
                _capturer.UpdateOverlayVisibility(_index, chkVisible.Checked);
                _textOverlay.Visible = chkVisible.Checked;
            }
        }

        public TextOverlay GetTextOverlay()
        {
            if (_textOverlay == null)
            {
                _textOverlay = new TextOverlay();

                _textOverlay.Left = (int)nmLeft.Value;
                _textOverlay.Top = (int)nmTop.Value;
                _textOverlay.Text = txtText.Text;
                _textOverlay.Font = txtFont.Font;
                _textOverlay.Color = pnlColor.BackColor;
                _textOverlay.Visible = chkVisible.Checked;
                _textOverlay.BackColor = pnlBackColor.BackColor;
            }

            return _textOverlay;
        }

        private void chkBackColor_CheckedChanged(object sender, EventArgs e)
        {
            btnBackColor.Enabled = chkBackColor.Checked;
            pnlBackColor.Enabled = chkBackColor.Checked;
            if (!chkBackColor.Checked)
            {
                pnlBackColor.BackColor = Color.Transparent;
            }
            if (_textOverlay != null)
            {
                _textOverlay.BackColor = pnlBackColor.BackColor;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.AllowFullOpen = true;
            dlg.AnyColor = true;
            dlg.FullOpen = true;

            dlg.Color = pnlBackColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pnlBackColor.BackColor = dlg.Color;

                if (_textOverlay != null)
                {
                    _textOverlay.BackColor = dlg.Color;
                }
            }
        }
       
    }
}
