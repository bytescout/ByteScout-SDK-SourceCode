<?php

$curl = curl_init();

curl_setopt_array($curl, array(
		CURLOPT_URL => "https://api.pdf.co/v1/file/upload",
		CURLOPT_RETURNTRANSFER => true,
		CURLOPT_ENCODING => "",
		CURLOPT_MAXREDIRS => 10,
		CURLOPT_TIMEOUT => 0,
		CURLOPT_FOLLOWLOCATION => true,
		CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
		CURLOPT_CUSTOMREQUEST => "POST",
		CURLOPT_POSTFIELDS => array('file'=> new CURLFILE('/path/to/file')),
		CURLOPT_HTTPHEADER => array(
				"x-api-key: {{x-api-key}}"
		),
));

$response = json_decode(curl_exec($curl));

curl_close($curl);
echo "<h2>Output:</h2><pre>", var_export($response, true), "</pre>";