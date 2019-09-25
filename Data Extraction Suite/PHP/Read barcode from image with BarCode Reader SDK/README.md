## How to read barcode from image with barcode reader SDK in PHP using ByteScout Data Extraction Suite

### Learn to code in PHP to read barcode from image with barcode reader SDK with this step-by-step tutorial

The documentation is designed for a specific purpose to help you to apply the features on your side. What is ByteScout Data Extraction Suite? It is the bundle that includes three SDK tools for data extraction from PDF, scans, images and from spreadsheets: PDF Extractor SDK, Data Extraction SDK, Barcode Reader SDK. It can help you to read barcode from image with barcode reader SDK in your PHP application.

 These PHP code samples for PHP guide developers to speed up coding of the application when using ByteScout Data Extraction Suite. Follow the instructions from scratch to work and copy the PHP code. Enjoy writing a code with ready-to-use sample PHP codes.

If you want to try other source code samples then the free trial version of ByteScout Data Extraction Suite is available for download from our website. Just try other source code samples for PHP.

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

##### ****HelloWorld.php:**
    
```
<?php

// this PHP script reads barcodes from image using BarCode Reader SDK

/*

IMPORTANT: 
to use COM objects in PHP need to enable it by adding the following line into php.ini:

extension=php_com_dotnet.dll

If you are usiung EasyPHP DevServer then to edit php.ini just right-click on the tray icon and select "Configuration"->"PHP"
*/

try
{

// create reader object
$reader = new COM("Bytescout.BarCodeReader.Reader");

// Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
// Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
// or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
$bc->BarcodeTypesToFind->SetAll1D();

$bc->ReadFromFile("BarcodePhoto.jpg");

For(i = 0; i< $bc->FoundCount-1; i++)
{
    echo "Found barcode on page #" . $bc->GetFoundBarcodePage(i)) . " with type " . $bc->GetFoundBarcodeType(i) . " and value " & bc.GetFoundBarcodeValue(i) & vbCRLF & " and confidence=" . $bc->GetFoundBarcodeConfidence(i)
}


}
catch(Exception $err) // catch exception if any
{
    header("Content-Type: text/plain"); // switch to plain text output type
    echo($err->getMessage()); // write error message to the output
}


?>
```

<!-- code block end -->