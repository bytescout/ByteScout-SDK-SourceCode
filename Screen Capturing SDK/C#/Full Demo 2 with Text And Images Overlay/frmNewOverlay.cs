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

namespace ScreenCapturingClient
{
    public partial class frmNewOverlay : Form
    {
        public frmNewOverlay(bool textOverlay)
        {
            InitializeComponent();

            UserControl ctrl = null;

            if (textOverlay)
            {
                ctrl = new ctrlTextOverlay();
            }
            else
            {
                ctrl = new ctrlImageOverlay();
            }

            ctrl.Dock = DockStyle.Fill;
            panel1.Controls.Add(ctrl);
        }

        public Overlay GetOverlay()
        {
            if (panel1.Controls.Count > 0)
            {
                if (panel1.Controls[0] is ctrlTextOverlay)
                {
                    return ((ctrlTextOverlay)panel1.Controls[0]).GetTextOverlay();
                }
                else if (panel1.Controls[0] is ctrlImageOverlay)
                {
                    return ((ctrlImageOverlay)panel1.Controls[0]).GetImageOverlay();
                }
            }

            return null;
        }
    }
}
