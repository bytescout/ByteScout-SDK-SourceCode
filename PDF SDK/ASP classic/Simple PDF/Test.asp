'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © Bytescout, http://www.bytescout.com        
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

 
Set pdfDocument = Server.CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add sample content
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 24)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
page1.Canvas.DrawString "Hello world!", (timesFont), (blackBrush), 20, 20

response.ContentType = "application/pdf"
' add content type header 
response.AddHeader "Content-Type", "application/pdf"
' set the content disposition
response.AddHeader "Content-Disposition", "inline;filename=Output.pdf" 
' write the binary representation of pdf document to the Response output stream 
response.BinaryWrite pdfDocument.GetDocumentBytes
response.End
 
%>
