## How to draw tables in pdf with pdf sdk in VBScript and ByteScout Premium Suite

### Learn to code in VBScript to draw tables in pdf with pdf sdk with this step-by-step tutorial

Every ByteScout tool includes simple example VBScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout Premium Suite can draw tables in pdf with pdf sdk. It can be applied from VBScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

 These VBScript code samples for VBScript guide developers to speed up coding of the application when using ByteScout Premium Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Further improvement of the code will make it more robust.

You can download free trial version of ByteScout Premium Suite from our website with this and other source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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