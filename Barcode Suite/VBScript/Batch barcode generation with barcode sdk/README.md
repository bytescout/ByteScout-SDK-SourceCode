## batch barcode generation with barcode sdk in VBScript with ByteScout Barcode Suite

### Build batch barcode generation with barcode sdk in VBScript: ### Step-by-step instructions on how to do batch barcode generation with barcode sdk in VBScript

An easy to understand guide to learn how to batch barcode generation with barcode sdk in VBScript. ByteScout Barcode Suite was made to help with batch barcode generation with barcode sdk in VBScript. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

The below SDK samples describe how to quickly make your application do batch barcode generation with barcode sdk in VBScript with the help of ByteScout Barcode Suite.  Just copy and paste this VBScript sample code to your VBScript application's code editor, add a reference to ByteScout Barcode Suite (if you haven't added yet) and you are ready to go! Check these VBScript sample code examples to see if they acknowledge to your needs and requirements for the project.

Trial version along with the source code samples for VBScript can be downloaded from our website

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

##### ****GenerateMultipleBarcodes.vbs:**
    
```
' HOW TO USE: save this file as "GenerateMultipleBarcodes.vbs'
' change parameters below to your parameters required
' the script wlil generate barcodes into the same folder
' output images are named using encoded value, for example: 100.png represents barcode with encoded value "100"
' TO RUN: install BarCode SDK and in Windows Explorer double-click on "MultipleBarcodes.vbs"


' BEGIN OF BARCODE BATCH GENERATION PARAMETERS
BarCodeType = 16 ' 16 = qr code, for full list of available barcode types see this link: http://bytescout.com/files/help/BytescoutBarCodeSDK/source/html/T_Bytescout_BarCode_SymbologyType.htm
StartValue = 1 ' starting value
StepValue = 2 ' incrementing step for each new barcode
NumberOfBarcodes = 100 ' number of barcodes to generate

BarCodeSDKLicenseName = "demo"
BarCodeSDKLicenseSerial = "demo"

' END OF BARCODE BATCH GENERATION PARAMETERS
' do not change below this line

' initialize barcode library
Set bc = CreateObject("Bytescout.BarCode.Barcode")
bc.RegistrationName = BarCodeSDKLicenseName
bc.RegistrationKey = BarCodeSDKLicenseSerial

' set barcode type to generate
bc.Symbology = BarCodeType

' now make list of barcodes 
For i = StartValue to (StartValue + NumberOfBarcodes)*StepValue Step StepValue 

 bc.Value = CStr(i)
 bc.SaveImage CStr(i) & ".png"

Next

j = (StartValue + NumberOfBarcodes)*StepValue

Msgbox "Done: saved " & NumberOfBarcodes & " barcodes in PNG format with values starting from " & CStr(StartValue) & " to " &  CStr(j) & " (including) with step by " & CStr(StepValue)

' deinitialize barcode sdk
Set bc = Nothing


```

<!-- code block end -->