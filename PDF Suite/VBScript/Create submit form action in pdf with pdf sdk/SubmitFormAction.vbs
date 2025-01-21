'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to submit or reset form.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create sample form
Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 14)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
' EditBox
Set editBox1 = comHelpers.CreateEditBox(20, 20, 100, 25, "editBox1")
editBox1.Text = "editBox1"
page1.Annotations.Add(editBox1)
' CheckBox
Set checkBox1 = comHelpers.CreateCheckBox(20, 60, 15, 15, "checkBox1")
page1.Annotations.Add(checkBox1)
page1.Canvas.DrawString "CheckBox", (timesFont), (blackBrush), 45, 60 

' Add Submit button
Set submitButton = comHelpers.CreatePushButton(20, 120, 80, 25, "buttonSubmit")
submitButton.Caption = "Submit"
page1.Annotations.Add(submitButton)
' Add action
Set submitAction = comHelpers.CreateSubmitFormAction("http://login.live.com")
submitAction.SubmitFormat = comHelpers.SUBMITDATAFORMAT_HTML
submitAction.SubmitMethod = comHelpers.SUBMITMETHOD_GET
submitAction.Fields.Add(editBox1)
submitAction.Fields.Add(checkBox1)
submitButton.OnActivated = submitAction

' Add Reset button
Set resetButton = comHelpers.CreatePushButton(120, 120, 80, 25, "butonReset")
resetButton.Caption = "Reset"
page1.Annotations.Add(resetButton)
' Add action
Set resetAction = comHelpers.CreateResetFormAction()
resetAction.Fields.Add(editBox1)
resetAction.Fields.Add(checkBox1)
resetButton.OnActivated = resetAction

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
