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
                    ExecuteQueryWithoutResult(connection, "IF DB_ID ('CsvTests') IS NOT NULL DROP DATABASE CsvTests");
                    // Create empty database
                    ExecuteQueryWithoutResult(connection, "CREATE DATABASE CsvTests");
                    // Switch to created database
                    ExecuteQueryWithoutResult(connection, "USE CsvTests");
                    // Create a table for CSV data
                    ExecuteQueryWithoutResult(connection, "CREATE TABLE CsvTest (Name VARCHAR(40), FullName VARCHAR(255))");

                    // Load CSV document
                    using (Spreadsheet document = new Spreadsheet())
                    {
                        document.LoadFromFile("sample.csv", ";"); // ";" - delimiter
                        Worksheet worksheet = document.Workbook.Worksheets[0];

                        for (int row = 0; row <= worksheet.UsedRangeRowMax; row++)
                        {
                            String insertCommand = string.Format("INSERT CsvTest VALUES('{0}','{1}')",
                                worksheet.Cell(row, 0).Value, worksheet.Cell(row, 1).Value);
                            ExecuteQueryWithoutResult(connection, insertCommand);
                        }
                    }
                    
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
