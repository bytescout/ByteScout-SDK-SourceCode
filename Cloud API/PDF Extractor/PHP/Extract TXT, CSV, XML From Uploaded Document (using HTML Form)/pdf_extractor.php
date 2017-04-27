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
$extractionType = $_POST["extractionType"];
$pageIndex = $_POST["pageIndex"];


// 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
// * If you alredy have a direct PDF file link, go to the step 3.

// Create URL
$url = "https://bytescout.io/v1/file/upload/get-presigned-url" . 
    "?name=" . $_FILES["file"]["name"] .
    "&contenttype=binary/octet-stream";
    
// Create request
$curl = curl_init();
curl_setopt($curl, CURLOPT_HTTPHEADER, array("x-api-key: " . $apiKey));
curl_setopt($curl, CURLOPT_URL, $url);
curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);
// Execute request
$result = curl_exec($curl);

if (curl_errno($curl))
{
    // Display request error
    echo "Error: " . curl_error($curl);
}
else
{
    $status_code = curl_getinfo($curl, CURLINFO_HTTP_CODE);
    
    if ($status_code == 200)
    {
        $json = json_decode($result, true);
        $uploadFileUrl = $json["presignedUrl"];
        $accessFileUrl = $json["url"];
        
        // 2. UPLOAD THE FILE TO CLOUD.
        
        $localFile = $_FILES["file"]["tmp_name"];
        $fileHandle = fopen($localFile, "r");
        
        curl_setopt($curl, CURLOPT_URL, $uploadFileUrl);
        curl_setopt($curl, CURLOPT_HTTPHEADER, array("content-type: binary/octet-stream"));
        curl_setopt($curl, CURLOPT_PUT, true);
        curl_setopt($curl, CURLOPT_INFILE, $fileHandle);
        curl_setopt($curl, CURLOPT_INFILESIZE, filesize($localFile));

        // Execute request
        curl_exec($curl);
        
        fclose($fileHandle);
        
        if (curl_errno($curl))
        {
            // Display request error
            echo "Error: " . curl_error($curl);
        }
        else
        {
            $status_code = curl_getinfo($curl, CURLINFO_HTTP_CODE);
            if ($status_code == 200)
            {
                // 3. CONVERT THE FILE TO SELECTED FORMAT
                
                switch ($extractionType) {
                    case '0':
                        ExtractText($apiKey, $accessFileUrl, $pageIndex);
                        break;
                    case '1':
                        ExtractCSV($apiKey, $accessFileUrl, $pageIndex);
                        break;
                    case '2':
                        ExtractJSON($apiKey, $accessFileUrl, $pageIndex);
                        break;
                    case '3':
                        ExtractInfo($apiKey, $accessFileUrl, $pageIndex);
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
    }
    else
    {
        // Display service reported error
        echo "<p>Status code: " . $status_code . "</p>"; 
        echo "<p>" . $result . "</p>"; 
    }
    
    curl_close($curl);
}

function ExtractText($apiKey, $uploadedFileUrl, $pageIndex) 
{
    // Create URL
    $url = "https://bytescout.io/v1/pdf/convert/to/text" . 
        "?url=" . $uploadedFileUrl .
        "&pages=" . $pageIndex;
    
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
            
            // Display link to the file with conversion results
            echo "<div><h2>Conversion Result:</h2><a href='" . $resultFileUrl . "' target='_blank'>" . $resultFileUrl . "</a></div>";
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

function ExtractCSV($apiKey, $uploadedFileUrl, $pageIndex) 
{
    // Create URL
    $url = "https://bytescout.io/v1/pdf/convert/to/csv" . 
        "?url=" . $uploadedFileUrl .
        "&pages=" . $pageIndex;
    
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
            
            // Display link to the file with conversion results
            echo "<div><h2>Conversion Result:</h2><a href='" . $resultFileUrl . "' target='_blank'>" . $resultFileUrl . "</a></div>";
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

function ExtractJSON($apiKey, $uploadedFileUrl, $pageIndex) 
{
    // Create URL
    $url = "https://bytescout.io/v1/pdf/convert/to/json" . 
        "?url=" . $uploadedFileUrl .
        "&pages=" . $pageIndex;
    
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
            
            // Display link to the file with conversion results
            echo "<div><h2>Conversion Result:</h2><a href='" . $resultFileUrl . "' target='_blank'>" . $resultFileUrl . "</a></div>";
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

function ExtractInfo($apiKey, $uploadedFileUrl) 
{
    // Create URL
    $url = "https://bytescout.io/v1/pdf/info?url=" . $uploadedFileUrl;
    
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
            $documentInfo = $json["info"];

            // Display the document info
            echo "<div><h2>Document Info:</h2><p>";
            foreach ($documentInfo as $key => $value) {
                echo $key . ' = ' . $value . '<br/>';
            }
            echo "</p></div>";
        }
        else
        {
            // Display service reported errors
            echo "<p>Status code: " . $status_code . "</p>"; 
            echo "<p>" . $result . "</p>"; 
        }
    }
}

?>

</body>
</html>