## How to draw tables in pdf with pdf sdk in VBScript with ByteScout PDF Suite

### If you want to learn more then this tutorial will show how to draw tables in pdf with pdf sdk in VBScript

The sample source code below will teach you how to draw tables in pdf with pdf sdk in VBScript. ByteScout PDF Suite is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript and you can use it to draw tables in pdf with pdf sdk with VBScript.

The SDK samples given below describe how to quickly make your application do draw tables in pdf with pdf sdk in VBScript with the help of ByteScout PDF Suite.  Simply copy and paste in your VBScript project or application you and then run your app! Applying VBScript application mostly includes various stages of the software development so even if the functionality works please test it with your data and the production environment.

You can download free trial version of ByteScout PDF Suite from our website with this and other source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****Tables.vbs:**
    
```
' This example demonstrates how to create tables.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set lightGrayColor = comHelpers.CreateColorGray(200)
Set whiteColor = comHelpers.CreateColorGray(255)
Set lightBlueColor = comHelpers.CreateColorRGB(200, 200, 250)
Set lightRedColor = comHelpers.CreateColorRGB(255, 200, 200)

' Create a table and set default background color
Set table = comHelpers.CreateTable()
table.BackgroundColor = lightGrayColor

' Add row headers column and set its color
table.Columns.Add(comHelpers.CreateTableColumn("RowHeaders", ""))
table.Columns.Item(0).BackgroundColor = lightGrayColor

' Add columns A, B, C, ...
For c = 0 To 9
    columnName = Chr(65 + c)
    table.Columns.Add(comHelpers.CreateTableColumn(columnName, columnName))
Next

' Add rows
For r = 0 To 9
    ' Create new row and set its background color
    Set row = table.NewRow()
    row.BackgroundColor = whiteColor

    ' Set row header text
    row("RowHeaders").Text = CStr(r + 1)

    ' Set cell text
    For c = 0 To 9
        columnName = Chr(65 + c)
        row(columnName).Text = columnName + CStr(r + 1)
    Next

    ' Add the row to the table
    table.Rows.Add(row)
Next

' Decorate the table
table.Rows.Item(1)("B").BackgroundColor = lightRedColor
table.Columns.Item(2).BackgroundColor = lightBlueColor
table.Rows.Item(1).BackgroundColor = lightBlueColor
table.Rows.Item(1)("RowHeaders").BackgroundColor = lightBlueColor

' Draw the table on canvas
page1.Canvas.DrawTable (table), 20, 20

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false

```

<!-- code block end -->