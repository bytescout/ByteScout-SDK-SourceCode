//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
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
