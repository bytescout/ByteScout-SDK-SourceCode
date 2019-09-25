## How to add images to spreadsheet in VBScript with ByteScout Spreadsheet SDK

### Tutorial on how to add images to spreadsheet in VBScript

Learn how to add images to spreadsheet in VBScript with this source code sample. ByteScout Spreadsheet SDK is the library (SDK) that is capable of writing, reading, modifying and calculating Excel and CSV spreadsheets. Most popular formulas can be calculated and reculculated with Excel installed. You may import or export data to and from CSV, XML, JSON as well as to and from databases, arrays and you can use it to add images to spreadsheet with VBScript.

This rich sample source code in VBScript for ByteScout Spreadsheet SDK includes the number of functions and options you should do calling the API to add images to spreadsheet. Follow the instructions from the scratch to work and copy the VBScript code. Enjoy writing a code with ready-to-use sample VBScript codes.

Free trial version of ByteScout Spreadsheet SDK is available on our website. Documentation and source code samples are included.

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

##### ****AddImages.vbs:**
    
```
Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

Set pictures = worksheet.Pictures

' add a picture to specified cell
pictures.Add 1, 1, "image1.jpg" 

' add a picture by absolute pixel coordinates
pictures.Add_3 "image2.jpg", 550, 100

' fit picture into cell range
Set picture = pictures.AddAndFitInto(27, 1, 32, 5, "image1.jpg")

' rotate the last added picture
picture.Rotation = 45


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