<?php

$curl = curl_init();

// You can also upload your own file into PDF.co and use it as url. Check "Upload File" samples for code snippets: https://github.com/bytescout/pdf-co-api-samples/tree/master/File%20Upload/    
curl_setopt_array($curl, array(
		CURLOPT_URL => "https://api.pdf.co/v1/email/decode",
		CURLOPT_RETURNTRANSFER => true,
		CURLOPT_ENCODING => "",
		CURLOPT_MAXREDIRS => 10,
		CURLOPT_TIMEOUT => 0,
		CURLOPT_FOLLOWLOCATION => true,
		CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
		CURLOPT_CUSTOMREQUEST => "POST",
		CURLOPT_POSTFIELDS => array('url' => 'https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/email-extractor/sample.eml'),
		CURLOPT_HTTPHEADER => array(
				"Content-Type: application/json",
				"x-api-key: {{x-api-key}}"
		),
));

$response = curl_exec($curl);

curl_close($curl);
echo $response;
