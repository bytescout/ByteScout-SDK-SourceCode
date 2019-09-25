## How to merge cells and set alignment with spreadsheet sdk in VBScript and ByteScout Data Extraction Suite

### How to write a robust code in VBScript to merge cells and set alignment with spreadsheet sdk with this step-by-step tutorial

These source code samples are assembled by their programming language and functions they apply. ByteScout Data Extraction Suite is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK and you can use it to merge cells and set alignment with spreadsheet sdk with VBScript.

The SDK samples given below describe how to quickly make your application do merge cells and set alignment with spreadsheet sdk in VBScript with the help of ByteScout Data Extraction Suite. IF you want to implement the functionality, just copy and paste this code for VBScript below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in VBScript.

Trial version of ByteScout Data Extraction Suite is available for free. Source code samples are included to help you with your VBScript app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Data%20Extraction%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Data%20Extraction%20Suite%20Question) 

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

##### ****MergeCellsAndSetAlignment.vbs:**
    
```
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' change width of the column #1
set column = worksheet.columns.Item(1)
column.Width = 200

' change height of row #1
set row = worksheet.rows.Item(1)
row.Height = 100

' Merge cells
Set range = worksheet.Range_2("A1:D5")
range.Merge()

' Write text
Set cell = worksheet.Cell_2("A2")
set leftCell = cell.MergedWithCell()

leftCell.ValueAsHTML = "<center><b>Bold text</b> and <i>Italic text</i></center>"

' set alignment 
' setting right alignment for the cell
leftcell.AlignmentHorizontal = 3 ' see (0) Bytescout.Spreadsheet.Constants.AlignmentHorizontal.Right


' delete output file if exists already
Set fso = CreateObject("Scripting.FileSystemObject")
If (fso.FileExists("Output.xls")) Then fso.DeleteFile("Output.xls")
Set fso = nothing

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing


```

<!-- code block end -->