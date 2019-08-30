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
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Bytescout.Spreadsheet;

namespace SimpleDatabase
{
    public partial class Form1 : Form
    {
        Spreadsheet _spreadsheet;

        private void LoadXLS()
        {
            Worksheet worksheet;
            _spreadsheet = new Spreadsheet();
            _spreadsheet.LoadFromFile("Database.xls");

            worksheet = _spreadsheet.Workbook.Worksheets[0];
            Label1.Text = (string)worksheet.Cell("A1").Value;
            TextBox1.Text = worksheet.Cell("A2").Value.ToString();

            Label2.Text = (string)worksheet.Cell("B1").Value;
            TextBox2.Text = worksheet.Cell("B2").Value.ToString();

            Label3.Text = (string)worksheet.Cell("C1").Value;
            TextBox3.Text = worksheet.Cell("C2").Formula;

            Label4.Text = "Calculated value of C2";
            worksheet.Cell("C2").Calculate();
            TextBox4.Text = worksheet.Cell("C2").Value.ToString();
        }

        private void SaveXLS()
        {
            Worksheet worksheet;

            worksheet = _spreadsheet.Workbook.Worksheets[0];

            worksheet.Cell("A2").Value = System.Convert.ToInt32(TextBox1.Text);
            worksheet.Cell("B2").Value = System.Convert.ToInt32(TextBox2.Text);
            worksheet.Cell("C2").Formula = TextBox3.Text;

            try
            {
                System.IO.File.Delete("Database.xls");
            }
            catch (Exception ex)
            {
            }

            _spreadsheet.SaveAs("Database.xls");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveXLS();

            _spreadsheet.Close();
        }

        private void ReCalculate()
        {
            Worksheet worksheet;

            worksheet = _spreadsheet.Workbook.Worksheets[0];

            worksheet.Cell("A2").Value = System.Convert.ToInt32(TextBox1.Text);
            worksheet.Cell("B2").Value = System.Convert.ToInt32(TextBox2.Text);
            worksheet.Cell("C2").Formula = TextBox3.Text;
            worksheet.Cell("C2").Calculate();
            TextBox4.Text = worksheet.Cell("C2").Value.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ReCalculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadXLS();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // open in default spreadsheets viewer/editor
            SaveXLS();
            try
            {
                Process.Start("Database.xls");
            }
            catch
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadXLS();
            MessageBox.Show("Loaded from Database.xls");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveXLS();
            MessageBox.Show("Saved into Database.xls");
        }
    }
}
