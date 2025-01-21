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
using System.Diagnostics;
using System.Drawing;
using System.Xml;
using Bytescout.Spreadsheet;
using Bytescout.Spreadsheet.Constants;

namespace ConvertXmlToXlsExample
{
	/// <summary>
	/// This example demonstrates how to create Excel spreadsheet from some XML data.
	/// Since your XML file has different structure the example just shows technique of XML data reading 
	//  and spreadsheet creation.
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Load XML document
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(@"sample.xml");

			// Read columns information from XML data
			List<string> columns = new List<string>();
			XmlNodeList columnNodeList = xmlDocument.SelectNodes("/Report/Columns/Column");
			foreach (XmlNode node in columnNodeList)
				columns.Add(node.Attributes["Name"].Value);

			// Read row nodes from XML data
			XmlNodeList rowNodeList = xmlDocument.SelectNodes("/Report/ReportData");
			

			// Create new spreadsheet
			Spreadsheet spreadsheet = new Spreadsheet();
			spreadsheet.RegistrationName = "demo";
			spreadsheet.RegistrationKey = "demo";
			// Add worksheet
			Worksheet worksheet = spreadsheet.Worksheets.Add();
			
			// Add column headers
			for (int c = 0; c < columns.Count; c++)
			{
				worksheet[0, c].Value = columns[c];
				worksheet[0, c].FillPattern = PatternStyle.Solid;
				worksheet[0, c].FillPatternForeColor = Color.LightGray;
			}

			int rowIndex = 1;

			// Add rows
			foreach (XmlNode rowNode in rowNodeList)
			{
				// Get cell values from XML data
				foreach (XmlNode childNode in rowNode.ChildNodes)
				{
					// Get cell info from XML data
					int columnIndex = columns.IndexOf(childNode.Name);
					string cellValue = childNode.InnerText;

					Cell cell = worksheet[rowIndex, columnIndex];

					// Set cell text
					cell.Value = cellValue;
					// Set cell text alignment
					cell.AlignmentHorizontal = columnIndex == 0 ? AlignmentHorizontal.Left : AlignmentHorizontal.Right;
				}

				// Add the row to the table
				rowIndex++;
			}

			// Fit columns width to cell data
			for (int c = 0; c < columns.Count; c++)
				worksheet.Columns[c].AutoFit();

			// Save document to file
			spreadsheet.SaveAsXLS("result.xls");

			// Cleanup 
			spreadsheet.Dispose();

			// Open document in Excel
			Process.Start("result.xls");
		}
	}
}
