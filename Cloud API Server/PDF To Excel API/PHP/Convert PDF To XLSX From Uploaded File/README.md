## How to convert PDF to XLSX from uploaded file for PDF to excel API in PHP using ByteScout Cloud API Server

### How to convert PDF to XLSX from uploaded file in PHP with easy ByteScout code samples to make PDF to excel API. Step-by-step tutorial

We regularly create and update our sample code library so you may quickly learn PDF to excel API and the step-by-step process in PHP. ByteScout Cloud API Server helps with PDF to excel API in PHP. ByteScout Cloud API Server is the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

Use the code displayed below in your application to save a lot of time on writing and testing code. For implementation of this functionality, please copy and paste the code below into your app using code editor. Then compile and run your app. You can use these PHP sample examples in one or many applications.

Trial version of ByteScout is available for free download from our website. This and other source code samples for PHP and other programming languages are available.

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

##### **pdf-to-excel.php:**
    
```
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PDF To Excel Extraction Results</title>
</head>
<body>

<?php 

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

// Get submitted form data
  
$pages = $_POST["pages"];


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
                // 3. CONVERT UPLOADED PDF FILE TO Excel
                
                ExtractExcel($uploadedFileUrl, $pages);
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

function ExtractExcel($uploadedFileUrl, $pages) 
{
    // Create URL
    $url = "https://localhost/pdf/convert/to/xlsx" .
        "?url=" . $uploadedFileUrl .
        "&pages=" . $pages;
        
    // (!) If you need the old XLS format use `https://localhost/pdf/convert/to/xls` endpoint,
    
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