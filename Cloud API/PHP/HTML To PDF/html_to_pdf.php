<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML to PDF Results</title>
</head>
<body>

<?php 

// Get submitted form data
$apiKey = $_POST["apiKey"];
$inputUrl = $_POST["inputUrl"];
$inputHtmlCode = $_POST["inputHtmlCode"];
$orientation = $_POST["orientation"];
$marginLeft = $_POST["marginLeft"];
$marginTop = $_POST["marginTop"];
$marginRight = $_POST["marginRight"];
$marginBottom = $_POST["marginBottom"];


// Create HTML to PDF API URL
$url = "https://bytescout.io/api/v1/htmltopdf/convert?apiKey=" . $apiKey;

// Create HTML to PDF options
$options = array(
    "properties" => array(
        "orientation" => $orientation,
        "margin" => array(
            "left" => $marginLeft,
            "top" => $marginTop,
            "right" => $marginRight,
            "bottom" => $marginBottom
            ),
        ),
    "inputType" => $inputUrl != "" ? "link" : "value",
    "input" => $inputUrl != "" ? $inputUrl : $inputHtmlCode,
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

?>

</body>
</html>