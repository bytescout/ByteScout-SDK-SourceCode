'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


<%

' In case of "Server.CreateObject Failed", "Server object error "ASP 0177 : 8000ffff" or similar errors:
' Please try the following:
' - Open IIS 
' - Find application pools (DefaultAppPool is used by default)
' - Open its properties and check .NET CLR version selected:
' - if you have  .NET 1.1 then change to .NET CLR 2.00
' - if you have .NET CLR 2.00 then try to change to .NET CLR 4.0


Set document = Server.CreateObject("Bytescout.Spreadsheet.Spreadsheet")

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' Get cell value
Set cell = worksheet.Item(0,0) ' You can also use worksheet.Cell("A1") as well

' Set cell value
cell.Value = "Hello, World!"

' Generate and get XLS document as an array of bytes
XLSDocumentArray = document.GetAsBytesArrayXLS

response.ContentType = "vnd.ms-excel"

' Add content type header 
response.AddHeader "Content-Type", "application/vnd.ms-excel"

' Set the content disposition
response.AddHeader "Content-Disposition", "inline;filename=HelloWorld.xls" 

' Write the binary image to the Response output stream 
response.BinaryWrite XLSDocumentArray
response.End

' Release library
Set document = Nothing

%>
