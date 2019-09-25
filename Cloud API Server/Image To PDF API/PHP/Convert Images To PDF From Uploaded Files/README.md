## How to convert images to PDF from uploaded files for image to PDF API in PHP using ByteScout Cloud API Server

### Follow this simple tutorial to learn convert images to PDF from uploaded files to have image to PDF API in PHP

The easy to understand coding guides help you check the features without any need to write your own code. ByteScout Cloud API Server was designed to assist image to PDF API in PHP. ByteScout Cloud API Server is API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

This simple and easy to understand sample source code in PHP for ByteScout Cloud API Server contains different functions and options you should do calling the API to implement image to PDF API. Follow the tutorial and copy - paste code for PHP into your project's code editor. This basic programming language sample code for PHP will do the whole work for you in implementing image to PDF API in your app.

Free! Free! Free! ByteScout free trial version is available for FREE download from our website. Programming tutorials along with source code samples are assembled.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****image-to-pdf.php:**
    
```
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Image To PDF Conversion Results</title>
</head>
<body>

<?php 

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

// Get submitted form data

// 1. UPLOAD FILES TO CLOUD
// If you already have direct file links, skip to Step 2.

$uploadedFiles = array();
$fileCount = count($_FILES["files"]["name"]);
if (!file_exists("./uploads")) {
    mkdir("./uploads");
}

for($i = 0; $i < $fileCount; $i++)
{
    // 1a. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
    
    // Create URL
    $url = "https://localhost/file/upload/get-presigned-url" . 
        "?name=" . $_FILES["files"]["name"][$i] .
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
            
            // 1b. UPLOAD THE FILE TO CLOUD.
            
            $tmpFilePath = $_FILES["files"]["tmp_name"][$i];
            $localFile = "./uploads/" . $_FILES["files"]['name'][$i];
            move_uploaded_file($tmpFilePath, $localFile);
            
            $fileHandle = fopen($localFile, "r");
            
            curl_setopt($curl, CURLOPT_URL, $uploadFileUrl);
            curl_setopt($curl, CURLOPT_HTTPHEADER, array("content-type: application/octet-stream"));
            curl_setopt($curl, CURLOPT_PUT, true);
            curl_setopt($curl, CURLOPT_INFILE, $fileHandle);
            curl_setopt($curl, CURLOPT_INFILESIZE, filesize($localFile));
    
            // Execute request
            curl_exec($curl);
            
            if (curl_errno($curl) == 0)
            {
                $status_code = curl_getinfo($curl, CURLINFO_HTTP_CODE);
                
                if ($status_code == 200)
                {
                    $uploadedFiles[] = $uploadedFileUrl;
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
            
            fclose($fileHandle);
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
    
    curl_close($curl); 
}

// 2. CREATE PDF DOCUMENT FROM UPLOADED IMAGE FILES

if (count($uploadedFiles) > 0) 
{
    ImageToPdf($uploadedFiles);
}


function ImageToPdf($uploadedFiles) 
{
    // Create URL
    $url = "https://localhost/pdf/convert/from/image" .
        "?name=result.pdf" .
        "&url=" . join(",", $uploadedFiles);
    
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