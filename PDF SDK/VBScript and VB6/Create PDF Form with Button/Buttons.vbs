'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' This example demonstrates how to create a button and decorate it.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' If you wish to load an existing document uncomment the line below And comment the Add page section instead
' pdfDocument.Load("existing_document.pdf")

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

' Create a button
Set button1 = comHelpers.CreatePushButton(50, 50, 100, 30, "button1")
button1.Caption = "Button"
' Decorate the button with various styles
button1.BackgroundColor = comHelpers.CreateColorRGB(192, 192, 255)
button1.BorderWidth = 2
button1.BorderStyle = comHelpers.BORDERSTYLE_BEVELED
button1.BorderColor = comHelpers.CreateColorRGB(0, 0, 128)
button1.Font = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 16)
button1.FontColor = comHelpers.CreateColorRGB(0, 0, 0)
button1.HighlightingMode = comHelpers.PUSHBUTTONHIGHLIGHTINGMODE_OUTLINE

' Add button to the page
page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
