## How to add images to spreadsheet with spreadsheet sdk in VBScript using ByteScout Data Extraction Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to add images to spreadsheet with spreadsheet sdk in VBScript

ByteScout simple and easy to understand tutorials are planned to describe the code for both VBScript beginners and advanced programmers. What is ByteScout Data Extraction Suite? It is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to add images to spreadsheet with spreadsheet sdk in your VBScript application.

The SDK samples given below describe how to quickly make your application do add images to spreadsheet with spreadsheet sdk in VBScript with the help of ByteScout Data Extraction Suite. Just copy and paste the code into your VBScript application’s code and follow the instructions. Use of ByteScout Data Extraction Suite in VBScript is also described in the documentation included along with the product.

You can download free trial version of ByteScout Data Extraction Suite from our website with this and other source code samples for VBScript.

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