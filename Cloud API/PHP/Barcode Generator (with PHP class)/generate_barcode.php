<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Barcode Generation Results</title>
</head>
<body>

<?php 

// Include library
require_once("BytescoutApi/autoload.php");

// Create Barcode API object instance
$barcodeApiInstance = new Bytescout\Client\Api\BarcodeApi();

// Set options
$apikey = $_POST["apiKey"]; // set API Key from submitted form data
$propertiesSymbology = $_POST["barcodeType"]; // set barcode type from submitted form data
$propertiesOutputFileType = "png"; // set result image file format
$inputType = "value"; // set intput type to 'value'
$input = $_POST["inputValue"]; // set barcode value from submitted form data
$outputType = "link"; // result will be a link to generated image file

try 
{
    // Get generated barcode image as link
    $result = $barcodeApiInstance->barcodeGetBarcode($apikey, $propertiesOutputFileType, $propertiesTiffUse1BitFormat, $propertiesProduceMonochromeImages, 
        $propertiesAdditionalCaption, $propertiesAddChecksum, $propertiesAddChecksumToCaption, $propertiesCaption, $propertiesDrawCaption, 
        $propertiesDrawCaptionFor2DBarcodes, $propertiesDrawQuietZones, $propertiesSymbology, $propertiesSupplementValue, $propertiesAdditionalCaptionFont, 
        $propertiesBarHeight, $propertiesCaptionFont, $propertiesNarrowBarWidth, $propertiesWideToNarrowRatio, $propertiesAdditionalCaptionPosition, 
        $propertiesAngle, $propertiesBackColor, $propertiesCaptionPosition, $propertiesForeColor, $propertiesMarginsTop, $propertiesMarginsBottom, 
        $propertiesMarginsLeft, $propertiesMarginsRight, $propertiesSmoothingMode, $propertiesRenderingHint, $propertiesResolutionX, $propertiesResolutionY, 
        $propertiesCutUnusedSpace, $propertiesPreserveMinReadableSize, $propertiesSizeHeight, $propertiesSizeWidth, $propertiesSizeUnitOfMeasure, 
        $outputType, $input, $inputType);
    
    // Display barcode image
    echo "<div><h2>Result:</h2><img src=" . $result . "></div>";
} 
catch (Exception $e) 
{
    echo 'Exception when calling BarcodeApi->barcodeGetBarcode: ', $e->getMessage(), "<br/><br/>";
    
    if ($e instanceof Bytescout\Client\ApiException)
        echo $e->getResponseObject() . "<br/><br/>";
}

?>

</body>
</html>