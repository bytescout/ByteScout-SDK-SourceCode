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
