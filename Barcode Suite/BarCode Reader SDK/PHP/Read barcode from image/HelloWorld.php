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