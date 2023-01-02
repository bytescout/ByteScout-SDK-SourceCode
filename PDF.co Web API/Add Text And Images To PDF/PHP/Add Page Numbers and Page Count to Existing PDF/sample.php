<?php

$curl = curl_init();

curl_setopt_array($curl, array(
		CURLOPT_URL => 'https://api.pdf.co/v1/pdf/edit/add',
		CURLOPT_RETURNTRANSFER => true,
		CURLOPT_ENCODING => '',
		CURLOPT_MAXREDIRS => 10,
		CURLOPT_TIMEOUT => 0,
		CURLOPT_FOLLOWLOCATION => true,
		CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
		CURLOPT_CUSTOMREQUEST => 'POST',
		CURLOPT_POSTFIELDS =>'{
    "async": false,
    "encrypt": true,
    "inline": true,
    "name": "newDocument",
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/10pages.pdf",
    "annotations": [
        {
            "text": "Page {{$$PageNumber}} of {{$$PageCount}}",
            "x": 150,
            "y": 100,
            "size": 20,
            "pages": "0-"
        }
    ]
}',
		CURLOPT_HTTPHEADER => array(
				'Content-Type: application/json',
				'x-api-key: __YOUR_API_KEY_HERE__'
		),
));

$response = json_decode(curl_exec($curl));
curl_close($curl);
echo "<h2>Output:</h2><pre>", var_export($response, true), "</pre>";