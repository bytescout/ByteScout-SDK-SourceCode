'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.Spreadsheet
Imports System.Diagnostics
Imports System.IO

Module Module1

    Sub Main()
        ' Open existing XLS file
        Dim spreadsheet As New Spreadsheet()
	spreadsheet.LoadFromFile("Input.xls")

            // delete output file if exists already
            if (File.Exists("Output.xlsx")){
                File.Delete("Output.xlsx");
            }


        ' Save it as XLSX
        spreadsheet.SaveAs("Output.xlsx")

        ' open output document in default viewer
        Process.Start("Output.xlsx");

    End Sub

End Module
