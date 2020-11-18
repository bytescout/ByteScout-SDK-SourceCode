<?php

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

$curl = curl_init();

curl_setopt_array($curl, array(
		CURLOPT_URL => "https://localhost/file/hash",
		CURLOPT_RETURNTRANSFER => true,
		CURLOPT_ENCODING => "",
		CURLOPT_MAXREDIRS => 10,
		CURLOPT_TIMEOUT => 0,
		CURLOPT_FOLLOWLOCATION => true,
		CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
		CURLOPT_CUSTOMREQUEST => "POST",
		CURLOPT_POSTFIELDS =>"{\n    \"url\": \"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf\"\n}",
		CURLOPT_HTTPHEADER => array(
				"x-api-key: {{x-api-key}}",
				"Content-Type: application/json"
		),
));

$response = curl_exec($curl);

curl_close($curl);
echo $response;
