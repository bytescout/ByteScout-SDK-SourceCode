'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' IMPORTANT NOTE: you need to have .NET Framework 1.10 installed to use Spreadsheet SDK from Visual Basic
' to download and install .NET Framework 1.10 please use this link: http://www.microsoft.com/downloads/details.aspx?familyid=262D25E3-F589-4842-8157-034D1E7CF3A3

Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' add cell with HTML formatted text
Set cell = worksheet.Cell(2,2)
cell.ValueAsHTML = "test resizing"

set column = worksheet.columns.Item(1)

column.Width = 200

' delete output file if exists already
Set fso = CreateObject("Scripting.FileSystemObject")
If (fso.FileExists("Output.xls")) Then fso.DeleteFile("Output.xls")
Set fso = nothing

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing

