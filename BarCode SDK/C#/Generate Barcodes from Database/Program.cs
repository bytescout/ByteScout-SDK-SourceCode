//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


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
				barcode.Symbology = SymbologyType.QRCode;

				// Create database connection
				using (OleDbConnection connection =
					new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=demodb.mdb;User Id=admin;Password=;"))
				{
					connection.Open();

					// Create SQL query
					using (OleDbCommand command = connection.CreateCommand())
					{
						command.CommandText = "SELECT title FROM Books";

						OleDbDataReader dataReader = command.ExecuteReader();

						// Iterate values and generate barcode images 
						int i = 0;
						while (dataReader.Read())
						{
							barcode.Value = dataReader.GetString(0);
							barcode.SaveImage(i + ".png");
							i++;
						}
					}
				}
			}
		}
	}
}
