## How to generate barcode in JavaScript with ByteScout Barcode SDK

### How to code in JavaScript to generate barcode with this step-by-step tutorial

The sample shows steps and algorithm of how to generate barcode and how to make it work in your JavaScript application. ByteScout Barcode SDK is the fully featured library to generate barcodes. Supports QR Code, Code 39, Code 128, UPC, GS1, GS-128, PDF417, Datamatrix and many other barcode types. Includes various options for barcode generation to ensure output quality, add barcodes to new or existing pdf files and images. It can be used to generate barcode using JavaScript.

This rich sample source code in JavaScript for ByteScout Barcode SDK includes the number of functions and options you should do calling the API to generate barcode. This JavaScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Enjoy writing a code with ready-to-use sample codes in JavaScript.

Our website provides trial version of ByteScout Barcode SDK for free. It also includes documentation and source code samples.

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

##### ****HelloWorld.js:**
    
```

 var bc = WScript.CreateObject('Bytescout.BarCode.Barcode');

 // set symbology to Code39
 bc.Symbology = 1; // 1 = Code39 symbology type

 // set barcode value to encode
 bc.Value = "012345";

 // Saving Code39 barcode to 'Code39.png'

 bc.SaveImage ("Code39.png");

 // Encoding '012345' using Aztec symbology

 // set symbology to Aztec (2D)
 bc.Symbology = 17; // 17 = Aztec

 // set barcode value to encode
 bc.Value = "012345";

 // Encoding '012345' using Aztec  symbology" & vbCRLF & bc.GetValueRestrictions(17), where 17 = Code39 symbology

 bc.SaveImage ("Aztec.png");

 bc = null

```

<!-- code block end -->