<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PDF Extractor Results</title>
</head>
<body>

<?php 

// Get submitted form data
$apiKey = $_POST["apiKey"];
$extractionType = $_POST["extractionType"];
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
        // 2. Extraction
        switch ($extractionType) {
            case '0':
                ExtractText($apiKey, $result, $pageIndex);
                break;
            case '1':
                ExtractCSV($apiKey, $result, $pageIndex);
                break;
            case '2':
                ExtractXLS($apiKey, $result, $pageIndex);
                break;
            case '3':
                ExtractXML($apiKey, $result, $pageIndex);
                break;
            case '4':
                ExtractJSON($apiKey, $result, $pageIndex);
                break;
            case '5':
                ExtractInfo($apiKey, $result, $pageIndex);
                break;
        }
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


function ExtractText($apiKey, $uploadedFileId, $pageIndex) 
{
    // Create Text Extractor API URL
    $url = "https://bytescout.io/api/v1/pdfextractor/textextractor/extract?apiKey=" . $apiKey;
    
    // Create Text Extractor options
    $options = array(
        "properties" => array(
            "startPageIndex" => $pageIndex, 
            "endPageIndex" => $pageIndex,
            "extractInvisibleText" => false
            ),
        "inputType" => "fileId",
        "input" => $uploadedFileId,
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
            // Display extraction results
            echo "<div><h2>Extraction Results:</h2><pre>" . $result . "</pre></div>";
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

function ExtractCSV($apiKey, $uploadedFileId, $pageIndex) 
{
    // Create CSV Extractor API URL
    $url = "https://bytescout.io/api/v1/pdfextractor/csvextractor/extract?apiKey=" . $apiKey;
    
    // Create CSV Extractor options
    $options = array(
        "properties" => array(
            "startPageIndex" => $pageIndex,
            "endPageIndex" => $pageIndex,
            "extractInvisibleText" => false
            ),
        "inputType" => "fileId",
        "input" => $uploadedFileId,
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
            // Display extraction results
            echo "<div><h2>Extraction Results:</h2><pre>" . $result . "</pre></div>";
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

function ExtractXLS($apiKey, $uploadedFileId, $pageIndex) 
{
    // Create XLS Extractor API URL
    $url = "https://bytescout.io/api/v1/pdfextractor/xlsextractor/extract?apiKey=" . $apiKey;
    
    // Create XLS Extractor options
    $options = array(
        "properties" => array(
            "startPageIndex" => $pageIndex,
            "endPageIndex" => $pageIndex,
            "extractInvisibleText" => false,
            "outputFormat" => "xlsx"
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
            // Display extraction results
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

function ExtractXML($apiKey, $uploadedFileId, $pageIndex) 
{
    // Create XML Extractor API URL
    $url = "https://bytescout.io/api/v1/pdfextractor/xmlextractor/extract?apiKey=" . $apiKey;
    
    // Create XML Extractor options
    $options = array(
        "properties" => array(
            "startPageIndex" => $pageIndex,
            "endPageIndex" => $pageIndex,
            "extractInvisibleText" => false
            ),
        "inputType" => "fileId",
        "input" => $uploadedFileId,
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
            // Display extraction results
            echo "<div><h2>Extraction Results:</h2><pre>" . htmlentities($result) . "</pre></div>";
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

function ExtractJSON($apiKey, $uploadedFileId, $pageIndex) 
{
    // Create JSON Extractor API URL
    $url = "https://bytescout.io/api/v1/pdfextractor/jsonextractor/extract?apiKey=" . $apiKey;
    
    // Create JSON Extractor options
    $options = array(
        "properties" => array(
            "startPageIndex" => $pageIndex,
            "endPageIndex" => $pageIndex,
            "extractInvisibleText" => false
            ),
        "inputType" => "fileId",
        "input" => $uploadedFileId,
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
            // Display extraction results
            echo "<div><h2>Extraction Results:</h2><pre>" . $result . "</pre></div>";
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

function ExtractInfo($apiKey, $uploadedFileId) 
{
    // Create Info Extractor API URL
    $url = "https://bytescout.io/api/v1/pdfextractor/infoextractor/extract?apiKey=" . $apiKey;
    
    // Create Info Extractor options
    $options = array(
        "inputType" => "fileId",
        "input" => $uploadedFileId,
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
            // Display extracted info
            echo "<div><h2>Document Info:</h2><pre>" . $result . "</pre></div>";
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