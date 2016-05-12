<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Barcode Reader Results</title>
</head>
<body>

<?php 

// Get submitted form data
$apiKey = $_POST["apiKey"];
$barcodeTypesToFind = $_POST["barcodeTypesToFind"];


// 1. UPLOAD FILE

// Create File API URL
$url = "https://bytescout.io/api/v1/file/upload?apiKey=" . $apiKey; // Get your API key at http://www.bytescout.io/

// Create request
$curl = curl_init();
curl_setopt($curl, CURLOPT_URL, $url);
curl_setopt($curl, CURLOPT_POST, true);
curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($curl, CURLOPT_POSTFIELDS, array(
    "file" => "@" . $_FILES["file"]["tmp_name"] . ";filename=" . $_FILES["file"]["name"]
    ));
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
        // 2. READ BARCODES FROM UPLOADED FILE
        readBarcode($apiKey, $barcodeTypesToFind, $result);
    }
    else
    {
        // Display service reported error
        echo "<p>Status code: " . $status_code . "</p>"; 
        echo "<p>" . $result . "</p>"; 
    }
}

// Cleanup
curl_close($curl);


function readBarcode($apiKey, $barcodeTypesToFind, $uploadedFileId) 
{
    // Create Barcode Reader API URL
    $url = "https://bytescout.io/api/v1/barcodereader/read?apiKey=" . $apiKey;
    
    // Create Barcode Reader options
    $options = array(
        "properties" => array(
            "startPageIndex" => 0,
            "endPageIndex" => 0,
            "barcodeTypesToFind" => array(),
            "pdfRenderingResolution" => 300
            ),
        "inputType" => "fileId",
        "input" => $uploadedFileId,
        "outputType" => "content"
        );
    // Fill selected barcode types
    foreach ($barcodeTypesToFind as &$barcodeType)
        $options["properties"]["barcodeTypesToFind"][$barcodeType] = true;

    // Create request
    $curl = curl_init();
    curl_setopt($curl, CURLOPT_URL, $url);
    curl_setopt($curl, CURLOPT_POST, true);
    curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);
    curl_setopt($curl, CURLOPT_HTTPHEADER, array("Content-type: application/json"));
    curl_setopt($curl, CURLOPT_POSTFIELDS, json_encode($options));
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
            // Display decoding results
            echo "<div><h2>Decoding Results:</h2><pre>" . $result . "</pre></div>";
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
}

?>

</body>
</html>