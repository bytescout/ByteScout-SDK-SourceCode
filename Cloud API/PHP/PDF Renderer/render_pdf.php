<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PDF Renderer Results</title>
</head>
<body>

<?php 

// Get submitted form data
$apiKey = $_POST["apiKey"];
$rasterOutputFormat = $_POST["rasterOutputFormat"];
$resolution = $_POST["resolution"];
$pageIndex = $_POST["pageIndex"];


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
        // 2. RENDER DOCUMENT
        RenderPDF($apiKey, $rasterOutputFormat, $resolution, $pageIndex, $result);
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


function RenderPDF($apiKey, $rasterOutputFormat, $resolution, $pageIndex, $uploadedFileId) 
{
    // Create PDF Renderer API URL
    $url = "https://bytescout.io/api/v1/pdfrenderer/render?apiKey=" . $apiKey;
    
    // Create PDF Renderer  options
    $options = array(
        "properties" => array(
            "pageIndex" => $pageIndex,
            "resolution" => $resolution,
            "jpegQuality" => 85,
            "rasterOutputFormat" => $rasterOutputFormat
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
            // Display decoding results
            echo "<div><h2>Result:</h2><img src=" . $result . "></div>";
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