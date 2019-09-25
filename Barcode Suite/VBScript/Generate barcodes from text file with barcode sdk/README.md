## How to generate barcodes from text file with barcode sdk in VBScript using ByteScout Barcode Suite

### Learn to code in VBScript to generate barcodes from text file with barcode sdk with this step-by-step tutorial

Generate barcodes from text file with barcode sdk is simple to apply in VBScript if you use these source codes below. ByteScout Barcode Suite: the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK). It can generate barcodes from text file with barcode sdk in VBScript.

This prolific sample source code in VBScript for ByteScout Barcode Suite contains various functions and other necessary options you should do calling the API to generate barcodes from text file with barcode sdk. Just copy and paste the code into your VBScript application’s code and follow the instructions. Check VBScript sample code samples to see if they respond to your needs and requirements for the project.

Trial version of ByteScout Barcode Suite is available for free. Source code samples are included to help you with your VBScript app.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

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

##### ****generate_barcodes.vbs:**
    
```
'*** Prepare Barcode object
Set barcode = CreateObject("Bytescout.BarCode.Barcode")
barcode.RegistrationName = "demo"
barcode.RegistrationKey = "demo"
' Set barcode type to PDF417
barcode.Symbology = 16 ' 16 means QR Code
' Set higher resoultion (300 is good for printing)
barcode.ResolutionX = 300
barcode.ResolutionY = 300
' Show barcode caption (remove these lines if you don't need it)
barcode.DrawCaption = True
barcode.DrawCaptionFor2DBarcodes = True

' Open text file containing barcode data and read it line by line
Set fso = CreateObject("Scripting.FileSystemObject")
Set listFile = fso.OpenTextFile("list.txt")
i = 0

do while not listFile.AtEndOfStream 
    ' Set barcode value
    barcode.Value = listFile.ReadLine()
	' Fit barcode into 30x30 mm rectangle
	barcode.FitInto_3 30, 30, 4 ' 4 means millimeter units
	' Save barcode image to file
	barcode.SaveImage("barcode" & i & ".png")
	i = i + 1
loop

Set barcode = Nothing
set fso = Nothing

```

<!-- code block end -->    

<!-- code block begin -->

##### ****list.txt:**
    
```
sample data 1
sample data 2
sample data 3
sample data 4
sample data 5
sample data 6
```

<!-- code block end -->