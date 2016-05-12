<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML to PDF Results</title>
</head>
<body>

<?php 

// Include library
require_once("BytescoutApi/autoload.php");

// Create HTML To PDF API object instance
$apiInstance = new Bytescout\Client\Api\HTMLToPDFApi();

// Read submitted form data to variables
$apiKey = $_POST["apiKey"]; // set API Key
$propertiesOrientation = $_POST["orientation"]; // set orientation
$propertiesMarginsRight = $_POST["marginLeft"]; // set left margin
$propertiesMarginsTop = $_POST["marginTop"]; // set top margin
$marginRight = $_POST["marginRight"]; // set right margin
$propertiesMarginsBottom = $_POST["marginBottom"]; // set bottom margin
$inputType = $_POST["inputUrl"] != "" ? "link" : "value"; // set input data type (paget URL or HTML code)
$input = $_POST["inputUrl"] != "" ? $_POST["inputUrl"] : $_POST["inputHtmlCode"]; // set intput data

$outputType = "link"; // set output type to "link"

try 
{
    // Get generated PDF file as link
    $result = $apiInstance->hTMLToPDFGetHtmlToPdf($apiKey, $propertiesTitle, $propertiesOrientation, $propertiesPageSizeWidth, 
        $propertiesPageSizeHeight, $propertiesPageSizeUnit, $propertiesMarginsBottom, $propertiesMarginsLeft, 
        $propertiesMarginsRight, $propertiesMarginsTop, $propertiesMarginsUnit, $propertiesPrintBackground, $propertiesHeaderHTML, 
        $propertiesFooterHTML, $propertiesTemplateData, $outputType, $input, $inputType);
    
    // Display the download link
    echo "<div><h2>Conversion Result:</h2><a href='" . $result . "' target='_blank'>" . $result . "</a></div>";
} 
catch (Exception $e) 
{
    echo 'Exception when calling HTMLToPDFApi->hTMLToPDFGetHtmlToPdf: ', $e->getMessage(), "\n";
    
    if ($e instanceof Bytescout\Client\ApiException)
        echo $e->getResponseObject() . "<br/><br/>";
}

?>

</body>
</html>