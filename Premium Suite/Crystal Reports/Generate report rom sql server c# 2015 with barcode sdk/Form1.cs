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
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bytescout.BarCode;

namespace ReportFromSqlServer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			try
			{
				// MODIFY THE CONNECTION STRING WITH YOUR SERVER CONNECTION INFO!!!
				const string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=true;";

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					// Create a database for demonstration purposes
					///////////////////////////////////////////////////////////////////////////////////////

					Object o = ExecuteQueryScalar(connection, "SELECT DB_ID('example_db')");

					// if 'example_db' does not exist, create it
					if (o == null || o is DBNull)
					{
						// Create empty database
						ExecuteQueryWithoutResult(connection, "CREATE DATABASE example_db");
						// Switch to created database
						ExecuteQueryWithoutResult(connection, "USE example_db");
						// Create a table
						ExecuteQueryWithoutResult(connection, "CREATE TABLE Products ([Product ID] int, [Product Name] nvarchar(100), [Product Description] nvarchar(255))");
						// Fill the table with data
						ExecuteQueryWithoutResult(connection, "INSERT Products VALUES(1, 'Spreadsheet Tools', 'Convert XLS, XLSX, CSV, ODS spreadsheet into HTML, PDF, XLS, XLSX, CSV formats WITHOUT EXCEL installed')");
						ExecuteQueryWithoutResult(connection, "INSERT Products VALUES(2, 'Watermarking PRO', 'Professional tool to protect images: multiple watermarks, custom position for watermarks, image effects, EXIF and IPTC macros for text and more')");
						ExecuteQueryWithoutResult(connection, "INSERT Products VALUES(3, 'Watermarking', 'Protect copyrights for your images with professional looking watermarks with this easy to use tool')");
						ExecuteQueryWithoutResult(connection, "INSERT Products VALUES(4, 'PPT To Video Scout', 'converts PowerPoint presentations (PPT, PPTX) into AVI,MPEG,WMV, FLV (flash video) video movies with sound')");
					}


					// Create a datataset from query.
					// Query result columns must conform to field names we used in the report designer

					SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [Product ID], [Product Name], [Product Description] FROM example_db.dbo.Products", connection);

					// fill dataset
					DataSet dataSet = new DataSet();
					dataAdapter.Fill(dataSet);

					// don't forget to close the connection
					connection.Close();

					// add virtual column into the result table
					dataSet.Tables[0].Columns.Add(new DataColumn("BarCode", typeof(byte[])));

					// create barcode object
					Barcode bc = new Barcode(SymbologyType.Code39);
					bc.DrawCaption = false;

					foreach (DataRow row in dataSet.Tables[0].Rows)
					{
						// set barcode value
						bc.Value = (Convert.ToString(row["Product ID"]));

						// retrieve generated image bytes
						byte[] barcodeBytes = bc.GetImageBytesWMF();

						// fill virtual column with generated image bytes
						row["BarCode"] = barcodeBytes;
					}

					// set report datasource
					CrystalReport11.SetDataSource(dataSet.Tables[0]);
				}
			}
			catch (Exception ex)
			{
				Trace.WriteLine("Error: " + ex.Message);
			}
		}

		private static void ExecuteQueryWithoutResult(SqlConnection connection, string query)
		{
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.ExecuteNonQuery();
			}
		}

		private static object ExecuteQueryScalar(SqlConnection connection, string query)
		{
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				return command.ExecuteScalar();
			}
		}
	}
}
