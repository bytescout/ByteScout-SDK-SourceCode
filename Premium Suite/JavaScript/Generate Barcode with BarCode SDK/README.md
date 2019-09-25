## How to generate barcode with barcode SDK in JavaScript with ByteScout Premium Suite

### Learn to generate barcode with barcode SDK in JavaScript

Every ByteScout tool includes simple example JavaScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout Premium Suite can generate barcode with barcode SDK. It can be applied from JavaScript. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

The following code snippet for ByteScout Premium Suite works best when you need to quickly generate barcode with barcode SDK in your JavaScript application. IF you want to implement the functionality, just copy and paste this code for JavaScript below into your code editor with your app, compile and run your application. Complete and detailed tutorials and documentation are available along with installed ByteScout Premium Suite if you'd like to learn more about the topic and the details of the API.

All these programming tutorials along with source code samples and ByteScout free trial version are available for download from our website.

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