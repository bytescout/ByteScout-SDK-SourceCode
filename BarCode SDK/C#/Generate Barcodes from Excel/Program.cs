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
using System.Data.OleDb;
using Bytescout.BarCode;

namespace GenerateFromDatabase
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Barcode generator instance 
			using (Barcode barcode = new Barcode())
			{
				// Set barcode type to QR Code
				barcode.Symbology = SymbologyType.Code128;

				// Create database connection
				using (OleDbConnection connection =
					new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Book1.xlsx;Extended Properties='Excel 8.0;HDR=Yes'"))
				{
					connection.Open();

					// Create SQL query
					using (OleDbCommand command = connection.CreateCommand())
					{
						command.CommandText = "SELECT * FROM [Sheet1$]";

						OleDbDataReader dataReader = command.ExecuteReader();

						// Iterate values and generate barcode images 
						int i = 0;
						while (dataReader.Read())
						{
							barcode.Value = Convert.ToString(dataReader.GetValue(0));
							barcode.SaveImage(barcode.Value + ".png");
							i++;
						}
					}
				}
			}
		}
	}
}
