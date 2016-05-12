<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Barcode Generation Results</title>
</head>
<body>

<?php 

// Get submitted form data
$apiKey = $_POST["apiKey"];
$barcodeValue = $_POST["inputValue"];
$barcodeType = $_POST["barcodeType"];

// Create Barcode API URL
$url = "https://bytescout.io/api/v1/barcode/generate?apiKey=" . $apiKey; // Get your API key at http://www.bytescout.io/

// Create Barcode options
$options = json_encode(array(
    "properties" => array(
        "symbology" => $barcodeType),
    "inputType" => "value",
    "input" => $barcodeValue,
    "outputType" => "link"
    ));

// Create request
$curl = curl_init();
curl_setopt($curl, CURLOPT_URL, $url);
curl_setopt($curl, CURLOPT_POST, true);
curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($curl, CURLOPT_HTTPHEADER, array("Content-type: application/json"));
curl_setopt($curl, CURLOPT_POSTFIELDS, $options);
// Execute request
$result = curl_exec($curl);

if (curl_errno($curl))
{
    // Display request error
    echo "Error: " . curl_error($curl);
}
else // Display request results
{
    $status_code = curl_getinfo($curl, CURLINFO_HTTP_CODE);
    if ($status_code == 200)
    {
        // Display barcode image
        echo "<div><h2>Result:</h2><img src=" . $result . "></div>";
    }
    else
    {
        // Display service reported error
        echo "<p>Status code: " . $status_code . "</p>"; 
        $obj = json_decode($result);
        echo "<p>" . $result . "</p>"; 
    }
}

// Cleanup
curl_close($curl);

?>

</body>
</html>