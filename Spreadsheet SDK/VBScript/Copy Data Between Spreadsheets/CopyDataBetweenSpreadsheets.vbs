'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' Create and activate two Spreadsheet objects
Set srcDocument = CreateObject("Bytescout.Spreadsheet.Spreadsheet")
srcDocument.RegistrationName = "demo"
srcDocument.RegistrationKey = "demo"
Set dstDocument = CreateObject("Bytescout.Spreadsheet.Spreadsheet")
dstDocument.RegistrationName = "demo"
dstDocument.RegistrationKey = "demo"

' Load exported data
srcDocument.LoadFromFile ".\sample.csv"
' Load destination document
dstDocument.LoadFromFile ".\destination.xlsx"

' Get worksheets
Set srcWorksheet = srcDocument.Worksheet(0)
Set dstWorksheet = dstDocument.Worksheet(0)

' Copy data from source to destination
For row = 0 To 3
    For column = 0 To 3
        dstWorksheet.Cell(row, column).Value = srcWorksheet.Cell(row, column).Value
    Next
Next

' Recalculate formulas
dstDocument.Workbook.Calculate

' Save modified document as "result.xls"
dstDocument.SaveAs ".\result.xls"

