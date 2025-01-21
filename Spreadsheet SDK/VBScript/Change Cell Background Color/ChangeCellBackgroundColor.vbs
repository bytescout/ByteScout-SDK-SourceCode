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

' add cell with HTML formatted text
Set cell = worksheet.Cell(1, 1)
cell.Value = "One Two Three"

cell.FillPattern = 1 ' Solid color
cell.FillPatternForeColorOLE = vbMagenta ' use standard VB color constants or hex values &HFFFF00

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing
