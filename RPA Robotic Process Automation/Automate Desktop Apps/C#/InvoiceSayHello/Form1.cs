//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceSayHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            /*
             * Prepare message to be displayed, display that message in message box
             */
             
            var strMessage = new StringBuilder(string.Empty);
            strMessage.AppendLine($"Bill To: {txtBillTo.Text}");
            strMessage.AppendLine($"Address: {txtAddress.Text}");
            strMessage.AppendLine($"Invoice No: {txtInvoiceNo.Text}");
            strMessage.AppendLine($"Invoice Date: {txtInvoiceDate.Text}");
            strMessage.AppendLine($"Amount: {txtInvoiceAmount.Text}");

            // Show invoice details in message box
            MessageBox.Show(strMessage.ToString(), "Invoice Details", MessageBoxButtons.OK);
        }
    }
}
