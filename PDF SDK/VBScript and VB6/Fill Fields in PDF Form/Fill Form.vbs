'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to fill PDF form programmatically.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' Load PDF form
pdfDocument.Load("form.pdf")

Set page = pdfDocument.Pages.Item(0)

' Get widget by its name and change value
page.Annotations.Item_2("editBox1").Text = "Test 123"
page.Annotations.Item_2("editBox2").Text = "Test 456"
page.Annotations.Item_2("checkBox1").Checked = True

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
