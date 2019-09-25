## How to generate barcode with barcode SDK in JavaScript using ByteScout Barcode Suite

### Step-by-step tutorial on how to generate barcode with barcode SDK in JavaScript

The coding instructions are formulated to help you to try-out the features without the requirement to write your own code. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK and you can use it to generate barcode with barcode SDK with JavaScript.

Want to quickly learn? This fast application programming interfaces of ByteScout Barcode Suite for JavaScript plus the guidelines and the code below will help you quickly learn how to generate barcode with barcode SDK. This JavaScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Complete and detailed tutorials and documentation are available along with installed ByteScout Barcode Suite if you'd like to learn more about the topic and the details of the API.

You can download free trial version of ByteScout Barcode Suite from our website with this and other source code samples for JavaScript.

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