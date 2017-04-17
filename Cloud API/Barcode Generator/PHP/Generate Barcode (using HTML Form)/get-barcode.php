<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PDF Extractor Results</title>
</head>
<body>

<?php 

// Get submitted form data
$apiKey = $_POST["apiKey"]; // The authentication key (API Key). Get your own by registering at https://secure.bytescout.com/users/sign_up
$barcodeType = $_POST["barcodeType"];
$barcodeValue = $_POST["inputValue"];


// Create URL
$url = "https://bytescout.io/v1/barcode/generate" . 
    "?value=" . $barcodeValue .
    "&type=" . $barcodeType;

// Create request
$curl = curl_init();
curl_setopt($curl, CURLOPT_HTTPHEADER, array("x-api-key: " . $apiKey));
curl_setopt($curl, CURLOPT_URL, $url);
curl_setopt($curl, CURLOPT_POST, true);
curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);

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
        $json = json_decode($result, true);
        $resultFileUrl = $json["url"];
        
        // Display generated image
        echo "<div><h2>Result:</h2><img src=" . $resultFileUrl . "></div>";
    }
    else
    {
        // Display service reported errors
        echo "<p>Status code: " . $status_code . "</p>"; 
        echo "<p>" . $result . "</p>"; 
    }
}

// Cleanup
curl_close($curl);

?>

</body>
</html>