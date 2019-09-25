## How to read barcode from image in PHP with ByteScout BarCode Reader SDK

### How to code in PHP to read barcode from image with this step-by-step tutorial

These sample source codes on this page below are demonstrating how to read barcode from image in PHP. ByteScout BarCode Reader SDK: the barcode decoder with support for code 39, code 128, QR Code, Datamatrix, GS1, PDF417 and all other popular barcodes. Can read barcodes from images, pdf, tiff documents and live web camera. Supports noisy and damaged documents, can split and merge pdf and tiff documents based on barcodes. Can export barcode decoder results to XML, JSON, CSV and into custom data structures. It can read barcode from image in PHP.

PHP code samples for PHP developers help to speed up coding of your application when using ByteScout BarCode Reader SDK. Just copy and paste the code into your PHP application’s code and follow the instruction. Use of ByteScout BarCode Reader SDK in PHP is also explained in the documentation included along with the product.

Our website provides trial version of ByteScout BarCode Reader SDK for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20BarCode%20Reader%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20BarCode%20Reader%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=EARSPJFIJMU](https://www.youtube.com/watch?v=EARSPJFIJMU)




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