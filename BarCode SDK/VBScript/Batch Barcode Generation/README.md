## batch barcode generation in VBScript and ByteScout Barcode SDK

### Make batch barcode generation in VBScript: ### Tutorial on how to do batch barcode generation in VBScript

Today you are going to learn how to batch barcode generation in VBScript. ByteScout Barcode SDK was made to help with batch barcode generation in VBScript. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images.

The SDK samples like this one below explain how to quickly make your application do batch barcode generation in VBScript with the help of ByteScout Barcode SDK. To do batch barcode generation in your VBScript project or application you may simply copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample VBScript codes to implement batch barcode generation using ByteScout Barcode SDK.

Trial version can be obtained from our website for free. It includes this and other source code samples for VBScript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=REnj3A-oSPI](https://www.youtube.com/watch?v=REnj3A-oSPI)




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