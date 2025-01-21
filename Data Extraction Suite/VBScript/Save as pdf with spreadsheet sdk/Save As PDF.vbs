'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' add a cell 
Set cell = worksheet.Cell(1, 1)
cell.Value = "Testing, Testing, Testing, Testing..."

' Save spreadsheet as PDF file:

' Save PDF with automatic page size...
document.SaveAsPDF "autosized.pdf"
' ... or save PDF with fixed page size
document.SaveAsPDF_2 "fixedsize.pdf", False ' the second parameter disables autosizing 

' close Spreadsheet
Set document = Nothing

