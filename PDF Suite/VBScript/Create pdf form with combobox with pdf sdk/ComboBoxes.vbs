'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to create and decorate comboboxes.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Add dropdown box (not editable combobox)
Set comboBox1 = comHelpers.CreateComboBox(20, 20, 150, 25, "comboBox1")
comboBox1.Font.Size = 12
comboBox1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
comboBox1.BackgroundColor = comHelpers.CreateColorRGB(220, 220, 255)
comboBox1.BorderWidth = 2
comboBox1.Text = "Select item"
comboBox1.Items.Add("Item 1")
comboBox1.Items.Add("Item 2")
comboBox1.Items.Add("Item 3")
page1.Annotations.Add(comboBox1)

' Add editable combobox
Set comboBox2 = comHelpers.CreateComboBox(20, 50, 150, 25, "comboBox2")
comboBox2.Editable = True
comboBox2.Font.Size = 12
comboBox2.BorderColor = comHelpers.CreateColorRGB(0, 128, 0)
comboBox2.BackgroundColor = comHelpers.CreateColorRGB(220, 255, 220)
comboBox1.BorderWidth = 2
comboBox2.Text = "Editable ComboBox"
comboBox2.Items.Add("Item 1")
comboBox2.Items.Add("Item 2")
comboBox2.Items.Add("Item 3")
page1.Annotations.Add(comboBox2)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
