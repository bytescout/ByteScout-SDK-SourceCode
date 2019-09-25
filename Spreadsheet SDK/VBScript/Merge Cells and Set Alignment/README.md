## How to merge cells and set alignment in VBScript and ByteScout Spreadsheet SDK

### How to merge cells and set alignment in VBScript

These source code samples are listed and grouped by their programming language and functions they use. ByteScout Spreadsheet SDK can merge cells and set alignment. It can be used from VBScript. ByteScout Spreadsheet SDK is the library (SDK) that is capable of writing, reading, modifying and calculating Excel and CSV spreadsheets. Most popular formulas can be calculated and reculculated with Excel installed. You may import or export data to and from CSV, XML, JSON as well as to and from databases, arrays.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Spreadsheet SDK for merge cells and set alignment below and use it in your application. This VBScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample VBScript codes.

Our website provides trial version of ByteScout Spreadsheet SDK for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Spreadsheet%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Spreadsheet%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=nm_7I0PN1TY](https://www.youtube.com/watch?v=nm_7I0PN1TY)




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