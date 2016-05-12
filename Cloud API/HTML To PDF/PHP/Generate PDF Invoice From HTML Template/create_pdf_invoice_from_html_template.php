<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML to PDF Results</title>
</head>
<body>

<?php 

// Get your API key by registering at https://secure.bytescout.com/users/sign_up
$apiKey = "********************************";

// Load template and data from files
$templateData = file_get_contents("invoice_data.json");
$templateHtml = file_get_contents("invoice_template.html");

// Create HTML to PDF API URL
$url = "https://bytescout.io/api/v1/htmltopdf/convert?apiKey=" . $apiKey;

// Create HTML to PDF options
$options = array(
    "properties" => array(
        "templateData" => utf8_encode($templateData)
        ),
    "inputType" => "value",
    "input" => utf8_encode($templateHtml),
    "outputType" => "link" // get the result PDF document as download link
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

?>

</body>
</html>