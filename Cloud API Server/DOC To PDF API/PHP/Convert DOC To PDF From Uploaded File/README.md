## How to convert DOC to PDF from uploaded file for DOC to PDF API in PHP using ByteScout Cloud API Server What is ByteScout Cloud API Server? It is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### **doc-to-pdf.php:**
    
```
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>DOC To PDF Conversion Results</title>
</head>
<body>

<?php 

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

// Get submitted form data
  
// 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
// * If you already have the direct PDF file link, go to the step 3.

// Create URL
$url = "https://localhost/file/upload/get-presigned-url" . 
    "?name=" . $_FILES["file"]["name"] .
    "&contenttype=application/octet-stream";
    
// Create request
$curl = curl_init();

curl_setopt($curl, CURLOPT_URL, $url);
curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);
// Execute request
$result = curl_exec($curl);

if (curl_errno($curl) == 0)
{
    $status_code = curl_getinfo($curl, CURLINFO_HTTP_CODE);
    
    if ($status_code == 200)
    {
        $json = json_decode($result, true);
        
        if ($json["error"] == false)
        {
            // Get URL to use for the file upload
            $uploadFileUrl = $json["presignedUrl"];
            // Get URL of uploaded file to use with later API calls
            $uploadedFileUrl = $json["url"];
            
            // 2. UPLOAD THE FILE TO CLOUD.
            
            $localFile = $_FILES["file"]["tmp_name"];
            $fileHandle = fopen($localFile, "r");
            
            curl_setopt($curl, CURLOPT_URL, $uploadFileUrl);
            curl_setopt($curl, CURLOPT_HTTPHEADER, array("content-type: application/octet-stream"));
            curl_setopt($curl, CURLOPT_PUT, true);
            curl_setopt($curl, CURLOPT_INFILE, $fileHandle);
            curl_setopt($curl, CURLOPT_INFILESIZE, filesize($localFile));
    
            // Execute request
            curl_exec($curl);
            
            fclose($fileHandle);
            
            if (curl_errno($curl) == 0)
            {
                $status_code = curl_getinfo($curl, CURLINFO_HTTP_CODE);
                
                if ($status_code == 200)
                {
                    // 3. CONVERT UPLOADED DOC FILE TO PDF
                    
                    DocToPdf($uploadedFileUrl, $pages);
                }
                else
                {
                    // Display request error
                    echo "<p>Status code: " . $status_code . "</p>"; 
                    echo "<p>" . $result . "</p>"; 
                }
            }
            else
            {
                // Display CURL error
                echo "Error: " . curl_error($curl);
            }
        }
        else
        {
            // Display service reported error
            echo "<p>Error: " . $json["message"] . "</p>"; 
        }
    }
    else
    {
        // Display request error
        echo "<p>Status code: " . $status_code . "</p>"; 
        echo "<p>" . $result . "</p>"; 
    }
    
    curl_close($curl);
}
else
{
    // Display CURL error
    echo "Error: " . curl_error($curl);
}

function DocToPdf($uploadedFileUrl, $pages) 
{
    // Create URL
    $url = "https://localhost/pdf/convert/from/doc" . 
        "?url=" . $uploadedFileUrl .
        "&pages=" . $pages;
    
    // Create request
    $curl = curl_init();
    
    curl_setopt($curl, CURLOPT_URL, $url);
    curl_setopt($curl, CURLOPT_POST, true);
    curl_setopt($curl, CURLOPT_RETURNTRANSFER, 1);

    // Execute request
    $result = curl_exec($curl);
    
    if (curl_errno($curl) == 0)
    {
        $status_code = curl_getinfo($curl, CURLINFO_HTTP_CODE);
        
        if ($status_code == 200)
        {
            $json = json_decode($result, true);
            
            if ($json["error"] == false)
            {
                $resultFileUrl = $json["url"];
            
                // Display link to the file with conversion results
                echo "<div>## Conversion Result:<a href='" . $resultFileUrl . "' target='_blank'>" . $resultFileUrl . "</a></div>";
            }
            else
            {
                // Display service reported error
                echo "<p>Error: " . $json["message"] . "</p>"; 
            }
        }
        else
        {
            // Display request error
            echo "<p>Status code: " . $status_code . "</p>"; 
            echo "<p>" . $result . "</p>"; 
        }
    }
    else
    {
        // Display CURL error
        echo "Error: " . curl_error($curl);
    }
    
    // Cleanup
    curl_close($curl);
}

?>

</body>
</html>
```

<!-- code block end -->