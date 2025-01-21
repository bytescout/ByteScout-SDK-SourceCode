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
using Bytescout.Spreadsheet;
using System.Data.SqlClient;

namespace ExportToSQLServer
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				// MODIFY THE CONNECTION STRING WITH YOUR CREDENTIALS!!!
				string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=true;";

				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					// Drop test database if exists
					ExecuteQueryWithoutResult(connection,
											  "IF DB_ID ('OdsTests') IS NOT NULL DROP DATABASE OdsTests");
					// Create empty database
					ExecuteQueryWithoutResult(connection, "CREATE DATABASE OdsTests");
					// Switch to created database
					ExecuteQueryWithoutResult(connection, "USE OdsTests");
					// Create a table for ODS data
					ExecuteQueryWithoutResult(connection,
											  "CREATE TABLE OdsTest (Name VARCHAR(40), FullName VARCHAR(255))");

					// Load ODS document
					using (Spreadsheet document = new Spreadsheet())
					{
						document.LoadFromFile("sample.ods");
						Worksheet worksheet = document.Workbook.Worksheets[0];

						for (int row = 0; row <= worksheet.UsedRangeRowMax; row++)
						{
							String insertCommand = string.Format("INSERT OdsTest VALUES('{0}','{1}')",
								worksheet.Cell(row, 0).Value, worksheet.Cell(row, 1).Value);
							ExecuteQueryWithoutResult(connection, insertCommand);
						}
					}
					
					// Check the data successfully exported
					using (SqlCommand command = new SqlCommand("SELECT * from OdsTest", connection))
					{
						SqlDataReader reader = command.ExecuteReader();

						if (reader != null)
						{
							Console.WriteLine();
							Console.WriteLine("Exported ODS data:");
							Console.WriteLine();

							while (reader.Read())
							{
								Console.WriteLine(String.Format("{0}  |  {1}", reader[0], reader[1]));
							}
						}
					}

					Console.WriteLine();
					Console.WriteLine("Press any key.");
					Console.ReadKey();
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
				Console.ReadKey();
			}
		}

		static void ExecuteQueryWithoutResult(SqlConnection connection, string query)
		{
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				command.ExecuteNonQuery();
			}
		}
	}
}
