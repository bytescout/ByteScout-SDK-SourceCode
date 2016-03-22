'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

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

' get cell value
Set cell = worksheet.Item(0,0) ' you can also use worksheet.Cell("A1") as well

' set cell value
cell.Value = "Hello, World!"

' generate and get xls document as an array of bytes
 XLSDocumentArray = document.GetAsBytesArrayXLS

 response.ContentType = "vnd.ms-excel"

 ' add content type header 
 response.AddHeader "Content-Type", "application/vnd.ms-excel"

 ' set the content disposition
 response.AddHeader "Content-Disposition", "inline;filename=HelloWorld.xls" 

 ' write the binary image to the Response output stream 
 response.BinaryWrite XLSDocumentArray
 response.End

' disconnect from libraries
Set document = Nothing


%>
