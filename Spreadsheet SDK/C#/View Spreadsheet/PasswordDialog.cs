//*******************************************************************
//       ByteScout Spreadsheet SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Windows.Forms;

namespace ViewSpreadsheet
{
    public partial class PasswordDialog : Form
    {
        public PasswordDialog()
        {
            InitializeComponent();
        }

        public string Password
        {
            get { return textBoxPassword.Text; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
            //Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHide.Checked)
                textBoxPassword.PasswordChar = '*';
            else
                textBoxPassword.PasswordChar = '\0';
        }
    }
}
