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
using System.IO;
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
				// Load XLS document
				using (Spreadsheet document = new Spreadsheet())
				{
					document.LoadFromFile("SimpleReport.xls");
					string csvFile = Path.GetTempPath() + "SimpleReport.csv";

					// Save the document as CSV file
					document.Workbook.Worksheets[0].SaveAsCSV(csvFile);
					document.Close();

					if (File.Exists(csvFile))
					{
						// MODIFY THE CONNECTION STRING WITH YOUR CREDENTIALS!!!
						string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=true;";

						using (SqlConnection connection = new SqlConnection(connectionString))
						{
							connection.Open();

							// Drop test database if exists
							ExecuteQueryWithoutResult(connection,
													  "IF DB_ID ('XlsTests') IS NOT NULL DROP DATABASE XlsTests");
							// Create empty database
							ExecuteQueryWithoutResult(connection, "CREATE DATABASE XlsTests");
							// Switch to created database
							ExecuteQueryWithoutResult(connection, "USE XlsTests");
							// Create a table for CSV data
							ExecuteQueryWithoutResult(connection, 
							                          "CREATE TABLE CsvTest (Name VARCHAR(40), FullName VARCHAR(255))");
							// Export CSV data from local file
							ExecuteQueryWithoutResult(connection,
							                          "BULK INSERT CsvTest FROM '" + csvFile + "' " +
							                          "WITH ( FIELDTERMINATOR = ';', ROWTERMINATOR = '\n')");
							
							// Check the data successfully exported
							using (SqlCommand command = new SqlCommand("SELECT * from CsvTest", connection))
							{
								SqlDataReader reader = command.ExecuteReader();

								if (reader != null)
								{
									Console.WriteLine();
									Console.WriteLine("Exported CSV data:");
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
