'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to create checkboxes.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add unchecked checkbox
Set checkBox1 = comHelpers.CreateCheckBox(20, 20, 15, 15, "checkBox1")
page1.Annotations.Add(checkBox1)

' Add checked checkbox
Set checkBox2 = comHelpers.CreateCheckBox(20, 40, 15, 15, "checkBox2")
checkBox2.Checked = True
page1.Annotations.Add(checkBox2)

' Add readonly checkbox
Set checkBox3 = comHelpers.CreateCheckBox(20, 60, 15, 15, "checkBox3")
checkBox3.Checked = True
checkBox3.ReadOnly = True
page1.Annotations.Add(checkBox3)

' Draw text labels
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 12)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
page1.Canvas.DrawString "Unchecked box", (timesFont), (blackBrush), 45, 20
page1.Canvas.DrawString "Checked box", (timesFont), (blackBrush), 45, 40
page1.Canvas.DrawString "Read-only checked box", (timesFont), (blackBrush), 45, 60

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
