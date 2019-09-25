## How to read barcode from image with barcode reader SDK in PHP using ByteScout Premium Suite

### Learn to read barcode from image with barcode reader SDK in PHP

We made thousands of pre-made source code pieces for easy implementation in your own programming projects. ByteScout Premium Suite can read barcode from image with barcode reader SDK. It can be applied from PHP. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

Want to save time? You will save a lot of time on writing and testing code as you may just take the PHP code from ByteScout Premium Suite for read barcode from image with barcode reader SDK below and use it in your application. Just copy and paste the code into your PHP application’s code and follow the instructions. Check PHP sample code samples to see if they respond to your needs and requirements for the project.

The trial version of ByteScout Premium Suite can be downloaded for free from our website. It also includes source code samples for PHP and other programming languages.

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