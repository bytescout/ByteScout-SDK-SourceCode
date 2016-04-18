<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Spreadsheet Conversion Results</title>
</head>
<body>

<?php 

// Get submitted form data
$apiKey = $_POST["apiKey"];
$targetFormat = $_POST["targetFormat"];


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
        // 2. Convert spreadsheet
        convertSpreadsheet($apiKey, $targetFormat, $result);
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


function convertSpreadsheet($apiKey, $targetFormat, $uploadedFileId) 
{
    // Create Spreadsheet API URL
    $url = "https://bytescout.io/api/v1/spreadsheet/convert?apiKey=" . $apiKey;
    
    // Create Spreadsheet API options
    $options = array(
        "properties" => array(
            "convertType" => $targetFormat,
            "createNavigationLinks" => true,
            "autoSize" => false
            ),
        "inputType" => "fileId",
        "input" => $uploadedFileId,
        "outputType" => "link"
        );

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
            // Display conversion result
            echo "<div><h2>Conversion Result:</h2><a href='" . $result . "' target='_blank'>" . $result . "</a></div>";
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