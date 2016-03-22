//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using Bytescout.PDFExtractor;
using System.Diagnostics;

/*
This sample code shows how to extract data from tables where numbers with superscript

The code is doing the following with Prices.pdf:
 - uses StructuredExtractor class to iterate through rows
 - finds the header of the table by checking first columns in the header's row 
 - then iterates through rows and checking rows where no date in the first column
 - if no date then it means that this row contains superscript values for the row below and we should
 merge values from this row with cells in the row below
 - we are saving this row with superscript values
 - merging with the next row below
 
 saving each row into a comma delimited string
 collecting these strings into a single file and finally saving as .csv

*/


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // char to delimit cells in a row
            const string delimChar = ",";
            // char to service as decimal separator 
            const string precChar = ".";

            // output filename 
            const string outputCSVFileName = "outputTable.csv";

            // Create Bytescout.PDFExtractor.StructuredExtractor object
            StructuredExtractor structuredExtractor = new StructuredExtractor();

            // set the registration key
            structuredExtractor.RegistrationName = "demo";
            structuredExtractor.RegistrationKey = "demo";

            // Load sample PDF document
            structuredExtractor.LoadDocumentFromFile("Prices.pdf");

            // page to process
            int PageIndex = 0;

            // prepare structure of the first page (zero index)
            structuredExtractor.PrepareStructure(PageIndex);

            // get total number of rows in a table
            int iRowCount = structuredExtractor.GetRowCount(PageIndex);

            // search for the header column

            // index of the row with the header
            int iHeaderRowIndex = -1;

            // iterate through rows to find the header row
            for (int y = 0; y < iRowCount; y++)
            {

                // checking if the very first column (with date) is empty in the row
                // if date is empty it means this row contains superscript values for the row below
                if (structuredExtractor.GetCellValue(PageIndex, y, 0).IndexOf("Date") == 0 && // if 1st column starts with "Date"
                    structuredExtractor.GetCellValue(PageIndex, y, 1).IndexOf("Product") == 0 // if 2nd column starts with "Product"
                    )
                {
                    // found row with the header, saving its index
                    iHeaderRowIndex = y;
                    break;
                }

            } // end for

            // save number of columns in the header (so we are using the header row as a reference for the whole table)
            int iHeaderColumnCount = structuredExtractor.GetColumnCount(PageIndex, iHeaderRowIndex);

            // writing the header to the console
            for (int jj = 0; jj < iHeaderColumnCount; jj++)
            {
                Console.Write(structuredExtractor.GetCellValue(PageIndex, iHeaderRowIndex, jj) + " | ");
            }
            Console.Write("\n"); // add line break


            // we found a header i.e. we have a table below 
            // now reading row by row
            // if first cell in a row contains superscript values for the row below
            // we should save it and process along with the next row

            // array to store superscript row
            string[] superScriptRow = new string[iHeaderColumnCount];
            bool PreviousRowWasSuperscript = false;

            StringBuilder finalOutput = new StringBuilder();

            // now iterate through rows from row after the header until we got to the stop text (ending the table)
            for (int y = iHeaderRowIndex + 1; y < iRowCount; y++)
            {

                // current row 
                string[] currentRow = new string[iHeaderColumnCount];

                // fill up row array with values
                for (int x = 0; x < iHeaderColumnCount; x++)
                {
                    currentRow[x] = structuredExtractor.GetCellValue(PageIndex, y, x);
                }

                // if no values in 1st and 2nd column for the current row then it means we have 
                // superscript values in this row. These superscript values belong to cells below
                if (currentRow[0] == "" & currentRow[1] == "")
                {
                    // clean the superscript row
                    superScriptRow.Initialize();
                    // copy current row to superscriptRow
                    for (int i = 0; i < iHeaderColumnCount; i++)
                    {
                        superScriptRow[i] = currentRow[i];
                    }
                    PreviousRowWasSuperscript = true;
                    // jump to next iteration
                    continue;

                } // end if

                // if previous row was superscript then add it to current row
                if (PreviousRowWasSuperscript)
                {
                    for (int i = 0; i < iHeaderColumnCount; i++)
                    {
                        // if previous row (with superscript values) is NOT empty then add superscript values
                        // to values in the current row separated by decimal char
                        if (superScriptRow[i] != "")
                        {
                            currentRow[i] = currentRow[i] + precChar + superScriptRow[i];
                        }
                    }
                }

                // reset flag for next iteration not to use
                PreviousRowWasSuperscript = false;

                // get current row as a string
                StringBuilder rowString = new StringBuilder();
                foreach (string cc in currentRow)
                {
                    rowString.Append("\"" + cc + "\"");
                    rowString.Append(delimChar);
                }

                // add to final output string 
                finalOutput.AppendLine(rowString.ToString());


            }

            // write the generated csv into the console
            Console.WriteLine(finalOutput.ToString());

            // save the generate csv text into a file
            System.IO.File.WriteAllText(outputCSVFileName, finalOutput.ToString());

            Console.WriteLine("Done! Press any key to exit...");
            Console.ReadKey();

            Process.Start(outputCSVFileName);

        }
    }
}
